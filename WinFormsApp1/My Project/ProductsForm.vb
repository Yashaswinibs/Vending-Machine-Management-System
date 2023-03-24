Imports System.Data.SQLite

Public Class ProductsForm
    Private conn As SQLiteConnection = MainForm.conn
    Public DBProducts As New List(Of ProductBP) ' Products in the database
    Dim Products As New List(Of Product) ' Products in the form

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Products.Add(Product1)
        Products.Add(Product2)
        Products.Add(Product3)
        Products.Add(Product4)
        Products.Add(Product5)
        Products.Add(Product6)
        Products.Add(Product7)
        Products.Add(Product8)
        Products.Add(Product9)

        Product1.ProdImg.Image = My.Resources.lays_chips
        Product2.ProdImg.Image = My.Resources.kitkat_chocolate
        Product3.ProdImg.Image = My.Resources.coke_zero
        Product4.ProdImg.Image = My.Resources.mirinda_softdrink
        Product1.ProdImg.Image = My.Resources.fanta_family_pack
        Product1.ProdImg.Image = My.Resources.pringles_chips
        Product1.ProdImg.Image = My.Resources.toblerone_chocolate

        conn.Open()
        Dim SqlQuery As String = "SELECT * FROM PRODUCTS;"
        Dim Cmd As New SQLiteCommand(SqlQuery, conn)
        Dim reader = Cmd.ExecuteReader()
        While reader.Read()
            DBProducts.Add(New ProductBP(reader("ProductName"), reader("ProductPrice")))
        End While
        conn.Close()

        For i = 0 To DBProducts.Count - 1
            Products(i).prodLbl.Text = DBProducts(i).ProdName
            Products(i).Price = DBProducts(i).Price
        Next
    End Sub
End Class