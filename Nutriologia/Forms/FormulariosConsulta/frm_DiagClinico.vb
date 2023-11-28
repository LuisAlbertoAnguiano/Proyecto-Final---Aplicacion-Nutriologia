Public Class frm_DiagClinico

    Private Sub RegistrarDiagClinico()
        Dim ID_Paciente As String
        Dim NumDiagnostico As String
        Dim Enfermedad As String
        Dim AtdFamiliar As String
        Dim Alergia As String
        Dim Sintomas As String
        Dim Signos As String
        Dim MedSup As String

        ID_Paciente = tb_ID_Paciente.Text
        NumDiagnostico = tb_NumDiag.Text
        Enfermedad = tb_Enfermedad.Text
        AtdFamiliar = tb_AtdFamiliar.Text
        Alergia = tb_Alergia.Text
        Sintomas = tb_Sintomas.Text
        Signos = tb_Signos.Text
        MedSup = tb_MedSup.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_RegistrarDiag_Clinico " & ID_Paciente & ", " & NumDiagnostico & ", '" & Enfermedad
        query = query & "', '" & AtdFamiliar & "', '" & Alergia & "', '" & Sintomas & "', '"
        query = query & Signos & "', '" & MedSup & "', "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub ActualizarDiagClinico()
        Dim ID_Paciente As String
        Dim NumDiagnostico As String
        Dim Enfermedad As String
        Dim AtdFamiliar As String
        Dim Alergia As String
        Dim Sintomas As String
        Dim Signos As String
        Dim MedSup As String

        ID_Paciente = tb_ID_Paciente.Text
        NumDiagnostico = tb_NumDiag.Text
        Enfermedad = tb_Enfermedad.Text
        AtdFamiliar = tb_AtdFamiliar.Text
        Alergia = tb_Alergia.Text
        Sintomas = tb_Sintomas.Text
        Signos = tb_Signos.Text
        MedSup = tb_MedSup.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarDiag_Clinico " & ID_Paciente & ", " & NumDiagnostico & ", '" & Enfermedad
        query = query & "', '" & AtdFamiliar & "', '" & Alergia & "', '" & Sintomas & "', '"
        query = query & Signos & "', '" & MedSup & "', "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarDiagClinico(numID As Integer)
        Dim ID_Paciente As String

        ID_Paciente = numID


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarDiag_Clinico "
        query = query & ID_Paciente & ", " & tb_NumDiag.Text

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al eliminar registros...revisar información")
        End Try
    End Sub
    Private Sub Limpiar()
        tb_NumDiag.Text = ""
        tb_Enfermedad.Text = ""
        tb_AtdFamiliar.Text = ""
        tb_Alergia.Text = ""
        tb_Sintomas.Text = ""
        tb_Signos.Text = ""
        tb_MedSup.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
    End Sub
    Private Sub frm_DiagClinico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        CargaDatos("View_MostrarPacientes", DGV_Pacientes)
        CargaDataProcedure("EXECUTE sp_Consultar_Diagnostico_Clinico", numID, "Diag_Clinico", DGV_DiagClinico)
    End Sub

    Private Sub DGV_Pacientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Pacientes.CellMouseClick
        Dim fila As Integer

        Limpiar()
        Try
            fila = DGV_Pacientes.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Paciente.Text = DGV_Pacientes.Rows(fila).Cells(0).Value

            CargaDataProcedure("EXECUTE sp_Consultar_Diagnostico_Clinico", tb_ID_Paciente.Text, "Diag_Clinico", DGV_DiagClinico)

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
            tb_NumDiag.Text = DGV_DiagClinico.Rows(fila).Cells(1).Value
            tb_Enfermedad.Text = DGV_DiagClinico.Rows(fila).Cells(2).Value
            tb_AtdFamiliar.Text = DGV_DiagClinico.Rows(fila).Cells(3).Value
            tb_Alergia.Text = DGV_DiagClinico.Rows(fila).Cells(4).Value
            tb_Sintomas.Text = DGV_DiagClinico.Rows(fila).Cells(5).Value
            tb_Signos.Text = DGV_DiagClinico.Rows(fila).Cells(6).Value
            tb_MedSup.Text = DGV_DiagClinico.Rows(fila).Cells(7).Value

            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try
    End Sub
    Private Sub DGV_DiagClinico_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_DiagClinico.CellMouseClick
        Dim fila As Integer

        Try
            fila = DGV_DiagClinico.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_NumDiag.Text = DGV_DiagClinico.Rows(fila).Cells(1).Value
            tb_Enfermedad.Text = DGV_DiagClinico.Rows(fila).Cells(2).Value
            tb_AtdFamiliar.Text = DGV_DiagClinico.Rows(fila).Cells(3).Value
            tb_Alergia.Text = DGV_DiagClinico.Rows(fila).Cells(4).Value
            tb_Sintomas.Text = DGV_DiagClinico.Rows(fila).Cells(5).Value
            tb_Signos.Text = DGV_DiagClinico.Rows(fila).Cells(6).Value
            tb_MedSup.Text = DGV_DiagClinico.Rows(fila).Cells(7).Value

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
            RegistrarDiagClinico()
            CargaDataProcedure("EXECUTE sp_Consultar_Diagnostico_Clinico", tb_ID_Paciente.Text, "Diag_Clinico", DGV_DiagClinico)
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarDiagClinico()
            CargaDataProcedure("EXECUTE sp_Consultar_Diagnostico_Clinico", tb_ID_Paciente.Text, "Diag_Clinico", DGV_DiagClinico)

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarDiagClinico(tb_ID_Paciente.Text)
            CargaDataProcedure("EXECUTE sp_Consultar_Diagnostico_Clinico", tb_ID_Paciente.Text, "Diag_Clinico", DGV_DiagClinico)
            btAgregar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Limpiar()
        CargaDataProcedure("EXECUTE sp_Consultar_Diagnostico_Clinico", tb_ID_Paciente.Text, "Diag_Clinico", DGV_DiagClinico)
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

    Private Sub frm_DiagClinico_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub

    Private Sub tb_NumDiag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_NumDiag.KeyPress
        SoloNumeros(e)
    End Sub
End Class