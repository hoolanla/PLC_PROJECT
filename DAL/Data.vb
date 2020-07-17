Imports System.Data.SqlClient
Imports MODEL
Public Class Data



    Public Function getData(model As MODEL.Data) As DataTable
        Dim connStr As String = System.Configuration.ConfigurationSettings.AppSettings("ConnectionString")
        Dim conn As SqlConnection = COMMON.DataHelper.getSQLServerConnectionObject(connStr)
        Dim ds As New DataSet()

        Try
            Dim sql As String = " Select TOP 10 * FROM v_data order by panelTime Desc "
            Dim adp As New SqlDataAdapter(sql, conn)
            adp.SelectCommand.CommandType = CommandType.Text
            adp.Fill(ds)

            Return ds.Tables(0)

        Catch ex As Exception
            '      Common.DataHelper.WriteLogFile("Call Function getDepartment_Search_L1 - ERROR: " + ex.Message, LogFileName);
            Throw ex
        Finally
            conn.Close()
        End Try
    End Function

    Public Function getStatus() As MODEL.Production
        Dim connStr As String = System.Configuration.ConfigurationSettings.AppSettings("ConnectionString")
        Dim conn As SqlConnection = COMMON.DataHelper.getSQLServerConnectionObject(connStr)
        Dim ds As New DataSet()

        Try
            Dim sql As String = " Select * FROM production_line "
            Dim adp As New SqlDataAdapter(sql, conn)
            adp.SelectCommand.CommandType = CommandType.Text
            adp.Fill(ds)
            Dim dt As DataTable
            dt = ds.Tables(0).Copy()
            Dim model_production As New MODEL.Production()
            If dt.Rows.Count > 0 Then

                Dim arrList As New ArrayList()
                For i As Integer = 0 To 16
                    Dim model_data As New MODEL.Data()

                    model_data.Production_active = dt.Rows(i)("Production_active").ToString()
                    model_data.Line_Manual = dt.Rows(i)("Line_manual").ToString()
                    model_data.Production_warning = dt.Rows(i)("Production_warning").ToString()
                    model_data.Stopper_active = dt.Rows(i)("stopper_active").ToString()
                    model_data.Time_loop = dt.Rows(i)("time_loop").ToString()
                    model_data.Line_Name = i + 1

                    arrList.Add(model_data)


                Next
                model_production.line = New ArrayList()
                model_production.line = arrList

            End If

            Return model_production

        Catch ex As Exception
            '      Common.DataHelper.WriteLogFile("Call Function getDepartment_Search_L1 - ERROR: " + ex.Message, LogFileName);
            Throw ex
        Finally
            conn.Close()
        End Try
    End Function

    Public Function NoActive(model As MODEL.Data) As Boolean
        Dim connStr As String = System.Configuration.ConfigurationSettings.AppSettings("ConnectionString")
        Dim conn As SqlConnection = COMMON.DataHelper.getSQLServerConnectionObject(connStr)
        Dim ds As New DataSet()

        Try
            Dim sql As String = " update  production_line SET production_active = 0 WHERE status_id = " & model.Line_Name
            Dim adp As New SqlDataAdapter()

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            adp.UpdateCommand = conn.CreateCommand
            adp.UpdateCommand.CommandText = sql
            adp.UpdateCommand.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            '      Common.DataHelper.WriteLogFile("Call Function getDepartment_Search_L1 - ERROR: " + ex.Message, LogFileName);
            Throw ex
        Finally
            conn.Close()
        End Try
    End Function

End Class



