Public Class frm_DietasPaciente

    Private Sub RegistrarDietaPaciente()
        Dim ID_Paciente As String
        Dim ID_Dieta As String
        Dim ID_Sistema As String
        Dim KCal As String
        Dim HC As String
        Dim Proteinas As String
        Dim Lipidos As String
        Dim Notas As String

        ID_Paciente = tb_ID_Paciente.Text
        ID_Dieta = tb_ID_Dieta.Text
        ID_Sistema = tb_ID_Sistema.Text
        KCal = tb_Calorias.Text
        HC = tb_HC.Text
        Proteinas = tb_Proteinas.Text
        Lipidos = tb_Lipidos.Text
        Notas = tb_Notas.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_RegistrarDieta_Paciente " & ID_Paciente & ", " & ID_Dieta & ", " & ID_Sistema & ", "
        query = query & KCal & ", " & HC & ", " & Proteinas & ", " & Lipidos & ", '" & Notas & "', "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub ActualizarDietaPaciente()
        Dim ID_Paciente As String
        Dim ID_Dieta As String
        Dim ID_Sistema As String
        Dim KCal As String
        Dim HC As String
        Dim Proteinas As String
        Dim Lipidos As String
        Dim Notas As String

        ID_Paciente = tb_ID_Paciente.Text
        ID_Dieta = tb_ID_Dieta.Text
        ID_Sistema = tb_ID_Sistema.Text
        KCal = tb_Calorias.Text
        HC = tb_HC.Text
        Proteinas = tb_Proteinas.Text
        Lipidos = tb_Lipidos.Text
        Notas = tb_Notas.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarDieta_Paciente " & ID_Paciente & ", " & ID_Dieta & ", " & ID_Sistema & ", "
        query = query & KCal & ", " & HC & ", " & Proteinas & ", " & Lipidos & ", '" & Notas & "', "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarDietaPaciente(numID As Integer)
        Dim ID_Paciente As String

        ID_Paciente = numID


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarDieta_Paciente "
        query = query & ID_Paciente

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al eliminar registros...revisar información")
        End Try
    End Sub

    Private Sub Limpiar()
        tb_ID_Dieta.Text = ""
        tb_ID_Sistema.Text = ""
        tb_Calorias.Text = ""
        tb_HC.Text = ""
        tb_Proteinas.Text = ""
        tb_Lipidos.Text = ""
        tb_Notas.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
        btCancelar.Enabled = False
    End Sub

    Private Sub frm_DietasPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        Limpiar()
        CargaDatos("View_MostrarPacientes", DGV_Pacientes)
        CargaDatos("View_MostrarDietas", DGV_Dietas)
        CargaDatos("View_MostrarSistemas", DGV_Sistemas)
        CargaDataProcedure("EXECUTE sp_Consultar_Dieta_Paciente", numID, "DietaPaciente", DGV_DietasPaciente)

    End Sub

    Private Sub DGV_Pacientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Pacientes.CellMouseClick
        Dim fila As Integer

        Limpiar()
        Try
            fila = DGV_Pacientes.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Paciente.Text = DGV_Pacientes.Rows(fila).Cells(0).Value

            CargaDataProcedure("EXECUTE sp_Consultar_Dieta_Paciente", tb_ID_Paciente.Text, "DietaPaciente", DGV_DietasPaciente)

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

        Try
            fila = 0
            tb_ID_Dieta.Text = DGV_DietasPaciente.Rows(fila).Cells(1).Value
            tb_ID_Sistema.Text = DGV_DietasPaciente.Rows(fila).Cells(2).Value
            tb_Calorias.Text = DGV_DietasPaciente.Rows(fila).Cells(3).Value
            tb_HC.Text = DGV_DietasPaciente.Rows(fila).Cells(4).Value
            tb_Proteinas.Text = DGV_DietasPaciente.Rows(fila).Cells(5).Value
            tb_Lipidos.Text = DGV_DietasPaciente.Rows(fila).Cells(6).Value
            tb_Notas.Text = DGV_DietasPaciente.Rows(fila).Cells(7).Value

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

    Private Sub DGV_Dietas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Dietas.CellMouseClick
        Dim fila As Integer

        Try
            fila = DGV_Dietas.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Dieta.Text = DGV_Dietas.Rows(fila).Cells(0).Value

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

    Private Sub DGV_Sistemas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Sistemas.CellMouseClick
        Dim fila As Integer

        Try
            fila = DGV_Sistemas.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Sistema.Text = DGV_Sistemas.Rows(fila).Cells(0).Value

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

    Private Sub DGV_DietasPaciente_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_DietasPaciente.CellMouseClick
        Dim fila As Integer

        Try
            fila = DGV_DietasPaciente.CurrentRow.Index   'Regresa el renglon donde se dio el click
            tb_ID_Dieta.Text = DGV_DietasPaciente.Rows(fila).Cells(1).Value
            tb_ID_Sistema.Text = DGV_DietasPaciente.Rows(fila).Cells(2).Value
            tb_Calorias.Text = DGV_DietasPaciente.Rows(fila).Cells(3).Value
            tb_HC.Text = DGV_DietasPaciente.Rows(fila).Cells(4).Value
            tb_Proteinas.Text = DGV_DietasPaciente.Rows(fila).Cells(5).Value
            tb_Lipidos.Text = DGV_DietasPaciente.Rows(fila).Cells(6).Value
            tb_Notas.Text = DGV_DietasPaciente.Rows(fila).Cells(7).Value

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
            RegistrarDietaPaciente()
            CargaDataProcedure("EXECUTE sp_Consultar_Dieta_Paciente", tb_ID_Paciente.Text, "DietaPaciente", DGV_DietasPaciente)
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarDietaPaciente()
            CargaDataProcedure("EXECUTE sp_Consultar_Dieta_Paciente", tb_ID_Paciente.Text, "DietaPaciente", DGV_DietasPaciente)

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarDietaPaciente(tb_ID_Paciente.Text)
            CargaDataProcedure("EXECUTE sp_Consultar_Dieta_Paciente", tb_ID_Paciente.Text, "DietaPaciente", DGV_DietasPaciente)
            btAgregar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Limpiar()
        CargaDataProcedure("EXECUTE sp_Consultar_Dieta_Paciente", numID, "DietaPaciente", DGV_DietasPaciente)
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

    Private Sub frm_DietasPaciente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub

    Private Sub tb_Calorias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Calorias.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub tb_HC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_HC.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub tb_Proteinas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Proteinas.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub tb_Lipidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Lipidos.KeyPress
        SoloNumeros(e)
    End Sub
End Class