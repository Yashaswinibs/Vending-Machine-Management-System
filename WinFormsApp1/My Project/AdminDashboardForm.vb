Imports System.Data.SQLite

Public Class AdminDashboardForm
    Dim conn As SQLiteConnection = MainForm.conn
    Private VMStatus As New Dictionary(Of String, Boolean)
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        MainForm.Show()
    End Sub



    Private Sub GetVMStatus()
        conn.Open()
        Dim SqlQuery As String = "SELECT * FROM VENDING_MACHINES;"
        Dim Cmd As New SQLiteCommand(SqlQuery, conn)
        Dim reader = Cmd.ExecuteReader()
        While reader.Read()
            Dim VMID As String = reader("VMID")
            Dim Status As Boolean = reader("Status") 'Hopefully type casting comes into play here
            If Not VMStatus.Keys.Contains(VMID) Then
                VMStatus.Add(VMID, True)
            Else
                VMStatus(VMID) = Status
            End If
        End While
        reader.Close()
        conn.Close()
    End Sub



    Private Sub UpdateVMStatus()
        Dim CheckboxList As List(Of CheckBox) = GetFormCheckboxes()
        conn.Open()
        For i As Integer = 1 To 6
            Dim VMID As String = $"VMID000{i}"
            Dim Status As Integer = If(CheckboxList(i - 1).Checked, 1, 0)
            Dim SqlQuery As String = $"UPDATE VENDING_MACHINES SET Status={Status} WHERE VMID='{VMID}';"
            Dim Cmd As New SQLiteCommand(SqlQuery, conn)
            Dim RowsAffected = Cmd.ExecuteNonQuery()
            If Not RowsAffected = 1 Then
                MessageBox.Show("Something Went Wrong!")
            End If
        Next
        conn.Close()
    End Sub


    Private Sub UpdateFormCBStates()
        Dim i As Integer = 0
        GetVMStatus()
        Dim CheckboxList As List(Of CheckBox) = GetFormCheckboxes()
        For Each VMID As String In VMStatus.Keys
            CheckboxList(i).Checked = VMStatus(VMID)
            i += 1
        Next
    End Sub



    Private Function GetFormCheckboxes() As List(Of CheckBox)
        Dim CheckboxList As New List(Of CheckBox)
        For Each control As Control In Me.Controls
            If TypeOf control Is CheckBox Then
                CheckboxList.Add(control)
            End If
        Next
        CheckboxList = CheckboxList.OrderBy(Function(c) c.Name).ToList() 'Sort by name
        Return CheckboxList
    End Function




    Private Sub AdminDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateFormCBStates()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        UpdateFormCBStates()
    End Sub

    Private Sub ApplyBtn_Click(sender As Object, e As EventArgs) Handles ApplyBtn.Click
        UpdateVMStatus()
        UpdateFormCBStates()
        MessageBox.Show("Changes Applied")
    End Sub
End Class