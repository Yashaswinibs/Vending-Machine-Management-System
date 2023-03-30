Public Class Product
    Public ProdPrice As Integer = 0
    Public ProdName As String = ""
    Public ProdID As String = ""
    Public SelectedQty As Integer = 0
    Public MaxQty As Integer


    ' Public Sub New(Name As String, Price As Integer, ID As String)
    'InitializeComponent()
    ' ProdName = Name
    '  ProdPrice = Price
    '   ProdID = ID
    'End Sub


    Private Sub Product_Paint(sender As Object, e As EventArgs) Handles MyBase.Paint
        prodLbl.Text = ProdName
    End Sub


    Public Sub AddQtyBtn_Click(sender As Object, e As EventArgs) Handles AddQtyBtn.Click
        SelectedQty += 1
        UpdateSelectedLblQty()
        ProductsForm.CartValueLbl.Text = CInt(ProductsForm.CartValueLbl.Text) + ProdPrice
        ProductsForm.Cart.Add(Me)
    End Sub


    Private Sub RemQtyBtn_Click(sender As Object, e As EventArgs) Handles RemQtyBtn.Click
        If SelectedQty > 0 Then
            SelectedQty -= 1
            UpdateSelectedLblQty()
            ProductsForm.CartValueLbl.Text = CInt(ProductsForm.CartValueLbl.Text) - ProdPrice
            ProductsForm.Cart.Remove(Me)
        End If
    End Sub


    Public Sub UpdateSelectedLblQty()
        If SelectedQty = 0 Then
            SelectedQtyLbl.Text = ""
        Else
            SelectedQtyLbl.Text = $"x {CStr(SelectedQty)}"
        End If
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Not isAvailable Then
        'prodLbl.Text = "Out Of Stock"
        'End If
    End Sub
End Class
