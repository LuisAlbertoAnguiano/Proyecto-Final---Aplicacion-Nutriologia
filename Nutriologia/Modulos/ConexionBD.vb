Imports System.Data.SqlClient
Module ConexionBD
    Public conn As New SqlConnection

    Public Sub conexion()
        Try
            conn.ConnectionString = "Data Source = ASREN-PC\SQLSERVER; Initial Catalog = BD_Nutriologo; 
            Integrated Security = True"

            conn.Open()
        Catch ex As Exception
            MsgBox("No se conecto a la base de datos...", vbInformation, ex.Message)
        End Try
    End Sub
End Module