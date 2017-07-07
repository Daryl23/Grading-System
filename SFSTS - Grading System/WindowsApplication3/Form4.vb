Option Strict On
Imports System.Data.SqlClient
Public Class Form4
    Const DATA_SOURCE_STRING As String = "."
    Const INITIAL_CATALOG As String = "Student"
    Const CONNECTION_STRING As String = "server=.\SQLEXPRESS;database=Student;trusted_connection=true"
    Private myconn As New SqlConnection
    Private mycommand As New SqlCommand
    Private myreader As SqlDataReader
    Dim myadapter As New SqlDataAdapter
    Dim SQLString As String
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Form3.Form4AddEdit = 1 Then
            YearLevelComboBox.Enabled = True
            SemesterComboBox.Enabled = True
            Label4.Text = ">>>Adding Course..."
            YearLevelComboBox.SelectedIndex = 0
            SemesterComboBox.SelectedIndex = 0
            TextBox1.Enabled = True
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        Else
            YearLevelComboBox.Enabled = False
            SemesterComboBox.Enabled = False
            Label4.Text = ">>>Editing Course..."
            SQLString = "SELECT * from StudentCourse WHERE courseid='" & Form3.CourseId(Form3.ProgramSelectedId) & "'"
            Try
                myconn.ConnectionString = CONNECTION_STRING
                myconn.Open()
                mycommand.Connection = myconn
                mycommand.CommandText = SQLString
                myreader = mycommand.ExecuteReader
                Do While myreader.Read
                    YearLevelComboBox.SelectedIndex = CInt(myreader("yearlevel").ToString) - 1
                    SemesterComboBox.Text = myreader("semester").ToString
                    TextBox1.Text = myreader("coursecode").ToString
                    TextBox2.Text = myreader("coursename").ToString
                    TextBox3.Text = myreader("coursehr").ToString
                Loop
                myconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                myconn.Close()
            End Try
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If YearLevelComboBox.Text = "" Or SemesterComboBox.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Please fill in the required fields.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim Hr As Integer = CInt(TextBox3.Text)
                If Form3.Form4AddEdit = 1 Then

                    SQLString = "insert into StudentCourse " & _
                                            "VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "', " & Hr & ", " & YearLevelComboBox.SelectedIndex + 1 & ", " & SemesterComboBox.Text & ")"
                    Try
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()
                        Form3.Course()
                        MessageBox.Show("Course successfully added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        myconn.Close()
                    End Try
                Else
                    Try
                        SQLString = " UPDATE StudentCourse" & " SET  coursename='" & TextBox2.Text & "' WHERE courseid='" & Form3.CourseId(Form3.ProgramSelectedId) & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()

                        SQLString = " UPDATE StudentCourse" & " SET  coursehr='" & Hr & "' WHERE courseid='" & Form3.CourseId(Form3.ProgramSelectedId) & "'"
                        myconn.ConnectionString = CONNECTION_STRING
                        myconn.Open()
                        mycommand.Connection = myconn
                        mycommand.CommandText = SQLString
                        mycommand.ExecuteNonQuery()
                        myconn.Close()


                        Form3.Course()
                        MessageBox.Show("Course successfully updated.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        myconn.Close()
                    End Try
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class