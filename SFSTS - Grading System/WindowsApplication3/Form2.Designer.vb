<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchListBox = New System.Windows.Forms.ListBox()
        Me.GradeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearLevelComboBox = New System.Windows.Forms.ComboBox()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AYTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.GradeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchButton
        '
        Me.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchButton.Location = New System.Drawing.Point(290, 88)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(87, 27)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "&Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(571, 208)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(87, 27)
        Me.PrintButton.TabIndex = 1
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchTextBox.Location = New System.Drawing.Point(143, 89)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(141, 23)
        Me.SearchTextBox.TabIndex = 3
        '
        'SearchListBox
        '
        Me.SearchListBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchListBox.FormattingEnabled = True
        Me.SearchListBox.ItemHeight = 15
        Me.SearchListBox.Location = New System.Drawing.Point(143, 111)
        Me.SearchListBox.Name = "SearchListBox"
        Me.SearchListBox.Size = New System.Drawing.Size(139, 19)
        Me.SearchListBox.TabIndex = 4
        Me.SearchListBox.Visible = False
        '
        'GradeDataGridView
        '
        Me.GradeDataGridView.AllowUserToAddRows = False
        Me.GradeDataGridView.AllowUserToDeleteRows = False
        Me.GradeDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.GradeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GradeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.GradeDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GradeDataGridView.Location = New System.Drawing.Point(-2, 241)
        Me.GradeDataGridView.Name = "GradeDataGridView"
        Me.GradeDataGridView.Size = New System.Drawing.Size(770, 443)
        Me.GradeDataGridView.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Course Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Course Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 350
        '
        'Column3
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column3.HeaderText = "Hr/ Wk"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column4.HeaderText = "Grade"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle15
        Me.Column5.HeaderText = "Remark"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'YearLevelComboBox
        '
        Me.YearLevelComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YearLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearLevelComboBox.Enabled = False
        Me.YearLevelComboBox.FormattingEnabled = True
        Me.YearLevelComboBox.Items.AddRange(New Object() {"All", "First", "Second", "Third", "Fourth"})
        Me.YearLevelComboBox.Location = New System.Drawing.Point(143, 165)
        Me.YearLevelComboBox.Name = "YearLevelComboBox"
        Me.YearLevelComboBox.Size = New System.Drawing.Size(141, 23)
        Me.YearLevelComboBox.TabIndex = 6
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SemesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SemesterComboBox.Enabled = False
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Items.AddRange(New Object() {"All", "1", "2", "3"})
        Me.SemesterComboBox.Location = New System.Drawing.Point(396, 165)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(141, 23)
        Me.SemesterComboBox.TabIndex = 7
        '
        'NameTextBox
        '
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Location = New System.Drawing.Point(143, 136)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(141, 23)
        Me.NameTextBox.TabIndex = 8
        '
        'AYTextBox
        '
        Me.AYTextBox.Location = New System.Drawing.Point(396, 136)
        Me.AYTextBox.Name = "AYTextBox"
        Me.AYTextBox.Size = New System.Drawing.Size(116, 23)
        Me.AYTextBox.TabIndex = 9
        Me.AYTextBox.Visible = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(664, 208)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(87, 27)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "&Cancel"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Felix Titling", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(79, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(609, 28)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "St. Francis de Sales Theological Seminary"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(239, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Bachelor in Sacred Theology"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(-2, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(770, 10)
        Me.Label5.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(-2, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(770, 10)
        Me.Label6.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Search by Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Year Level:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(330, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Semester:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(768, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CourseToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CourseToolStripMenuItem.Text = "&Course"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 687)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.AYTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.SemesterComboBox)
        Me.Controls.Add(Me.YearLevelComboBox)
        Me.Controls.Add(Me.GradeDataGridView)
        Me.Controls.Add(Me.SearchListBox)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SFSTS - Grading System"
        CType(Me.GradeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchListBox As System.Windows.Forms.ListBox
    Friend WithEvents GradeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents YearLevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SemesterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
