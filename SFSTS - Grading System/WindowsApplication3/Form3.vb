Option Strict On
Imports System.Data.SqlClient
Public Class Form3
    Const DATA_SOURCE_STRING As String = "."
    Const INITIAL_CATALOG As String = "Student"
    Const CONNECTION_STRING As String = "server=.\SQLEXPRESS;database=Student;trusted_connection=true"
    Private myconn As New SqlConnection
    Private mycommand As New SqlCommand
    Private myreader As SqlDataReader
    Dim myadapter As New SqlDataAdapter
    Dim SQLString As String
    Public CourseId As New List(Of String)
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        YearLevelComboBox.SelectedIndex = 0
        SemesterComboBox.SelectedIndex = 0
    End Sub
    Public Sub Course()
        ProgramCheckBox.Checked = False
        DeleteProgramButton.Enabled = False
        EditProgramButton.Enabled = False
        Dim n As Integer = 0
        ProgramListView.Items.Clear()
        CourseId.Clear()

        If YearLevelComboBox.SelectedIndex = 0 And SemesterComboBox.SelectedIndex = 0 Then
            SQLString = "SELECT * from StudentCourse"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    n = n + 1
                    ProgramListView.Items.Add("")
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(n.ToString)
                    CourseId.Add(myreader("courseid").ToString)
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(myreader("coursecode").ToString)
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(myreader("coursename").ToString)
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(myreader("coursehr").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                myconn.Close()
            End Try
        ElseIf YearLevelComboBox.SelectedIndex > 0 And SemesterComboBox.SelectedIndex = 0 Then
            SQLString = "SELECT * from StudentCourse WHERE yearlevel='" & YearLevelComboBox.SelectedIndex & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    n = n + 1
                    ProgramListView.Items.Add("")
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(n.ToString)
                    CourseId.Add(myreader("courseid").ToString)
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(myreader("coursecode").ToString)
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(myreader("coursename").ToString)
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(myreader("coursehr").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                myconn.Close()
            End Try
        Else
            SQLString = "SELECT * from StudentCourse WHERE yearlevel='" & YearLevelComboBox.SelectedIndex & "'  AND semester='" & SemesterComboBox.SelectedIndex & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    n = n + 1
                    ProgramListView.Items.Add("")
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(n.ToString)
                    CourseId.Add(myreader("courseid").ToString)
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(myreader("coursecode").ToString)
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(myreader("coursename").ToString)
                    ProgramListView.Items(ProgramListView.Items.Count - 1).SubItems.Add(myreader("coursehr").ToString)
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                myconn.Close()
            End Try
        End If
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
    End Sub

    Private Sub SemesterComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SemesterComboBox.SelectedIndexChanged
        Course()
    End Sub

    Private Sub ProgramCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramCheckBox.CheckedChanged
        If ProgramCheckBox.Checked = True Then
            For i = 0 To ProgramListView.Items.Count - 1
                ProgramListView.Items(i).Checked = True
            Next
        Else
            For i = 0 To ProgramListView.Items.Count - 1
                ProgramListView.Items(i).Checked = False
            Next
        End If
    End Sub
    Public ProgramSelectedId As Integer
    Private Sub DeleteProgramButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteProgramButton.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete selected course(s)? ", "Delete Program(s) Offered?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            For i = ProgramListView.Items.Count - 1 To 0 Step -1
                If ProgramListView.Items(i).Checked = True Then
                    Try
                        SQLString = "DELETE FROM StudentCourse WHERE courseid='" & CourseId.Item(i) & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                    Catch ex As Exception
                        MessageBox.Show("No records found." & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                End If
            Next

            Course()
            MessageBox.Show("Course has been deleted.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DeleteProgramButton.Enabled = False
        End If

    End Sub

    Public Form4AddEdit As Integer

    Private Sub AddProgramButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProgramButton.Click
        Form4AddEdit = 1
        Form4.ShowDialog()
    End Sub

    Private Sub EditProgramButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditProgramButton.Click
        Form4AddEdit = 2
        Form4.ShowDialog()
    End Sub

    Private Sub ProgramListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramListView.SelectedIndexChanged
        For a = 0 To ProgramListView.Items.Count - 1
            If ProgramListView.Items.Item(a).Selected = True Then

            End If
        Next

        For a = 0 To ProgramListView.Items.Count - 1
            If ProgramListView.Items.Item(a).Selected = True Then
                ProgramSelectedId = a
                EditProgramButton.Enabled = True
                Exit For
            Else
                EditProgramButton.Enabled = False
            End If
        Next
    End Sub
    Private Sub ProgramListView_ItemChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramListView.ItemChecked
        If ProgramListView.CheckedItems.Count > 0 Then
            DeleteProgramButton.Enabled = True
        Else
            DeleteProgramButton.Enabled = False
        End If
    End Sub
End Class