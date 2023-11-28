Imports System.Data.SqlClient
Public Class frm_Citas

    Private Sub RegistrarCita()
        Dim ID_Paciente As String
        Dim NumCita As String
        Dim Fecha As String


        ID_Paciente = tb_ID_Paciente.Text
        NumCita = tb_Cita.Text

        If (Len(tb_Dia.Text) > 0 And Len(tb_mes.Text) > 0 And Len(tb_año.Text) > 0) Then
            Fecha = tb_mes.Text & "/" & tb_Dia.Text & "/" & tb_año.Text
        Else
            Fecha = Nothing
        End If

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_RegistrarCita " & ID_Paciente & ", " & NumCita & ", '" & Fecha & "', "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub
    Private Sub ActualizarCita()
        Dim ID_Paciente As String
        Dim NumCita As String
        Dim Fecha As String


        ID_Paciente = tb_ID_Paciente.Text
        NumCita = tb_Cita.Text

        If (Len(tb_Dia.Text) > 0 And Len(tb_mes.Text) > 0 And Len(tb_año.Text) > 0) Then
            Fecha = tb_mes.Text & "/" & tb_Dia.Text & "/" & tb_año.Text
        Else
            Fecha = Nothing
        End If

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarCita " & ID_Paciente & ", " & NumCita & ", '" & Fecha & "', "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarCita(numID As Integer)
        Dim ID_Paciente As String

        ID_Paciente = numID


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarCita "
        query = query & ID_Paciente & ", " & tb_Cita.Text

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al eliminar registros...revisar información")
        End Try
    End Sub

    Private Sub Limpiar()
        tb_Cita.Text = ""
        tb_Dia.Text = ""
        tb_mes.Text = ""
        tb_año.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
    End Sub
    Private Sub frm_Citas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        Limpiar()
        CargaDatos("Paciente", DGV_Pacientes)
        CargaDataProcedure("EXECUTE sp_Consultar_Citas", numID, "Citas", DGV_Citas)
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Try
            RegistrarCita()
            CargaDataProcedure("EXECUTE sp_Consultar_Citas", tb_ID_Paciente.Text, "Citas", DGV_Citas)
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarCita()
            CargaDataProcedure("EXECUTE sp_Consultar_Citas", tb_ID_Paciente.Text, "Citas", DGV_Citas)

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarCita(tb_ID_Paciente.Text)
            CargaDataProcedure("EXECUTE sp_Consultar_Citas", tb_ID_Paciente.Text, "Citas", DGV_Citas)
            btAgregar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Limpiar()
        CargaDataProcedure("EXECUTE sp_Consultar_Citas", tb_ID_Paciente.Text, "Citas", DGV_Citas)
    End Sub

    Private Sub btRegresar_Click(sender As Object, e As EventArgs) Handles btRegresar.Click
        Try
            Close()
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            Close()
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub

    Private Sub frm_Citas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub

    Private Sub tb_Dia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Dia.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub tb_mes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_mes.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub tb_año_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_año.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub DGV_Pacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Pacientes.CellClick
        Dim fila As Integer
        Dim posicion
        Dim valor

        Limpiar()
        Try
            fila = DGV_Pacientes.CurrentRow.Index   'Regresa el renglon donde se dio el click
            tb_ID_Paciente.Text = DGV_Pacientes.Rows(fila).Cells(0).Value

            CargaDataProcedure("EXECUTE sp_Consultar_Citas", tb_ID_Paciente.Text, "Citas", DGV_Citas)

            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try

        Try
            fila = 0
            tb_Cita.Text = DGV_Citas.Rows(fila).Cells(1).Value

            valor = Mid(DGV_Pacientes.Rows(fila).Cells(2).Value, 1)
            If Len(valor) > 0 Then
                posicion = InStr(1, DGV_Citas.Rows(fila).Cells(2).Value, "/", CompareMethod.Text)
                posicion = posicion - 1
                tb_Dia.Text = Mid(DGV_Citas.Rows(fila).Cells(2).Value, 1, posicion)

                posicion = InStr(posicion + 2, DGV_Citas.Rows(fila).Cells(2).Value, "/", CompareMethod.Text)
                posicion = posicion - 1
                tb_mes.Text = Mid(DGV_Citas.Rows(fila).Cells(2).Value, posicion - 1, posicion - 3)

                posicion = InStr(posicion, DGV_Citas.Rows(fila).Cells(2).Value, "/", CompareMethod.Text)
                posicion = posicion + 1
                tb_año.Text = Mid(DGV_Citas.Rows(fila).Cells(2).Value, posicion, 10)
            Else
                tb_Dia.Text = ""
                tb_mes.Text = ""
                tb_año.Text = ""
            End If

            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try
    End Sub

    Private Sub DGV_Citas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Citas.CellClick
        Dim fila As Integer
        Dim posicion
        Dim valor

        Try
            fila = DGV_Citas.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_Cita.Text = DGV_Citas.Rows(fila).Cells(1).Value

            valor = Mid(DGV_Pacientes.Rows(fila).Cells(2).Value, 1)
            If Len(valor) > 0 Then
                posicion = InStr(1, DGV_Citas.Rows(fila).Cells(2).Value, "/", CompareMethod.Text)
                posicion = posicion - 1
                tb_Dia.Text = Mid(DGV_Citas.Rows(fila).Cells(2).Value, 1, posicion)

                posicion = InStr(posicion + 2, DGV_Citas.Rows(fila).Cells(2).Value, "/", CompareMethod.Text)
                posicion = posicion - 1
                tb_mes.Text = Mid(DGV_Citas.Rows(fila).Cells(2).Value, posicion - 1, posicion - 3)

                posicion = InStr(posicion, DGV_Citas.Rows(fila).Cells(2).Value, "/", CompareMethod.Text)
                posicion = posicion + 1
                tb_año.Text = Mid(DGV_Citas.Rows(fila).Cells(2).Value, posicion, 10)
            Else
                tb_Dia.Text = ""
                tb_mes.Text = ""
                tb_año.Text = ""
            End If

            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try
    End Sub
End Class