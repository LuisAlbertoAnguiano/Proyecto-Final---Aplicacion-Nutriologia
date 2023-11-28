Public Class frm_Pacientes

    Private Sub RegistrarPaciente()
        Dim ID_Paciente As String
        Dim Nombre As String
        Dim Ap As String
        Dim Am As String
        Dim Sexo As String
        Dim FechaNacimiento As String
        Dim Telefono As String
        Dim Correo As String

        ID_Paciente = tb_ID_Paciente.Text
        Nombre = tbNombre.Text
        Ap = tb_ApeP.Text
        Am = tb_ApeM.Text
        Sexo = cmb_Sexo.Text
        If (tb_Dia.Text.Length > 0 And tb_mes.Text.Length > 0 And tb_año.Text.Length > 0) Then
            FechaNacimiento = tb_mes.Text & "/" & tb_Dia.Text & "/" & tb_año.Text
        Else
            FechaNacimiento = Nothing
        End If

        Telefono = tb_Telefono.Text

        If (Len(tb_Correo.Text) > 0 And Len(cmbCorreos.Text) > 0) Then
            Correo = tb_Correo.Text + "@" + cmbCorreos.Text
        Else
            Correo = ""
        End If


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        conn.Close()
        conn.Open()

        query = "EXECUTE sp_RegistrarPaciente " & ID_Paciente & ", '" & Nombre & "', "
        query = query & "'" & Ap & "', '" & Am & "', '" & Sexo & "', "
        query = query & "'" & FechaNacimiento & "', '" & Telefono & "', '" & Correo & "', "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString() & ", 1"

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub ActualizarPaciente()
        Dim ID_Paciente As String
        Dim Nombre As String
        Dim Ap As String
        Dim Am As String
        Dim Sexo As String
        Dim FechaNacimiento As String
        Dim Telefono As String
        Dim Correo As String

        ID_Paciente = tb_ID_Paciente.Text
        Nombre = tbNombre.Text
        Ap = tb_ApeP.Text
        Am = tb_ApeM.Text
        Sexo = cmb_Sexo.Text
        If (Len(tb_Dia.Text) > 0 And Len(tb_mes.Text) > 0 And Len(tb_año.Text) > 0) Then
            FechaNacimiento = tb_mes.Text & "/" & tb_Dia.Text & "/" & tb_año.Text
        Else
            FechaNacimiento = Nothing
        End If

        Telefono = tb_Telefono.Text

        If (Len(tb_Correo.Text) > 0 And Len(cmbCorreos.Text) > 0) Then
            Correo = tb_Correo.Text + "@" + cmbCorreos.Text
        Else
            Correo = ""
        End If

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarPaciente " & ID_Paciente & ", '" & Nombre & "', "
        query = query & "'" & Ap & "', '" & Am & "', '" & Sexo & "', "
        query = query & "'" & FechaNacimiento & "', '" & Telefono & "', '" & Correo & "', "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query
        '
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarPaciente(numID As Integer)
        Dim ID_Paciente As String

        ID_Paciente = numID


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarPaciente "
        query = query & ID_Paciente & ", " & ActiveUser.ToString() & ", 0"

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al eliminar registros...revisar información")
        End Try
    End Sub

    Private Sub Limpiar()
        GenerarNumID(tb_ID_Paciente, "Paciente")

        tbNombre.Text = ""
        tb_ApeP.Text = ""
        tb_ApeM.Text = ""
        cmb_Sexo.Text = ""
        tb_Dia.Text = ""
        tb_mes.Text = ""
        tb_año.Text = ""
        tb_Telefono.Text = ""
        tb_Correo.Text = ""
        cmbCorreos.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
    End Sub

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        CargaDatos("View_MostrarPacientes", DGV_Pacientes)
        Limpiar()
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Try
            RegistrarPaciente()
            CargaDatos("View_MostrarPacientes", DGV_Pacientes)
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarPaciente()
            CargaDatos("View_MostrarPacientes", DGV_Pacientes)
        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub
    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarPaciente(tb_ID_Paciente.Text)
            CargaDatos("View_MostrarPacientes", DGV_Pacientes)
            Limpiar()
            btAgregar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Limpiar()
        CargaDatos("View_MostrarPacientes", DGV_Pacientes)
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
    Private Sub Pacientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub

    Private Sub DGV_Pacientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Pacientes.CellMouseClick
        Dim fila As Integer
        Dim posicion
        Dim valor

        Limpiar()
        '*---
        '*- Mover información a pantalla
        '*---
        Try
            fila = DGV_Pacientes.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Paciente.Text = DGV_Pacientes.Rows(fila).Cells(0).Value
            tbNombre.Text = DGV_Pacientes.Rows(fila).Cells(1).Value
            tb_ApeP.Text = DGV_Pacientes.Rows(fila).Cells(2).Value
            tb_ApeM.Text = DGV_Pacientes.Rows(fila).Cells(3).Value

            valor = Mid(DGV_Pacientes.Rows(fila).Cells(4).Value, 1)
            cmb_Sexo.Text = valor

            valor = Mid(DGV_Pacientes.Rows(fila).Cells(5).Value, 1)
            If Len(valor) > 0 Then
                posicion = InStr(1, DGV_Pacientes.Rows(fila).Cells(5).Value, "/", CompareMethod.Text)
                posicion = posicion - 1
                tb_Dia.Text = Mid(DGV_Pacientes.Rows(fila).Cells(5).Value, 1, posicion)

                posicion = InStr(posicion + 2, DGV_Pacientes.Rows(fila).Cells(5).Value, "/", CompareMethod.Text)
                posicion = posicion - 1
                tb_mes.Text = Mid(DGV_Pacientes.Rows(fila).Cells(5).Value, posicion - 1, posicion - 3)

                posicion = InStr(posicion, DGV_Pacientes.Rows(fila).Cells(5).Value, "/", CompareMethod.Text)
                posicion = posicion + 1
                tb_año.Text = Mid(DGV_Pacientes.Rows(fila).Cells(5).Value, posicion, 10)
            Else
                tb_Dia.Text = ""
                tb_mes.Text = ""
                tb_año.Text = ""
            End If

            tb_Telefono.Text = DGV_Pacientes.Rows(fila).Cells(6).Value

            posicion = InStr(1, DGV_Pacientes.Rows(fila).Cells(7).Value, "@", CompareMethod.Text)
            posicion = posicion - 1
            tb_Correo.Text = Mid(DGV_Pacientes.Rows(fila).Cells(7).Value, 1, posicion)
            valor = Mid(DGV_Pacientes.Rows(fila).Cells(7).Value, posicion + 2, 20)
            If (UCase(valor) = "HOTMAIL.COM") Then
                cmbCorreos.Text = "hotmail.com"
            ElseIf (UCase(valor) = "OUTLOOK.COM") Then
                cmbCorreos.Text = "outlook.com"
            ElseIf (UCase(valor) = "GMAIL.COM") Then
                cmbCorreos.Text = "gmail.com"
            End If

            btAgregar.Enabled = False
            btModificar.Enabled = True
            btEliminar.Enabled = True

        Catch ex As Exception
            btAgregar.Enabled = False
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try
    End Sub

    Private Sub tbNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub tb_ApeP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ApeP.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub tb_ApeM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ApeM.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub tb_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Telefono.KeyPress
        SoloNumeros(e)
    End Sub
End Class