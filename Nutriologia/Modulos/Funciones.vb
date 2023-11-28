Imports System.Data.SqlClient
Module Funciones
    Public ActiveUser As New Integer
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public query As String
    Public numID As Integer

    Public Sub GenerarNumID(textbox, Tabla)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        numID = -1
        Try
            query = "SELECT * FROM " & Tabla
            cmd.CommandText = query
        Catch ex As Exception
            MsgBox("Error en la consulta")
        End Try

        Try
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    'Obtener el numero del ID del ultimo registro
                    numID = Val(dr(0).ToString)
                End While
            End If

            dr.Close()

            If (numID <= 0) Then
                numID = 1
            Else
                numID = numID + 1
            End If

            textbox.Text = numID
        Catch ex As Exception

        End Try
    End Sub

    'Funcion para mostrar una tabla en un dataGridView
    Public Sub CargaDatos(Tabla, DataGridView)
        Dim oda As New SqlDataAdapter
        Dim ods As New DataSet
        Dim datos As String
        datos = ""

        If Len(datos) = 0 Then
            query = "SELECT * FROM " & Tabla
            oda = New SqlDataAdapter(query, conn)  'Ejecutar la query (consulta) en la BD a la que apunta conn
            ods.Tables.Add(Tabla)         'Generar tabla en memoria
            oda.Fill(ods.Tables(Tabla))   'Poblar tabla
            DataGridView.DataSource = ods.Tables(Tabla)
            DataGridView.Visible = True
        End If
    End Sub

    Public Sub CargaDataProcedure(Instruccion, NumID, Tabla, DataGridView)
        Dim oda As New SqlDataAdapter
        Dim ods As New DataSet
        Dim datos As String
        datos = ""

        If Len(datos) = 0 Then
            query = Instruccion & " " & NumID
            oda = New SqlDataAdapter(query, conn)  'Ejecutar la query (consulta) en la BD a la que apunta conn
            ods.Tables.Add(Tabla)         'Generar tabla en memoria
            oda.Fill(ods.Tables(Tabla))   'Poblar tabla
            DataGridView.DataSource = ods.Tables(Tabla)
            DataGridView.Visible = True
        End If
    End Sub

    Public Sub IdentificarUsuario(DataGridView, Nombre)
        Try
            query = "SELECT * FROM Usuario WHERE Nombre = '" & Nombre & "'"
            Dim oda As New SqlDataAdapter
            Dim ods As New DataSet
            oda = New SqlDataAdapter(query, conn)  'Ejecutar la query (consulta) en la BD a la que apunta conn
            ods.Tables.Add("Usuario")         'Generar tabla en memoria
            oda.Fill(ods.Tables("Usuario"))   'Poblar tabla
            DataGridView.DataSource = ods.Tables("Usuario")
        Catch ex As Exception

        End Try
    End Sub
End Module
