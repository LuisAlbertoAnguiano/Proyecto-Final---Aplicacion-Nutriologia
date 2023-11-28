Public Class frm_FrecAlimentaria

    Private Sub RegistrarFrecAlimentaria()
        Dim ID_Paciente As String
        Dim ID_Alimento As String
        Dim FrecSemana As String
        Dim FrecDia As String
        Dim Especificacion As String


        ID_Paciente = tb_ID_Paciente.Text
        ID_Alimento = tb_ID_Alimento.Text
        FrecSemana = tb_FrecSemanal.Text
        FrecDia = tb_FrecDiaria.Text
        Especificacion = tb_Especificacion.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_RegistrarFrec_Alimentaria " & ID_Paciente & ", " & ID_Alimento
        query = query & ", '" & FrecSemana & "', '" & FrecDia & "', '" & Especificacion & "', "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub ActualizarFrecAlimentaria()
        Dim ID_Paciente As String
        Dim ID_Alimento As String
        Dim FrecSemana As String
        Dim FrecDia As String
        Dim Especificacion As String


        ID_Paciente = tb_ID_Paciente.Text
        ID_Alimento = tb_ID_Alimento.Text
        FrecSemana = tb_FrecSemanal.Text
        FrecDia = tb_FrecDiaria.Text
        Especificacion = tb_Especificacion.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarFrec_Alimentaria " & ID_Paciente & ", " & ID_Alimento
        query = query & ", '" & FrecSemana & "', '" & FrecDia & "', '" & Especificacion & "', "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarFrecAlimentaria(numID As Integer)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarFrec_Alimentaria "
        query = query & numID & " ," & tb_ID_Alimento.Text

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al eliminar registros...revisar información")
        End Try
    End Sub

    Private Sub Limpiar()
        tb_ID_Alimento.Text = ""
        tb_FrecDiaria.Text = ""
        tb_FrecSemanal.Text = ""
        tb_Especificacion.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
        btCancelar.Enabled = False
    End Sub

    Private Sub frm_FrecAlimentaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        Limpiar()
        CargaDatos("View_MostrarPacientes", DGV_Pacientes)
        CargaDatos("View_MostrarAlimentos", DGV_Alimentos)
        CargaDataProcedure("EXECUTE sp_Consultar_Frecuencia_Alimentaria", numID, "Frec_Alimentaria", DGV_FrecAlimentaria)
    End Sub

    Private Sub DGV_Pacientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Pacientes.CellMouseClick
        Dim fila As Integer

        Limpiar()
        Try
            fila = DGV_Pacientes.CurrentRow.Index
            tb_ID_Paciente.Text = DGV_Pacientes.Rows(fila).Cells(0).Value

            CargaDataProcedure("EXECUTE sp_Consultar_Frecuencia_Alimentaria", tb_ID_Paciente.Text, "Frec_Alimentaria", DGV_FrecAlimentaria)

            btAgregar.Enabled = True
            btModificar.Enabled = False
            btEliminar.Enabled = False
            btCancelar.Enabled = False
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = False
            btEliminar.Enabled = False
            btCancelar.Enabled = False
        End Try
    End Sub

    Private Sub DGV_Alimentos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Alimentos.CellMouseClick
        Dim fila As Integer

        Try
            fila = DGV_Alimentos.CurrentRow.Index
            tb_ID_Alimento.Text = DGV_Alimentos.Rows(fila).Cells(0).Value

            btAgregar.Enabled = True
            btModificar.Enabled = False
            btEliminar.Enabled = False
            btCancelar.Enabled = False
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = False
            btEliminar.Enabled = False
            btCancelar.Enabled = False
        End Try
    End Sub

    Private Sub DGV_FrecAlimentaria_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_FrecAlimentaria.CellMouseClick
        Dim fila As Integer

        Try
            fila = DGV_FrecAlimentaria.CurrentRow.Index
            tb_ID_Alimento.Text = DGV_FrecAlimentaria.Rows(fila).Cells(0).Value
            tb_FrecSemanal.Text = DGV_FrecAlimentaria.Rows(fila).Cells(2).Value
            tb_FrecDiaria.Text = DGV_FrecAlimentaria.Rows(fila).Cells(3).Value
            tb_Especificacion.Text = DGV_FrecAlimentaria.Rows(fila).Cells(4).Value

            btAgregar.Enabled = False
            btModificar.Enabled = True
            btCancelar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = False
            btEliminar.Enabled = False
            btCancelar.Enabled = False
        End Try
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Try
            RegistrarFrecAlimentaria()
            CargaDataProcedure("EXECUTE sp_Consultar_Frecuencia_Alimentaria", tb_ID_Paciente.Text, "Frec_Alimentaria", DGV_FrecAlimentaria)
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarFrecAlimentaria()
            CargaDataProcedure("EXECUTE sp_Consultar_Frecuencia_Alimentaria", tb_ID_Paciente.Text, "Frec_Alimentaria", DGV_FrecAlimentaria)

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarFrecAlimentaria(tb_ID_Paciente.Text)
            CargaDataProcedure("EXECUTE sp_Consultar_Frecuencia_Alimentaria", tb_ID_Paciente.Text, "Frec_Alimentaria", DGV_FrecAlimentaria)
            btAgregar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Limpiar()
        CargaDataProcedure("EXECUTE sp_Consultar_Frecuencia_Alimentaria", numID, "Frec_Alimentaria", DGV_FrecAlimentaria)
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

    Private Sub frm_FrecAlimentaria_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub
End Class