Imports System.Data.SQLite

Public Class ProductsForm
    Private conn As SQLiteConnection = MainForm.conn
    Public DBProducts As New List(Of ProductBP) ' Products in the database
    Dim Products As New List(Of Product) ' Products in the form

    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AvlTokensLbl.Text = LoginForm.loginInfo.Tokens

        Products.Add(Product1)
        Products.Add(Product2)
        Products.Add(Product3)
        Products.Add(Product4)
        Products.Add(Product5)
        Products.Add(Product6)
        Products.Add(Product7)
        Products.Add(Product8)
        Products.Add(Product9)

        conn.Open()
        Dim SqlQuery As String = "SELECT * FROM PRODUCTS;"
        Dim Cmd As New SQLiteCommand(SqlQuery, conn)
        Dim reader = Cmd.ExecuteReader()
        While reader.Read()
            DBProducts.Add(New ProductBP(reader("ProductName"), CInt(reader("ProductPrice"))))
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
End Class