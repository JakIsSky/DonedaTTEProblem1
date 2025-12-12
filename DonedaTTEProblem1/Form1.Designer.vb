<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtArtifactName = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.cmbCondition = New System.Windows.Forms.ComboBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnSoftDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHiddenId = New System.Windows.Forms.TextBox()
        Me.DataGridViewRecord = New System.Windows.Forms.DataGridView()
        Me.txtYearFound = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtArtifactName
        '
        Me.txtArtifactName.Location = New System.Drawing.Point(111, 101)
        Me.txtArtifactName.Name = "txtArtifactName"
        Me.txtArtifactName.Size = New System.Drawing.Size(184, 20)
        Me.txtArtifactName.TabIndex = 0
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(111, 127)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(184, 20)
        Me.txtCountry.TabIndex = 1
        '
        'cmbCondition
        '
        Me.cmbCondition.FormattingEnabled = True
        Me.cmbCondition.Items.AddRange(New Object() {"Excellent", "Good", "Fair", "Poor"})
        Me.cmbCondition.Location = New System.Drawing.Point(111, 179)
        Me.cmbCondition.Name = "cmbCondition"
        Me.cmbCondition.Size = New System.Drawing.Size(184, 21)
        Me.cmbCondition.TabIndex = 3
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(12, 228)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(175, 43)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "Save Artirfact"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(193, 228)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(224, 43)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update Artirfact"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.Location = New System.Drawing.Point(12, 277)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(175, 43)
        Me.btnRead.TabIndex = 6
        Me.btnRead.Text = "Load Records"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnSoftDelete
        '
        Me.btnSoftDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoftDelete.Location = New System.Drawing.Point(193, 277)
        Me.btnSoftDelete.Name = "btnSoftDelete"
        Me.btnSoftDelete.Size = New System.Drawing.Size(224, 43)
        Me.btnSoftDelete.TabIndex = 7
        Me.btnSoftDelete.Text = "Delete Artirfact"
        Me.btnSoftDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Artifact Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Origin Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Year Discovered"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Condition"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(428, 37)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "HERITAGE CITY MESEUM"
        '
        'txtHiddenId
        '
        Me.txtHiddenId.Location = New System.Drawing.Point(111, 206)
        Me.txtHiddenId.Name = "txtHiddenId"
        Me.txtHiddenId.Size = New System.Drawing.Size(80, 20)
        Me.txtHiddenId.TabIndex = 14
        Me.txtHiddenId.Visible = False
        '
        'DataGridViewRecord
        '
        Me.DataGridViewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRecord.Location = New System.Drawing.Point(22, 341)
        Me.DataGridViewRecord.Name = "DataGridViewRecord"
        Me.DataGridViewRecord.Size = New System.Drawing.Size(593, 200)
        Me.DataGridViewRecord.TabIndex = 15
        '
        'txtYearFound
        '
        Me.txtYearFound.Location = New System.Drawing.Point(112, 154)
        Me.txtYearFound.Name = "txtYearFound"
        Me.txtYearFound.Size = New System.Drawing.Size(183, 20)
        Me.txtYearFound.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 553)
        Me.Controls.Add(Me.txtYearFound)
        Me.Controls.Add(Me.DataGridViewRecord)
        Me.Controls.Add(Me.txtHiddenId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSoftDelete)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.cmbCondition)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtArtifactName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridViewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArtifactName As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents cmbCondition As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnSoftDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHiddenId As TextBox
    Friend WithEvents DataGridViewRecord As DataGridView
    Friend WithEvents txtYearFound As TextBox
End Class
