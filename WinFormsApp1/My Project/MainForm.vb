Imports System.Data.SQLite
Imports System.IO


Public Class MainForm

    Public Shared conn As SQLiteConnection
    Public Sub New()
        InitializeComponent()
        Dim path, dbPath, connString As String
        path = Directory.GetCurrentDirectory()
        dbPath = IO.Path.Combine(path, "..\..\..\database.db")
        connString = $"Data Source={dbPath}"
        conn = New SQLiteConnection(connString)
    End Sub

    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Me.Visible = False
        RegisterForm.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        conn.Open()
        MessageBox.Show(conn.State = ConnectionState.Open)
        conn.Close()

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Me.Visible = False
        LoginForm.Show()
    End Sub

End Class