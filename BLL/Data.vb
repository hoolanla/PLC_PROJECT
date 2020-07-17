Public Class Data



    Dim _DAL As New DAL.Data

    Public Function getDataInside(model As MODEL.Data) As DataTable
        Return _DAL.getData(model)
    End Function

    Public Function getStatus() As MODEL.Production
        Return _DAL.getStatus()
    End Function

    Public Function NoActive(model As MODEL.Data) As Boolean
        Return _DAL.NoActive(model)
    End Function
End Class
