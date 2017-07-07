<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.AddProgramButton = New System.Windows.Forms.Button()
        Me.EditProgramButton = New System.Windows.Forms.Button()
        Me.ProgramListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProgramCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeleteProgramButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.YearLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'AddProgramButton
        '
        Me.AddProgramButton.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProgramButton.Location = New System.Drawing.Point(129, 28)
        Me.AddProgramButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddProgramButton.Name = "AddProgramButton"
        Me.AddProgramButton.Size = New System.Drawing.Size(86, 26)
        Me.AddProgramButton.TabIndex = 45
        Me.AddProgramButton.Text = "&Add"
        Me.AddProgramButton.UseVisualStyleBackColor = True
        '
        'EditProgramButton
        '
        Me.EditProgramButton.Enabled = False
        Me.EditProgramButton.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditProgramButton.Location = New System.Drawing.Point(223, 28)
        Me.EditProgramButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EditProgramButton.Name = "EditProgramButton"
        Me.EditProgramButton.Size = New System.Drawing.Size(87, 26)
        Me.EditProgramButton.TabIndex = 46
        Me.EditProgramButton.Text = "&View/ Edit"
        Me.EditProgramButton.UseVisualStyleBackColor = True
        '
        'ProgramListView
        '
        Me.ProgramListView.CheckBoxes = True
        Me.ProgramListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ProgramListView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProgramListView.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgramListView.FullRowSelect = True
        Me.ProgramListView.GridLines = True
        Me.ProgramListView.Location = New System.Drawing.Point(7, 62)
        Me.ProgramListView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgramListView.Name = "ProgramListView"
        Me.ProgramListView.Size = New System.Drawing.Size(747, 528)
        Me.ProgramListView.TabIndex = 44
        Me.ProgramListView.UseCompatibleStateImageBehavior = False
        Me.ProgramListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = ""
        Me.ColumnHeader13.Width = 23
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "#"
        Me.ColumnHeader14.Width = 31
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Course Code"
        Me.ColumnHeader15.Width = 124
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Course Name"
        Me.ColumnHeader1.Width = 337
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Hr/ Wk"
        Me.ColumnHeader2.Width = 110
        '
        'ProgramCheckBox
        '
        Me.ProgramCheckBox.AutoSize = True
        Me.ProgramCheckBox.Location = New System.Drawing.Point(14, 34)
        Me.ProgramCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgramCheckBox.Name = "ProgramCheckBox"
        Me.ProgramCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ProgramCheckBox.TabIndex = 43
        Me.ProgramCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(6, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 15)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "*Click on the Course to be edited/ deleted."
        '
        'DeleteProgramButton
        '
        Me.DeleteProgramButton.Enabled = False
        Me.DeleteProgramButton.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteProgramButton.Location = New System.Drawing.Point(35, 28)
        Me.DeleteProgramButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DeleteProgramButton.Name = "DeleteProgramButton"
        Me.DeleteProgramButton.Size = New System.Drawing.Size(87, 26)
        Me.DeleteProgramButton.TabIndex = 42
        Me.DeleteProgramButton.Text = "&Delete"
        Me.DeleteProgramButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(553, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Semester:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Year Level:"
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SemesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Items.AddRange(New Object() {"All", "1", "2", "3"})
        Me.SemesterComboBox.Location = New System.Drawing.Point(619, 31)
        Me.SemesterComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(135, 23)
        Me.SemesterComboBox.TabIndex = 48
        '
        'YearLevelComboBox
        '
        Me.YearLevelComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YearLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearLevelComboBox.FormattingEnabled = True
        Me.YearLevelComboBox.Items.AddRange(New Object() {"All", "First", "Second", "Third", "Fourth"})
        Me.YearLevelComboBox.Location = New System.Drawing.Point(412, 31)
        Me.YearLevelComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.YearLevelComboBox.Name = "YearLevelComboBox"
        Me.YearLevelComboBox.Size = New System.Drawing.Size(135, 23)
        Me.YearLevelComboBox.TabIndex = 47
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 592)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SemesterComboBox)
        Me.Controls.Add(Me.YearLevelComboBox)
        Me.Controls.Add(Me.AddProgramButton)
        Me.Controls.Add(Me.EditProgramButton)
        Me.Controls.Add(Me.ProgramListView)
        Me.Controls.Add(Me.ProgramCheckBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DeleteProgramButton)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Courses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddProgramButton As System.Windows.Forms.Button
    Friend WithEvents EditProgramButton As System.Windows.Forms.Button
    Friend WithEvents ProgramListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProgramCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DeleteProgramButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SemesterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents YearLevelComboBox As System.Windows.Forms.ComboBox
End Class
