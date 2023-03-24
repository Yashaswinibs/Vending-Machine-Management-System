Imports System.Data.SQLite

Public Class HomeForm
    Private conn As SQLiteConnection = MainForm.conn
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim VendingMachineIDs As New List(Of String)
        Dim Locations As New List(Of String)
        Dim VMStatus As New List(Of Integer)
        ' Dim InteractBtns() As Button
        ' Dim LocationBtns() As Button
        ' InteractBtns = {VM1InteractBtn, VM1InteractBtn, VM3InteractBtn, VM4InteractBtn, VM5InteractBtn, VM6InteractBtn}
        ' LocationBtns = {VM1Location, VM2Location, VM3Location}

        Dim VendingMachines = Me.Controls.OfType(Of GroupBox).ToList()
        VendingMachines = VendingMachines.OrderBy(Function(c) c.Name).ToList() 'Sort by name




        conn.Open()
        Dim SqlQuery As String = "SELECT * FROM VENDING_MACHINES;"
        Dim RowCountQuery As String = "SELECT COUNT(*) FROM VENDING_MACHINES;"

        ' Get number of Vending Machines
        Dim RCCmd = New SQLiteCommand(RowCountQuery, conn)
        Dim RowCount = CInt(RCCmd.ExecuteScalar())
        MessageBox.Show(RowCount)

        Dim Cmd As New SQLiteCommand(SqlQuery, conn)
        Dim reader = Cmd.ExecuteReader()
        While reader.Read()
            ' VendingMachineIDs.Add(reader("VMID"))
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

End Class