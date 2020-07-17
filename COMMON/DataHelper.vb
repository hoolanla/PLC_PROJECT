



Public Class DataHelper

    Public Shared Function getSQLServerConnectionObject(ByVal connectionString As String) As SqlClient.SqlConnection
        Dim sqlConnection As New SqlClient.SqlConnection
        'If Not IsNothing(sqlConnection) AndAlso sqlConnection.State = ConnectionState.Open Then sqlConnection.Close()

        Try
            sqlConnection.ConnectionString = connectionString
            sqlConnection.Open()

            'Throw New Exception("Test Exception Error 88")

            Return sqlConnection
        Catch ex As Exception

            ' WriteLogFile("Call Function getSQLServerConnectionObject - " + ex.Message)

            Throw ex

        Finally
            sqlConnection.Close()
        End Try


    End Function

End Class
