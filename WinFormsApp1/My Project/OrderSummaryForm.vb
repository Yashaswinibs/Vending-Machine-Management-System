Imports System.Data.SQLite

Public Class OrderSummaryForm
    Private conn As SQLiteConnection = MainForm.conn
    Public OrderSummary As Hashtable = New Hashtable()
    Public OrderTotal As Integer
    Private Sub OrderSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each product As ProductBP In ProductsForm.Cart
            If Not OrderSummary.Contains(product.ProdName) Then
                OrderSummary.Add(product.ProdName, 1)
            Else
                Dim ExistingQty As Integer = OrderSummary.Item(product.ProdName)
                OrderSummary.Item(product.ProdName) = ExistingQty + 1
            End If
        Next

        ' Show products in DataGridView
        For Each kvp As DictionaryEntry In OrderSummary
            Dim Index As Integer = DGV.Rows.Add()
            Dim ProdPrice As Integer = GetPrice(kvp.Key)
            DGV.Rows(Index).Cells("ProdName").Value = kvp.Key
            DGV.Rows(Index).Cells("ProdQty").Value = kvp.Value
            DGV.Rows(Index).Cells("ProdPrice").Value = ProdPrice
            DGV.Rows(Index).Cells("Total").Value = kvp.Value * ProdPrice
        Next
    End Sub



    Private Function GetPrice(Name As String) As Integer
        conn.Open()
        Dim SqlQuery As String = $"SELECT ProductPrice FROM PRODUCTS WHERE ProductName='{Name}'"
        Dim Cmd As New SQLiteCommand(SqlQuery, conn)
        Dim price = Cmd.ExecuteScalar()
        conn.Close()
        Return price
    End Function

    Private Sub backBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backBtn.LinkClicked
        Me.Hide()
        ProductsForm.Show()
    End Sub

    Private Sub CheckoutBtn_Click(sender As Object, e As EventArgs) Handles CheckoutBtn.Click
        For rowIndex As Integer = 0 To DGV.RowCount - 2
            OrderTotal += CInt(DGV.Rows(rowIndex).Cells("Total").Value)
        Next
        MessageBox.Show($"Confirm Order of {OrderTotal}")
    End Sub
End Class