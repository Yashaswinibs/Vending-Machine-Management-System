﻿Imports System.Data.SQLite
Imports System.Threading

Public Class OrderSummaryForm
    Private conn As SQLiteConnection = MainForm.conn
    Public OrderSummary As New Dictionary(Of Product, Integer)
    Public OrderTotal As Integer
    Private Sub OrderSummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateOrderSummary()
    End Sub


    Private Sub backBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backBtn.LinkClicked
        Me.Hide()
        ProductsForm.Show()
    End Sub


    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        updateOrderSummary()
    End Sub


    Private Sub updateOrderSummary()
        OrderSummary.Clear()
        DGV.Rows.Clear()
        For Each product As Product In ProductsForm.Cart
            If Not OrderSummary.ContainsKey(product) Then
                OrderSummary.Add(product, 1)
            Else
                Dim ExistingQty As Integer = OrderSummary.Item(product)
                OrderSummary.Item(product) = ExistingQty + 1
            End If
        Next

        ' Show products in DataGridView
        For Each kvp As KeyValuePair(Of Product, Integer) In OrderSummary
            Dim Index As Integer = DGV.Rows.Add()
            Dim ProdName As String = kvp.Key.ProdName
            Dim ProdPrice As Integer = kvp.Key.ProdPrice
            DGV.Rows(Index).Cells("ProdName").Value = ProdName
            DGV.Rows(Index).Cells("ProdQty").Value = kvp.Value
            DGV.Rows(Index).Cells("ProdPrice").Value = ProdPrice
            DGV.Rows(Index).Cells("Total").Value = kvp.Value * ProdPrice
        Next
    End Sub



    Private Sub CheckoutBtn_Click(sender As Object, e As EventArgs) Handles CheckoutBtn.Click
        For rowIndex As Integer = 0 To DGV.RowCount - 2
            OrderTotal += CInt(DGV.Rows(rowIndex).Cells("Total").Value)
        Next
        Dim confirmMsg = MessageBox.Show($"Confirm Order of ₹{OrderTotal}", "Confirm Order", MessageBoxButtons.OKCancel)
        If confirmMsg = 1 Then
            ConfirmCheckout()
        End If
    End Sub


    Private Sub ConfirmCheckout()
        While Not orderProgress.Value = 100
            Dim randInt = New Random().Next(1, 101)
            If randInt > 95 Then
                orderProgress.Value = 100
            Else
                orderProgress.Value += 1
            End If
            Thread.Sleep(100)
        End While
        UpdateDB()
        MessageBox.Show("Vend Successfull 🎉", "VendIT - Vending Machine Management System")
        Me.Hide()
        HomeForm.Show()
    End Sub


    Private Sub UpdateDB()
        conn.Open()
        ' Remove products from inventory
        For Each product As Product In ProductsForm.Cart
            Dim SqlQuery As String = $"UPDATE PRODUCTS_AVAILABLE SET Quantity = Quantity - 1 WHERE VMID='{ProductsForm.VendingMachineID}' AND ProductID='{product.ProdID}'"
            Dim Cmd As New SQLiteCommand(SqlQuery, conn)
            Dim RowsAffected = Cmd.ExecuteNonQuery()
            'Thread.Sleep(100)
            If Not RowsAffected = 1 Then
                MessageBox.Show($"Something Went Wrong During The Checkout Of {product.ProdName} ({product.ProdID})")
            End If
        Next

        ' Add transaction record to database
        For Each product As Product In OrderSummary.Keys
            Dim ProdId As String = product.ProdID
            Dim VMID As String = ProductsForm.VendingMachineID
            Dim ProdQty As Integer = OrderSummary.Item(product)
            Dim PaymentMethod As String = ProductsForm.PaymentsMethodCB.Text
            Dim SqlQuery As String = $"INSERT INTO PURCHASES (VMID, ProductID, ProductQty, PaymentMethod) VALUES ('{VMID}', '{ProdId}', {ProdQty}, '{PaymentMethod}')"
            Dim Cmd As New SQLiteCommand(SqlQuery, conn)
            Dim RowsAffected = Cmd.ExecuteNonQuery()
            If Not RowsAffected = 1 Then
                MessageBox.Show($"Something Went Wrong During The Checkout Of {product.ProdName} ({product.ProdID})")
            End If
        Next

        ' Update user tokens
        If ProductsForm.PaymentsMethodCB.Text = "Tokens" Then
            Dim username As String = LoginForm.loginInfo.Username
            Dim TokensQuery As String = $"UPDATE users SET Tokens = Tokens - {OrderTotal} WHERE Username = '{username}';"
            Dim TokensCmd As New SQLiteCommand(TokensQuery, conn)
            TokensCmd.ExecuteNonQuery() ' Won't check for rows affected
            LoginForm.loginInfo.Tokens -= OrderTotal ' Update token info which is stored in LoginForm
        End If
        conn.Close()
    End Sub

End Class