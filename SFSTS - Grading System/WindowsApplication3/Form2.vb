
Option Strict On
Imports System.Data.SqlClient
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
'Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form2

    Const DATA_SOURCE_STRING As String = "(local)"
    Const INITIAL_CATALOG As String = "Student"
    Const CONNECTION_STRING As String = "server=.\SQLEXPRESS;database=Student;trusted_connection=true"
    Private myconn As New SqlConnection
    Private mycommand As New SqlCommand
    Private myreader As SqlDataReader
    Dim myadapter As New SqlDataAdapter
    Dim SQLString As String
    Dim StudNo As String
    Dim Stlname As String
    Dim Stfname As String
    Dim Stmname As String
    Dim AYStarted As Integer
    Dim YearLevel As Integer
    Dim Semester As Integer
    Dim StudNoList As New List(Of String)
    Dim CourseId As New List(Of Integer)

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        StudNoList.Clear()
        If SearchTextBox.Text = "" Then 'Or Studentnametextbox.Text = "Search by name..." Then
            SearchListBox.Visible = False
            SearchListBox.Height = 0
        Else
            Dim x As Integer = 30
            SearchListBox.Items.Clear()
            SearchListBox.BringToFront()

            SQLString = "SELECT distinct (Student_Last_name + ' ' + Student_First_name + ' ' + Student_Middle_name) As StudentName,StudentInfo.StudentID As studentid" & " FROM StudentInfo " & _
            " WHERE charindex('" & SearchTextBox.Text & "', Student_Last_name)!=0  OR charindex( '" & SearchTextBox.Text & "',Student_First_name) !=0 OR charindex('" & SearchTextBox.Text & "',(Student_Last_name + Student_First_name + Student_Middle_name)) !=0 OR charindex('" & SearchTextBox.Text & "',(Student_Last_name + Student_First_name + Student_Middle_name)) !=0 OR charindex('" & SearchTextBox.Text & "',(Student_Last_name + Student_First_name + Student_Middle_name)) !=0 OR charindex('" & SearchTextBox.Text & "',(Student_Last_name + Student_First_name + Student_Middle_name)) !=0 " '& _
            '" AND StudentInfos.studentid=StudentInfoYear.studentid"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    SearchListBox.Items.Add(myreader("StudentName").ToString)
                    StudNoList.Add(myreader("studentid").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                myconn.Close()
            End Try

            If StudNoList.Count > 6 Then
                SearchListBox.Visible = True
                SearchListBox.Height = 150
            ElseIf StudNoList.Count > 0 Then
                SearchListBox.Visible = True
                SearchListBox.Height = SearchListBox.Items.Count * x
            End If
        End If
    End Sub

    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        SearchTextBox.Clear()
        SQLString = "SELECT Student_Last_name,Student_First_name,Student_Middle_name " & "FROM StudentInfo WHERE StudentID='" & StudNo & "'"
        Try
            myconn.ConnectionString = CONNECTION_STRING
            myconn.Open()
            mycommand.Connection = myconn
            mycommand.CommandText = SQLString
            myreader = mycommand.ExecuteReader
            Do While myreader.Read
                Stlname = myreader("Student_Last_name").ToString
                Stfname = myreader("Student_First_name").ToString
                Stmname = myreader("Student_Middle_name").ToString
            Loop
            myconn.Close()
        Catch ex As Exception
            myconn.Close()
        End Try

        If StudNo = "" Then
            MessageBox.Show("Select a name first before searching.", "Searching Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SearchTextBox.Enabled = False
            SearchButton.Enabled = False
            NameTextBox.Clear()
            YearLevelComboBox.SelectedIndex = -1
            YearLevelComboBox.Enabled = True
            SemesterComboBox.Enabled = True
            SQLString = "SELECT Student_Last_name,Student_First_name,Student_Middle_name,Academic_Year_Started " & "FROM StudentInfo,StudentGrade WHERE StudentInfo.StudentID=StudentGrade.StudentID AND StudentInfo.StudentID='" & StudNo & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    NameTextBox.Text = myreader("Student_Last_name").ToString & ", " & myreader("Student_First_name").ToString & " " & myreader("Student_Middle_name").ToString
                    'YearLevelTextBox.Text = myreader("yearlevel").ToString
                    AYStarted = CInt(myreader("Academic_Year_Started").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                myconn.Close()
            End Try

            If NameTextBox.Text = "" Then
                YearLevelComboBox.SelectedIndex = -1
                YearLevelComboBox.Enabled = False
                SemesterComboBox.Enabled = False
                Dim result As Integer = MessageBox.Show("No Transcript of Record Found. Would you like to create a new TOR for " & Stfname & " " & Stmname & " " & Stlname & "?", "New Transcript of Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    CourseId.Clear()
                    SQLString = "SELECT courseid " & "FROM StudentCourse"
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        CourseId.Add(CInt(myreader("courseid").ToString))
                    Loop
                    myconn.Close()

                    For i = 0 To CourseId.Count - 1
                        SQLString = "insert into StudentGrade " & _
                                                  "VALUES('" & StudNo & "','" & CourseId.Item(i) & "','0')"

                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        With mycommand
                            .CommandText = SQLString
                            .Connection = myconn
                            .ExecuteNonQuery()
                        End With
                        myconn.Close()
                    Next
                    Grades()
                    SQLString = "SELECT Student_Last_name,Student_First_name,Student_Middle_name,Academic_Year_Started " & "FROM StudentInfo,StudentGrade WHERE StudentInfo.StudentID=StudentGrade.StudentID AND StudentInfo.StudentID='" & StudNo & "'"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            NameTextBox.Text = myreader("Student_Last_name").ToString & ", " & myreader("Student_First_name").ToString & " " & myreader("Student_Middle_name").ToString
                            'YearLevelTextBox.Text = myreader("yearlevel").ToString
                            AYStarted = CInt(myreader("Academic_Year_Started").ToString)
                        Loop
                        myconn.Close()
                    Catch ex As Exception
                        myconn.Close()
                    End Try
                    YearLevelComboBox.SelectedIndex = 1
                    YearLevelComboBox.Enabled = True
                    SemesterComboBox.Enabled = True
                    PrintButton.Enabled = True
                    MessageBox.Show("Successfully created new transcript of record.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    YearLevelComboBox.SelectedIndex = -1
                    YearLevelComboBox.Enabled = False
                    SemesterComboBox.Enabled = False
                    SearchTextBox.Enabled = True
                    SearchButton.Enabled = True
                    PrintButton.Enabled = False
                End If
            Else
                YearLevelComboBox.SelectedIndex = 1
                PrintButton.Enabled = True
            End If
        End If
    End Sub
    Dim Semesters As List(Of Integer)
    Sub Grades()
        If NameTextBox.Text = "" Then
        Else
            GradeDataGridView.Rows.Clear()
            CourseId.Clear()


            Dim CourseSubTotal As Integer = 0
            Dim YearLevelGroup As Integer = -1
            Dim SemesterGroup As Integer = 0
            If YearLevelComboBox.SelectedIndex = 0 And SemesterComboBox.SelectedIndex = 0 Then
                SemesterComboBox.Enabled = True
                For j = 0 To 3
                    Dim p As Integer = GradeDataGridView.Rows.Add
                    GradeDataGridView.Rows.Item(p).Cells(0).Value = ""
                    GradeDataGridView.Rows.Item(p).Cells(1).Value = "                                      " & YearLevelComboBox.Items(j + 1).ToString & " Year"
                    GradeDataGridView.Rows.Item(p).Cells(2).Value = ""
                    GradeDataGridView.Rows.Item(p).Cells(3).Value = ""
                    GradeDataGridView.Rows.Item(p).Cells(4).Value = ""
                    For i = 0 To 2

                        Dim g As Integer = GradeDataGridView.Rows.Add
                        GradeDataGridView.Rows.Item(g).Cells(0).Value = ""
                        GradeDataGridView.Rows.Item(g).Cells(1).Value = "                                      SEMESTER " & (i + 1).ToString
                        GradeDataGridView.Rows.Item(g).Cells(2).Value = ""
                        GradeDataGridView.Rows.Item(g).Cells(3).Value = ""
                        GradeDataGridView.Rows.Item(g).Cells(4).Value = ""
                        SQLString = "SELECT StudentGrade.courseid As courseid,coursecode,coursename,coursehr,grade,yearlevel,semester " & "FROM StudentGrade,StudentCourse WHERE StudentGrade.courseid=StudentCourse.courseid AND StudentID='" & StudNo & "' AND yearlevel='" & j + 1 & "' AND semester=" & (i + 1).ToString & ""
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        myreader = mycommand.ExecuteReader
                        Do While myreader.Read
                            CourseId.Add(CInt(myreader("courseid").ToString))
                            CourseSubTotal = CourseSubTotal + CInt(myreader("coursehr").ToString)
                            Dim n As Integer = GradeDataGridView.Rows.Add
                            GradeDataGridView.Rows.Item(n).Cells(0).Value = myreader("coursecode").ToString
                            GradeDataGridView.Rows.Item(n).Cells(1).Value = myreader("coursename").ToString
                            GradeDataGridView.Rows.Item(n).Cells(2).Value = myreader("coursehr").ToString
                            GradeDataGridView.Rows.Item(n).Cells(3).Value = myreader("grade").ToString


                            If CDec(myreader("grade").ToString) = 0 Then
                                GradeDataGridView.Rows.Item(n).Cells(4).Value = "N/A"
                            ElseIf CDec(myreader("grade").ToString) > 3 Then
                                GradeDataGridView.Rows.Item(n).Cells(4).Value = "Failed"
                                GradeDataGridView.Rows.Item(n).DefaultCellStyle.ForeColor = Color.Red
                            Else
                                GradeDataGridView.Rows.Item(n).Cells(4).Value = "Passed"
                            End If

                        Loop
                        myconn.Close()
                        Dim o As Integer = GradeDataGridView.Rows.Add
                        GradeDataGridView.Rows.Item(o).Cells(0).Value = ""
                        GradeDataGridView.Rows.Item(o).Cells(1).Value = "                                                                              SUBTOTAL"
                        GradeDataGridView.Rows.Item(o).Cells(2).Value = CourseSubTotal.ToString
                        GradeDataGridView.Rows.Item(o).Cells(3).Value = ""
                        GradeDataGridView.Rows.Item(o).Cells(4).Value = ""
                        CourseSubTotal = 0
                    Next
                Next
            ElseIf YearLevelComboBox.SelectedIndex > 0 And SemesterComboBox.SelectedIndex = 0 Then
                SemesterComboBox.Enabled = True
                Dim p As Integer = GradeDataGridView.Rows.Add
                GradeDataGridView.Rows.Item(p).Cells(0).Value = ""
                GradeDataGridView.Rows.Item(p).Cells(1).Value = "                                      " & YearLevelComboBox.Text & " Year"
                GradeDataGridView.Rows.Item(p).Cells(2).Value = ""
                GradeDataGridView.Rows.Item(p).Cells(3).Value = ""
                GradeDataGridView.Rows.Item(p).Cells(4).Value = ""
                For i = 0 To 2

                    Dim g As Integer = GradeDataGridView.Rows.Add
                    GradeDataGridView.Rows.Item(g).Cells(0).Value = ""
                    GradeDataGridView.Rows.Item(g).Cells(1).Value = "                                      SEMESTER " & (i + 1).ToString
                    GradeDataGridView.Rows.Item(g).Cells(2).Value = ""
                    GradeDataGridView.Rows.Item(g).Cells(3).Value = ""
                    GradeDataGridView.Rows.Item(g).Cells(4).Value = ""
                    SQLString = "SELECT StudentGrade.courseid As courseid,coursecode,coursename,coursehr,grade,yearlevel,semester " & "FROM StudentGrade,StudentCourse WHERE StudentGrade.courseid=StudentCourse.courseid AND StudentID='" & StudNo & "' AND yearlevel='" & YearLevelComboBox.SelectedIndex & "' AND semester=" & (i + 1).ToString & ""
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read
                        CourseId.Add(CInt(myreader("courseid").ToString))
                        CourseSubTotal = CourseSubTotal + CInt(myreader("coursehr").ToString)
                        Dim n As Integer = GradeDataGridView.Rows.Add
                        GradeDataGridView.Rows.Item(n).Cells(0).Value = myreader("coursecode").ToString
                        GradeDataGridView.Rows.Item(n).Cells(1).Value = myreader("coursename").ToString
                        GradeDataGridView.Rows.Item(n).Cells(2).Value = myreader("coursehr").ToString
                        GradeDataGridView.Rows.Item(n).Cells(3).Value = myreader("grade").ToString


                        If CDec(myreader("grade").ToString) = 0 Then
                            GradeDataGridView.Rows.Item(n).Cells(4).Value = "N/A"
                        ElseIf CDec(myreader("grade").ToString) > 3 Then
                            GradeDataGridView.Rows.Item(n).Cells(4).Value = "Failed"
                            GradeDataGridView.Rows.Item(n).DefaultCellStyle.ForeColor = Color.Red
                        Else
                            GradeDataGridView.Rows.Item(n).Cells(4).Value = "Passed"
                        End If

                    Loop
                    myconn.Close()
                    Dim o As Integer = GradeDataGridView.Rows.Add
                    GradeDataGridView.Rows.Item(o).Cells(0).Value = ""
                    GradeDataGridView.Rows.Item(o).Cells(1).Value = "                                                                              SUBTOTAL"
                    GradeDataGridView.Rows.Item(o).Cells(2).Value = CourseSubTotal.ToString
                    GradeDataGridView.Rows.Item(o).Cells(3).Value = ""
                    GradeDataGridView.Rows.Item(o).Cells(4).Value = ""
                    CourseSubTotal = 0
                Next
            Else
                SQLString = "SELECT StudentGrade.courseid As courseid,coursecode,coursename,coursehr,grade,yearlevel,semester " & "FROM StudentGrade,StudentCourse WHERE StudentGrade.courseid=StudentCourse.courseid AND StudentID='" & StudNo & "' AND yearlevel='" & YearLevelComboBox.SelectedIndex & "'  AND semester='" & SemesterComboBox.SelectedIndex & "'"
                SemesterComboBox.Enabled = True
                Try
                    myconn.ConnectionString = CONNECTION_STRING
                    myconn.Open()
                    mycommand.Connection = myconn
                    mycommand.CommandText = SQLString
                    myreader = mycommand.ExecuteReader
                    Do While myreader.Read

                        CourseId.Add(CInt(myreader("courseid").ToString))
                        YearLevel = CInt(myreader("yearlevel").ToString)
                        Semester = CInt(myreader("semester").ToString)
                        CourseSubTotal = CourseSubTotal + CInt(myreader("coursehr").ToString)

                        If GradeDataGridView.RowCount = 0 Then
                            Dim r As Integer = GradeDataGridView.Rows.Add
                            GradeDataGridView.Rows.Item(r).Cells(0).Value = ""
                            GradeDataGridView.Rows.Item(r).Cells(1).Value = "                                      YEAR " & YearLevel.ToString
                            GradeDataGridView.Rows.Item(r).Cells(2).Value = ""
                            GradeDataGridView.Rows.Item(r).Cells(3).Value = ""
                            GradeDataGridView.Rows.Item(r).Cells(4).Value = ""
                            Dim p As Integer = GradeDataGridView.Rows.Add
                            GradeDataGridView.Rows.Item(p).Cells(0).Value = ""
                            GradeDataGridView.Rows.Item(p).Cells(1).Value = "                                      SEMESTER " & Semester.ToString
                            GradeDataGridView.Rows.Item(p).Cells(2).Value = ""
                            GradeDataGridView.Rows.Item(p).Cells(3).Value = ""
                            GradeDataGridView.Rows.Item(p).Cells(4).Value = ""
                        End If

                        Dim n As Integer = GradeDataGridView.Rows.Add
                        GradeDataGridView.Rows.Item(n).Cells(0).Value = myreader("coursecode").ToString
                        GradeDataGridView.Rows.Item(n).Cells(1).Value = myreader("coursename").ToString
                        GradeDataGridView.Rows.Item(n).Cells(2).Value = myreader("coursehr").ToString
                        GradeDataGridView.Rows.Item(n).Cells(3).Value = myreader("grade").ToString

                        If CDec(myreader("grade").ToString) = 0 Then
                            GradeDataGridView.Rows.Item(n).Cells(4).Value = "N/A"
                        ElseIf CDec(myreader("grade").ToString) > 3 Then
                            GradeDataGridView.Rows.Item(n).Cells(4).Value = "Failed"
                            GradeDataGridView.Rows.Item(n).DefaultCellStyle.ForeColor = Color.Red
                        Else
                            GradeDataGridView.Rows.Item(n).Cells(4).Value = "Passed"
                        End If
                    Loop
                    myconn.Close()
                    Dim q As Integer = GradeDataGridView.Rows.Add
                    GradeDataGridView.Rows.Item(q).Cells(0).Value = ""
                    GradeDataGridView.Rows.Item(q).Cells(1).Value = "                                                                              SUBTOTAL"
                    GradeDataGridView.Rows.Item(q).Cells(2).Value = CourseSubTotal.ToString
                    GradeDataGridView.Rows.Item(q).Cells(3).Value = ""
                    GradeDataGridView.Rows.Item(q).Cells(4).Value = ""
                Catch a As Exception
                    MessageBox.Show("No records found." & a.Message, "No Records.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub

    Private Sub SearchListBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchListBox.Click
        StudNo = ""
        For a = 0 To StudNoList.Count - 1
            If SearchListBox.SelectedIndex = a Then
                StudNo = StudNoList.Item(a).ToString()
                SearchTextBox.Text = SearchListBox.SelectedItem.ToString
            End If
        Next
        SearchListBox.Visible = False
    End Sub

    Dim firstgrade As Decimal
    Dim CourseIDInt As Integer
    Private Sub GradeDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GradeDataGridView.CellEndEdit
        Dim y As Integer = GradeDataGridView.CurrentCellAddress.Y
        Dim x As Integer = GradeDataGridView.CurrentCellAddress.X
        If x = 3 Then
            Dim grading As String = ""
            Try
                SQLString = "SELECT  courseid " & "FROM StudentCourse WHERE coursecode='" & GradeDataGridView.Rows.Item(y).Cells(0).Value.ToString & "'"
                SemesterComboBox.Enabled = True

                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    CourseIDInt = CInt(myreader("courseid").ToString)
                Loop
                myconn.Close()
                Dim secondgrade As Decimal = CDec(GradeDataGridView.Rows.Item(y).Cells(3).Value.ToString)
                SQLString = " UPDATE StudentGrade SET grade='" & GradeDataGridView.Rows.Item(y).Cells(3).Value.ToString & "'" & _
                                " WHERE StudentID='" & StudNo & "'" & _
                                " AND courseid='" & CourseIDInt & "'"
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                mycommand.ExecuteNonQuery()
                myconn.Close()
                GradeDataGridView.Rows.Item(y).DefaultCellStyle.ForeColor = Color.Black
                If secondgrade = 0 Then
                    GradeDataGridView.Rows.Item(y).Cells(4).Value = "N/A"
                ElseIf secondgrade > 5 Then
                    MessageBox.Show("Input must be within 1-5 only.", "Invalid Input.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    GradeDataGridView.Rows.Item(y).Cells(3).Value = firstgrade.ToString

                ElseIf secondgrade <= 3 Then
                    GradeDataGridView.Rows.Item(y).Cells(4).Value = "Passed"
                Else
                    GradeDataGridView.Rows.Item(y).DefaultCellStyle.ForeColor = Color.Red
                    GradeDataGridView.Rows.Item(y).Cells(4).Value = "Failed"
                End If
            Catch a As Exception
                MsgBox(a.Message)
                MessageBox.Show("Only numbers are allowed to be entered within this field.", "Invalid Input.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                GradeDataGridView.Rows.Item(y).Cells(3).Value = firstgrade.ToString
                'Grades()
            End Try
        End If
    End Sub

    'Reminder: Upon changing the grade in specific row, get the cod in RASEnrollment in grading, the remark field will change into "Passed" or "Failed"
    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'Dim dt As New DataSet
        'SQLString = "Select * from tblStudents,tblStudentYear,tblYearLevel,tblStudentYearLevel,tblStudentSections,tblYearLevelSections" & _
        ' " WHERE schoolyearid='" & SYID.Item(SYComboBox.SelectedIndex) & "'" & _
        'myadapter.SelectCommand = New SqlCommand(SQLString, myconn)
        'myadapter.Fill(dt)
        'Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rptDoc = New CrystalReport1
        ' Dim user As String = "root"
        'Dim pwd As String = ""

        'rptDoc.SetDatabaseLogon(user, pwd)
        ' rptDoc.SetParameterValue("p_1", CrystalReport.CrystalReportViewer1)
        'rptDoc.Load(".\CrystalReport1.rpt")
        'rptDoc.SetDataSource(dt.Tables(0))
        'CrystalReport.CrystalReportViewer1.RefreshReport()
        'CrystalReport.CrystalReportViewer1.ReportSource = rptDoc

        'Dim StudentSelection As String = ""
        'StudentSelection = StudentSelection & " {tblYearLevel.yearlevelname}='" & YGPListView.Items(i).SubItems(1).Text & "'"

        'CrystalReport.CrystalReportViewer1.SelectionFormula = StudentSelection
        'CrystalReport.ShowDialog()
        'CrystalReport.Dispose()
        Try
            Dim acsds As New DataSet
            'con.ConnectionString = "server=JHONARD-PC\SQLEXPRESS; database=Student; trusted_connection=true"


            mycommand = New SqlCommand("select * from StudentInfo where StudentID = '" & StudNo & "'", myconn)

            myadapter.SelectCommand = mycommand
            myconn.Close()

            myadapter.Fill(acsds)
            Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'Dim user As String = "(local)"
            'Dim pwd As String = ""
            ' rptdocument.SetDatabaseLogon(user, pwd)
            'crystalReport.Load(Server.MapPath("CrystalReport.rpt"));
            rptdocument.Load(Application.StartupPath & "\CrystalReport1.rpt")
            rptdocument.SetDataSource(acsds.Tables(0))
            ' rptdocument.SetParameterValue("filter", "Filtered by: " & ComboBox1.Text)
            Form1.CrystalReportViewer1.Visible = True
            Form1.CrystalReportViewer1.ShowRefreshButton = False
            Form1.CrystalReportViewer1.ShowCloseButton = False
            Form1.CrystalReportViewer1.ShowGroupTreeButton = False
            Form1.CrystalReportViewer1.ReportSource = rptdocument
            Form1.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        NameTextBox.Clear()
        YearLevelComboBox.SelectedIndex = -1
        YearLevelComboBox.Enabled = False
        SemesterComboBox.Enabled = False
        SearchButton.Enabled = True
        SearchTextBox.Enabled = True
        GradeDataGridView.Rows.Clear()
        PrintButton.Enabled = False
    End Sub

    Private Sub GradeDataGridView_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles GradeDataGridView.CellBeginEdit
        Dim y As Integer = GradeDataGridView.CurrentCellAddress.Y
        Dim x As Integer = GradeDataGridView.CurrentCellAddress.X
        Try
            If GradeDataGridView.Rows.Item(y).Cells(0).Value.ToString = "" Then
                MessageBox.Show("Not Allowed to input in this section.", "Invalid Section.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                AYTextBox.Focus()
                'GradeDataGridView.Rows(y).Cells(0).Selected = True
            ElseIf x = 3 Then
                firstgrade = CDec(GradeDataGridView.Rows.Item(y).Cells(3).Value.ToString)
            End If
        Catch
            'GradeDataGridView.Rows.Item(y).ReadOnly = True
        End Try
    End Sub

    Private Sub YearLevelComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearLevelComboBox.SelectedIndexChanged
        SemesterComboBox.SelectedIndex = -1
        If YearLevelComboBox.SelectedIndex > 0 Then
            SemesterComboBox.SelectedIndex = 0
            SemesterComboBox.Enabled = True
        ElseIf YearLevelComboBox.SelectedIndex = 0 Then
            SemesterComboBox.SelectedIndex = 0
            SemesterComboBox.Enabled = False
        End If
        AYStarted = AYStarted + YearLevelComboBox.SelectedIndex + 1
        AYTextBox.Text = AYStarted & "-" & (AYStarted + 1)
    End Sub

    Private Sub SemesterComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterComboBox.SelectedIndexChanged
        Grades()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PrintButton.Enabled = False
    End Sub

    Private Sub GradeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GradeDataGridView.CellContentClick

    End Sub

    Private Sub PrintButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim rptDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rptDoc = New CrystalReport11
        'Dim dt As New DataSet
        'Dim user As String = "root"
        'Dim pwd As String = ""

        'rptDoc.SetDatabaseLogon(user, pwd)
        'rptDoc.SetParameterValue("p_1", CrystalReport11.CrystalReportViewer1)
        'rptDoc.Load(".\Copy_of_CrystalReport1.rpt")
        'rptDoc.SetDataSource(dt.Tables(0))
        'Copy_of_CrystalReport1.CrystalReportViewer1.RefreshReport()
        'CrystalReport11.CrystalReportViewer1.ReportSource = rptDoc
        ' Dim xlApp As Excel.Application
        ' Dim xlWorkBook As Excel.Workbook
        'Dim xlWorkSheet As Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value

        'Dim i As Int16, j As Int16

        'xlApp = New Excel.Application()
        'xlWorkBook = xlApp.Workbooks.Add(misValue)
        'xlWorkSheet = CType(xlWorkBook.Sheets("sheet1"), Excel.Worksheet)


        'For i = 0 To CShort(GradeDataGridView.RowCount - 2)
        'For j = 0 To CShort(GradeDataGridView.ColumnCount - 1)
        'xlWorkSheet.Cells(i + 1, j + 1) = GradeDataGridView(j, i).Value.ToString()
        'Next
        'Next

        'xlWorkBook.SaveAs("c:\a.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
        'Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        'xlWorkBook.Close(True, misValue, misValue)
        'xlApp.Quit()

        'releaseObject(xlWorkSheet)
        'releaseObject(xlWorkBook)
        'releaseObject(xlApp)

        'MessageBox.Show("Over")



    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class
