Imports System.Data.SQLite
Imports System.IO

Public Class Form1
    Dim path As String = Directory.GetCurrentDirectory()
    Dim dbPath As String = IO.Path.Combine(path, "..\..\..\database.db")
    Dim connString As String = $"Data Source={dbPath}"
    Dim conn As New SQLiteConnection(connString)

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Try
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT firstName FROM Users;", conn)
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()

            While reader.Read()
                MessageBox.Show(reader("firstName"), "User Names")
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            conn.Close()
        End Try

    End Sub
End Class