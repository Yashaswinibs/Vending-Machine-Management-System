Imports System.Data.SQLite

Public Class ProductsForm
    Private conn As SQLiteConnection = MainForm.conn
    Public DBProducts As New List(Of ProductBP) ' Products in the database
    Dim Products As New List(Of Product) ' Products in the form
    Public Cart As New List(Of ProductBP)

    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AvlTokensLbl.Text = LoginForm.loginInfo.Tokens
        Products = GetProductList()

        conn.Open()
        Dim SqlQuery As String = "SELECT * FROM PRODUCTS;"
        Dim Cmd As New SQLiteCommand(SqlQuery, conn)
        Dim reader = Cmd.ExecuteReader()
        While reader.Read()
            DBProducts.Add(New ProductBP(reader("ProductName"), reader("ProductPrice")))
        End While
        conn.Close()

        Product1.ProdImg.Image = My.Resources.laysClassic
        Product2.ProdImg.Image = My.Resources.kitkat
        Product3.ProdImg.Image = My.Resources.cokeZero
        Product4.ProdImg.Image = My.Resources.mirinda
        Product5.ProdImg.Image = My.Resources.fantaFamily
        Product6.ProdImg.Image = My.Resources.pringles
        Product7.ProdImg.Image = My.Resources.toblerone

        For i = 0 To DBProducts.Count - 1
            Products(i).prodLbl.Text = DBProducts(i).ProdName
            Products(i).Price = DBProducts(i).ProdPrice
        Next
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
End Class