Imports System.Data.SQLite

Public Class HomeForm
    Private conn As SQLiteConnection = MainForm.conn
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Locations As New List(Of String)
        Dim VMStatus As New List(Of Integer)
        Dim VendingMachines = Me.Controls.OfType(Of GroupBox).ToList()
        VendingMachines = VendingMachines.OrderBy(Function(c) c.Name).ToList() 'Sort by name

        conn.Open()
        Dim SqlQuery As String = "SELECT * FROM VENDING_MACHINES;"
        Dim Cmd As New SQLiteCommand(SqlQuery, conn)
        Dim reader = Cmd.ExecuteReader()
        While reader.Read()
            Locations.Add(reader("VMLocation"))
            VMStatus.Add(reader("Status"))
        End While
        conn.Close()

        For i = 0 To VendingMachines.Count - 1
            ChangeVMLocation(VendingMachines(i), Locations(i))
            If VMStatus(i) = 0 Then
                UpdateVMStatus(VendingMachines(i), i + 1, 0)
            End If
        Next
    End Sub


    Private Sub ChangeVMLocation(VM As GroupBox, loc As String)
        Dim buttons = VM.Controls.OfType(Of Button).ToList()
        For Each btn As Button In buttons
            If btn.Name.StartsWith("LocationVM") Then
                btn.Text = loc
                Exit For
            End If
        Next
    End Sub


    Private Sub UpdateVMStatus(VM As GroupBox, VMNum As Integer, status As Integer)
        Dim buttons = VM.Controls.OfType(Of Button).ToList()
        For Each btn As Button In buttons
            If btn.Name = $"InteractBtnVM{VMNum}" Then
                If status = 0 Then
                    btn.Enabled = False
                End If
                Exit For
            End If
        Next
    End Sub


    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        ClearInputsOnLogout()
        MessageBox.Show("Logging Out")
        Me.Hide()
        LoginForm.Show()
    End Sub


    Private Sub ClearInputsOnLogout()
        LoginForm.loginInfo.Username = ""
        LoginForm.loginInfo.Fullname = ""
        LoginForm.loginInfo.Tokens = 0
        ProductsForm.AvlTokensLbl.Text = "0"
        ProductsForm.CartValueLbl.Text = "0"
        ProductsForm.Cart.Clear()
        For Each product As Product In ProductsForm.GetProductList()
            product.SelectedQty = 0
            product.UpdateSelectedLblQty()
        Next
    End Sub


    Private Sub InteractBtnVM1_Click(sender As Object, e As EventArgs) Handles InteractBtnVM1.Click
        Me.Hide()
        ProductsForm.Show()
    End Sub



    Private Sub InteractBtnVM2_Click(sender As Object, e As EventArgs) Handles InteractBtnVM2.Click
        Me.Hide()
        ProductsForm.Show()
    End Sub

    Private Sub InteractBtnVM3_Click(sender As Object, e As EventArgs) Handles InteractBtnVM3.Click
        Me.Hide()
        ProductsForm.Show()
    End Sub

    Private Sub InteractBtnVM4_Click(sender As Object, e As EventArgs) Handles InteractBtnVM4.Click
        Me.Hide()
        ProductsForm.Show()
    End Sub

    Private Sub InteractBtnVM5_Click(sender As Object, e As EventArgs) Handles InteractBtnVM5.Click
        Me.Hide()
        ProductsForm.Show()
    End Sub

    Private Sub InteractBtnVM6_Click(sender As Object, e As EventArgs) Handles InteractBtnVM6.Click
        Me.Hide()
        ProductsForm.Show()
    End Sub
End Class