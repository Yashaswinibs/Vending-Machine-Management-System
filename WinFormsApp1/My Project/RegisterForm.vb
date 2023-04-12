Imports System.Data.SQLite

Public Class RegisterForm
    Private conn As SQLiteConnection = MainForm.conn
    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Dim fullName As String = FullNameTB.Text
        Dim username As String = UsernameTB.Text
        Dim password As String = PasswordTB.Text
        Dim repeatedPassword As String = ConfirmPasswordTB.Text
        Dim creditTokens As Integer = If(PromoOfferYes.Checked, 100, 0)

        If password <> repeatedPassword Then
            MessageBox.Show("Passwords Do Not Match")
            ClearInputs()
        Else
            Try
                conn.Open()
                Dim SqlQuery As String = $"INSERT INTO USERS VALUES ('{username}', '{password}', '{fullName}', {creditTokens});"
                Dim Cmd As New SQLiteCommand(SqlQuery, conn)
                Dim RowsAffected As Integer = Cmd.ExecuteNonQuery()
                If RowsAffected = 1 Then
                    MessageBox.Show("Account Created Successfully")
                    ClearInputs()
                End If
            Catch ex As SQLiteException
                MessageBox.Show("Username Already Exists! Account not created")
                ClearInputs()
            Finally
                conn.Close()
            End Try
        End If
    End Sub


    Private Sub ClearInputs()
        FullNameTB.Text = ""
        UsernameTB.Text = ""

        PasswordTB.Text = ""
        ConfirmPasswordTB.Text = ""
    End Sub


    Private Sub backLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backLink.LinkClicked
        ClearInputs()
        Me.Hide()
        MainForm.Show()
    End Sub
End Class