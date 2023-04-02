Imports System.Data.SQLite

Public Class ProductsForm
    Private conn As SQLiteConnection = MainForm.conn
    Public VendingMachineID As String
    Public Cart As New List(Of Product)


    Private Sub ProductsForm_Paint(sender As Object, e As EventArgs) Handles MyBase.Paint
        AvlTokensLbl.Text = LoginForm.loginInfo.Tokens
        Dim ProductImages As New Dictionary(Of String, Image)
        ProductImages.Add("Cheetos Flamin Hot", My.Resources.cheetosFlaminHot)
        ProductImages.Add("Coke Zero (330 ml)", My.Resources.cokeZero)
        ProductImages.Add("Fanta Family Pack (PC of 4)", My.Resources.fantaFamily)
        ProductImages.Add("Kit-Kat Chocolate", My.Resources.kitkat)
        ProductImages.Add("Lays Classic", My.Resources.laysClassic)
        ProductImages.Add("Milk Carton (500 ml)", My.Resources.milkCarton)
        ProductImages.Add("Mirinda (330 ml)", My.Resources.mirinda)
        ProductImages.Add("Nescafe Cold Coffee", My.Resources.nescafeColdCoffee)
        ProductImages.Add("Pringles", My.Resources.pringles)
        ProductImages.Add("Red Bull", My.Resources.redBull)
        ProductImages.Add("Snickers (45g)", My.Resources.snickersBar)
        ProductImages.Add("Starbucks Espresso", My.Resources.starbucksEspresso)
        ProductImages.Add("Toblerone", My.Resources.toblerone)


        conn.Open()
        Dim SqlQuery As String = $"SELECT PRODUCTS_AVAILABLE.ProductID, PRODUCTS.ProductName, PRODUCTS.ProductPrice FROM PRODUCTS_AVAILABLE INNER JOIN PRODUCTS ON PRODUCTS.ProductID = PRODUCTS_AVAILABLE.ProductID WHERE PRODUCTS_AVAILABLE.VMID = '{VendingMachineID}';"
        Dim Cmd As New SQLiteCommand(SqlQuery, conn)
        Dim reader = Cmd.ExecuteReader()
        For Each product As Product In GetProductList()
            If reader.Read() Then
                product.ProdName = reader("ProductName")
                product.ProdID = reader("ProductID")
                product.ProdPrice = reader("ProductPrice")
                product.ProdImg.Image = ProductImages(product.ProdName)
            End If
        Next
        reader.Close()
        conn.Close()
    End Sub



    Private Sub CheckoutBtn_Click(sender As Object, e As EventArgs) Handles CheckoutBtn.Click
        If LoginForm.loginInfo.Tokens < CInt(CartValueLbl.Text) Then
            MessageBox.Show("You Don't Have Enough Tokens To Complete This Purchase")
        Else
            Me.Hide()
            OrderSummaryForm.Show()
        End If
    End Sub



    Private Sub backBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backBtn.LinkClicked
        Me.Hide()
        ClearInputsOnVMChange()
        HomeForm.Show()
    End Sub


    Public Function GetProductList() As List(Of Product)
        Dim productList As New List(Of Product)
        ' Loop through all controls on the form and Check if the control is a Product user control
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            If TypeOf ctrl Is Product Then
                productList.Add(ctrl)
            End If
        Next
        Return productList
    End Function



    Private Sub ClearInputsOnVMChange()
        ' Clear inputs when the user switches from one vending machine to another
        CartValueLbl.Text = "0"
        Cart.Clear()
        For Each product As Product In GetProductList()
            product.SelectedQty = 0
            product.UpdateSelectedLblQty()
        Next
    End Sub

End Class