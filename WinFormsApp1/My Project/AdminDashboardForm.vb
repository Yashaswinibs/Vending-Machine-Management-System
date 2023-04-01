Public Class AdminDashboardForm
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class