Imports System.Data.SQLite

Public Class TransactionsForm
    Dim conn As SQLiteConnection = MainForm.conn
    Public VMID As String
    Private Sub TransactionsForm_Paint(sender As Object, e As EventArgs) Handles MyBase.Paint
        TransactionsDGV.Rows.Clear()
        ' Don't update dgv if vmid is not set
        If Not String.IsNullOrEmpty(VMID) Then
            conn.Open()
            Dim SqlQuery As String = $"SELECT PRODUCTS.ProductName, PRODUCTS.ProductPrice, PURCHASES.ProductQty, PURCHASES.PaymentMethod, PURCHASES.PurchaseTime FROM PRODUCTS INNER JOIN PURCHASES ON PRODUCTS.ProductID = PURCHASES.ProductID WHERE PURCHASES.VMID = '{VMID}';"
            Dim Cmd As New SQLiteCommand(SqlQuery, conn)
            Dim reader = Cmd.ExecuteReader()
            While reader.Read()
                Dim index = TransactionsDGV.Rows.Add()
                TransactionsDGV.Rows(index).Cells("ProdName").Value = reader("ProductName")
                TransactionsDGV.Rows(index).Cells("ProdPrice").Value = reader("ProductPrice")
                TransactionsDGV.Rows(index).Cells("ProdQty").Value = reader("ProductQty")
                TransactionsDGV.Rows(index).Cells("PaymentMthd").Value = reader("PaymentMethod")
                TransactionsDGV.Rows(index).Cells("PurchaseTm").Value = reader("PurchaseTime")
            End While
            conn.Close()
        End If
    End Sub

    Private Sub backBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backBtn.LinkClicked
        Me.Hide()
        HomeForm.Show()
    End Sub
End Class