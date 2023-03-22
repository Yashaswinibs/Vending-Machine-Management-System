Imports System.Data.SQLite

Public Class RegisterForm
    Private conn As SQLiteConnection = MainForm.conn
    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Dim username As String = UsernameTB.Text
        Dim password As String = PasswordTB.Text
        Dim repeatedPassword As String = ConfirmPasswordTB.Text

        If password <> repeatedPassword Then
            MessageBox.Show("Passwords Do Not Match")
        Else
            conn.Open()
            MessageBox.Show(Me.conn.State = ConnectionState.Open)
            Dim SqlQuery As String = $"INSERT INTO Users VALUES ('{username}', '{password}');"
            Dim Cmd As New SQLiteCommand(SqlQuery, conn)
            Dim RowsAffected As Integer = Cmd.ExecuteNonQuery()
            If RowsAffected = 1 Then
                MessageBox.Show("Account Created Successfully")
            End If
            conn.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(conn.State = ConnectionState.Open)
    End Sub

    Private Sub backLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backLink.LinkClicked
        Me.Hide()
        MainForm.Show()
    End Sub
End Class