Imports System.Data.SQLite

Public Class LoginForm
    Private conn As SQLiteConnection = MainForm.conn
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim username = UsernameTB.Text
        Dim password = PasswordTB.Text
        conn.Open()
        Dim SqlQuery As String = $"Select * From USERS WHERE Username='{username}' AND Password='{password}' LIMIT 1;"
        Dim Cmd As New SQLiteCommand(SqlQuery, conn)
        Dim reader As SQLiteDataReader = Cmd.ExecuteReader()

        If reader.Read() Then
            If reader("Username") = username And reader("password") = password Then
                MessageBox.Show("Login Successful")
                ClearInputs()
                conn.Close() ' Don't forget to close the connection on a successful login :)
                Me.Hide()
                HomeForm.Show()
            End If
        Else
            MessageBox.Show("Login Failed")
            ClearInputs()
        End If
        conn.Close()
    End Sub


    Private Sub ClearInputs()
        UsernameTB.Text = ""
        PasswordTB.Text = ""
    End Sub

    Private Sub backLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backLink.LinkClicked
        Me.Hide()
        MainForm.Show()
    End Sub
End Class