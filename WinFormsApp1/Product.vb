Public Class Product
    Public SelectedQty As Integer = 0
    Public isAvailable As Boolean = True
    Public Price As Integer
    Public SelectedLblQty As Label

    Private Sub AddQtyBtn_Click(sender As Object, e As EventArgs) Handles AddQtyBtn.Click
        SelectedQty += 1
        UpdateSelectedLblQty()
    End Sub

    Private Sub RemQtyBtn_Click(sender As Object, e As EventArgs) Handles RemQtyBtn.Click
        If SelectedQty > 0 Then
            SelectedQty -= 1
            UpdateSelectedLblQty()
        End If
    End Sub


    Private Sub UpdateSelectedLblQty()
        If SelectedQty = 0 Then
            SelectedQtyLbl.Text = ""
        Else
            SelectedQtyLbl.Text = $"x{CStr(SelectedQty)}"
        End If
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isAvailable Then
            prodLbl.Text = "Out Of Stock"
        End If

    End Sub
End Class
