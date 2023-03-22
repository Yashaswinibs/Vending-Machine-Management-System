Imports System.Data.SQLite

Public Class LoginForm
    Private conn As SQLiteConnection = MainForm.conn
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

    End Sub

    Private Sub backLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backLink.LinkClicked
        Me.Hide()
        MainForm.Show()
    End Sub
End Class