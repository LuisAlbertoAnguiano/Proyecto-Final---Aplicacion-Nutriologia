Public Class frm_Revision

    Private Sub RegistrarRevision()
        Dim ID_Paciente As String
        Dim ID_Revision As String
        Dim Peso As String
        Dim Estatura As String
        Dim Cintura As String
        Dim Cadera As String
        Dim IMC As String
        Dim ICC As String

        ID_Paciente = tb_ID_Paciente.Text
        ID_Revision = tb_ID_Revision.Text
        Peso = tb_Peso.Text
        Estatura = tb_Estatura.Text
        Cintura = tb_Cintura.Text
        Cadera = tb_Cadera.Text
        IMC = tb_IMC.Text
        ICC = tb_ICC.Text


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_RegistrarRevision " & ID_Paciente & ", " & ID_Revision & ", "
        query = query & Peso & ", " & Estatura & ", "
        query = query & Cintura & ", " & Cadera & ", " & IMC & ", " & ICC & ", "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub ActualizarRevision()
        Dim ID_Paciente As String
        Dim ID_Revision As String
        Dim Peso As String
        Dim Estatura As String
        Dim Cintura As String
        Dim Cadera As String
        Dim IMC As String
        Dim ICC As String

        ID_Paciente = tb_ID_Paciente.Text
        ID_Revision = tb_ID_Revision.Text
        Peso = tb_Peso.Text
        Estatura = tb_Estatura.Text
        Cintura = tb_Cintura.Text
        Cadera = tb_Cadera.Text
        IMC = tb_IMC.Text
        ICC = tb_ICC.Text


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarRevision " & ID_Paciente & ", " & ID_Revision & ", "
        query = query & Peso & ", " & Estatura & ", "
        query = query & Cintura & ", " & Cadera & ", " & IMC & ", " & ICC & ", "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarRevision(numID As Integer)

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarRevision "
        query = query & numID & ", " & tb_ID_Revision.Text

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al eliminar registros...revisar información")
        End Try
    End Sub

    Private Sub Limpiar()
        tb_ID_Revision.Text = ""
        tb_Peso.Text = ""
        tb_Estatura.Text = ""
        tb_Cintura.Text = ""
        tb_Cadera.Text = ""
        tb_IMC.Text = ""
        tb_ICC.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
    End Sub
    Private Sub frm_Revision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        CargaDatos("View_MostrarPacientes", DGV_Pacientes)
        CargaDataProcedure("EXECUTE sp_Consultar_Revision", numID, "Revision", DGV_Revision)
    End Sub

    Private Sub DGV_Pacientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Pacientes.CellMouseClick
        Dim fila As Integer

        Limpiar()
        Try
            fila = DGV_Pacientes.CurrentRow.Index
            tb_ID_Paciente.Text = DGV_Pacientes.Rows(fila).Cells(0).Value

            CargaDataProcedure("EXECUTE sp_Consultar_Revision", tb_ID_Paciente.Text, "Revision", DGV_Revision)

            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try
    End Sub

    Private Sub DGV_Revision_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Revision.CellMouseClick
        Dim fila As Integer

        Limpiar()
        Try
            fila = DGV_Revision.CurrentRow.Index
            tb_ID_Revision.Text = DGV_Revision.Rows(fila).Cells(1).Value
            tb_Peso.Text = DGV_Revision.Rows(fila).Cells(2).Value
            tb_Estatura.Text = DGV_Revision.Rows(fila).Cells(3).Value
            tb_Cintura.Text = DGV_Revision.Rows(fila).Cells(4).Value
            tb_Cadera.Text = DGV_Revision.Rows(fila).Cells(5).Value
            tb_IMC.Text = DGV_Revision.Rows(fila).Cells(6).Value
            tb_ICC.Text = DGV_Revision.Rows(fila).Cells(7).Value

            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Try
            RegistrarRevision()
            CargaDataProcedure("EXECUTE sp_Consultar_Revision", tb_ID_Paciente.Text, "Revision", DGV_Revision)
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarRevision()
            CargaDataProcedure("EXECUTE sp_Consultar_Revision", tb_ID_Paciente.Text, "Revision", DGV_Revision)
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarRevision(tb_ID_Paciente.Text)
            CargaDataProcedure("EXECUTE sp_Consultar_Revision", tb_ID_Paciente.Text, "Revision", DGV_Revision)
            btAgregar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Limpiar()
        CargaDataProcedure("EXECUTE sp_Consultar_Revision", tb_ID_Paciente.Text, "Revision", DGV_Revision)
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

    Private Sub frm_Revision_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub

    Private Sub tb_ID_Revision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ID_Revision.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub tb_PesoActual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Peso.KeyPress
        NumerosDecimales(e)
    End Sub

    Private Sub tb_Estatura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Estatura.KeyPress
        NumerosDecimales(e)
    End Sub

    Private Sub tb_Cintura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Cintura.KeyPress
        NumerosDecimales(e)
    End Sub

    Private Sub tb_Cadera_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Cadera.KeyPress
        NumerosDecimales(e)
    End Sub

    Private Sub tb_IMC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IMC.KeyPress
        NumerosDecimales(e)
    End Sub

    Private Sub tb_ICC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ICC.KeyPress
        NumerosDecimales(e)
    End Sub
End Class