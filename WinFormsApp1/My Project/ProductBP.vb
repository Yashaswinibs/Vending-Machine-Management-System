Public Class ProductBP
    Public ProdName As String
    Public ProdPrice As Integer
    Public ProdID As String
    Public Sub New(Name As String, Price As Integer, Id As String)
        ProdName = Name
        ProdPrice = Price
        ProdID = Id
    End Sub
End Class
