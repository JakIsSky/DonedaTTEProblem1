Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim query As String = "INSERT INTO `museum_db`.`artifacts_tbl` (`artifact_name`, `country`, `year_found`, `condition`) VALUES (@artifact_name, @country, @year_found, @condition);"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@artifact_name", txtArtifactName.Text)
                    cmd.Parameters.AddWithValue("@country", txtCountry.Text)
                    cmd.Parameters.AddWithValue("@year_found", CInt(txtYearFound.Text))
                    cmd.Parameters.AddWithValue("@condition", cmbCondition.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record insert successfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim query As String = "SELECT * FROM museum_db.artifacts_tbl WHERE is_deleted = 0;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridViewRecord.DataSource = table
                DataGridViewRecord.Columns("id").Visible = False
                DataGridViewRecord.Columns("is_deleted").Visible = False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRecord.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewRecord.Rows(e.RowIndex)
            txtArtifactName.Text = selectedRow.Cells("artifact_name").Value.ToString()
            txtCountry.Text = selectedRow.Cells("country").Value.ToString()
            txtYearFound.Text = selectedRow.Cells("year_found").Value.ToString()
            cmbCondition.Text = selectedRow.Cells("condition").Value.ToString()

            txtHiddenId.Text = selectedRow.Cells("id").Value.ToString()

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE `museum_db`.`artifacts_tbl` SET `artifact_name`=@artifact_name, `country`=@country, `year_found`=@year_found, `condition`=@condition WHERE `id`=@id;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(txtHiddenId.Text))
                    cmd.Parameters.AddWithValue("@artifact_name", txtArtifactName.Text)
                    cmd.Parameters.AddWithValue("@country", txtCountry.Text)
                    cmd.Parameters.AddWithValue("@year_found", CInt(txtYearFound.Text))
                    cmd.Parameters.AddWithValue("@condition", cmbCondition.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSoftDelete_Click(sender As Object, e As EventArgs) Handles btnSoftDelete.Click
        Dim query As String = "UPDATE `museum_db`.`artifacts_tbl` SET `is_deleted`=1 WHERE `id`=@id;"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=museum_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("Id", CInt(txtHiddenId.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully!")
                    txtArtifactName.Clear()
                    txtCountry.Clear()
                    txtYearFound.Clear()
                    cmbCondition.ResetText()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
