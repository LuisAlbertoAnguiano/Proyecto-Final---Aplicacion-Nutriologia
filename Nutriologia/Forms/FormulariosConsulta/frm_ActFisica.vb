Public Class frm_ActFisica

    Private Sub RegistrarActFisica()
        Dim ID_Paciente As String
        Dim ID_Categoria As String
        Dim Descripcion As String
        Dim Frecuencia As String

        ID_Paciente = tb_ID_Paciente.Text
        ID_Categoria = tb_ID_Categoria.Text
        Descripcion = tb_Descripcion.Text
        Frecuencia = tb_Frecuencia.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_RegistrarAct_Fisica " & ID_Paciente & ", " & ID_Categoria & ", '" & Descripcion & "', '" & Frecuencia & "', "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub ActualizarActFisica()
        Dim ID_Paciente As String
        Dim ID_Categoria As String
        Dim Descripcion As String
        Dim Frecuencia As String

        ID_Paciente = tb_ID_Paciente.Text
        ID_Categoria = tb_ID_Categoria.Text
        Descripcion = tb_Descripcion.Text
        Frecuencia = tb_Frecuencia.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarAct_Fisica " & ID_Paciente & ", " & ID_Categoria & ", '" & Descripcion & "', '" & Frecuencia & "', "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarActFisica(numID As Integer)
        Dim ID_Paciente As String

        ID_Paciente = numID


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarAct_Fisica "
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
        tb_ID_Categoria.Text = ""
        tb_Descripcion.Text = ""
        tb_Frecuencia.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
    End Sub
    Private Sub frm_ActFisica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        CargaDatos("View_MostrarPacientes", DGV_Pacientes)
        CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas)
        CargaDataProcedure("EXECUTE sp_Consultar_Actividad_Fisica", numID, "Act_Fisica", DGV_ActFisica)
    End Sub

    Private Sub DGV_CategoriasFisicas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_CategoriasFisicas.CellMouseClick
        Dim fila As Integer

        Limpiar()
        Try
            fila = DGV_CategoriasFisicas.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Categoria.Text = DGV_CategoriasFisicas.Rows(fila).Cells(0).Value

            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try
    End Sub

    Private Sub DGV_ActFisica_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_ActFisica.CellMouseClick
        Dim fila As Integer

        Try
            fila = DGV_ActFisica.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Categoria.Text = DGV_ActFisica.Rows(fila).Cells(1).Value
            tb_Descripcion.Text = DGV_ActFisica.Rows(fila).Cells(3).Value
            tb_Frecuencia.Text = DGV_ActFisica.Rows(fila).Cells(4).Value

            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = True
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try
    End Sub

    Private Sub DGV_Pacientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Pacientes.CellMouseClick
        Dim fila As Integer

        Limpiar()
        Try
            fila = DGV_Pacientes.CurrentRow.Index
            tb_ID_Paciente.Text = DGV_Pacientes.Rows(fila).Cells(0).Value

            CargaDataProcedure("EXECUTE sp_Consultar_Actividad_Fisica", tb_ID_Paciente.Text, "Act_Fisica", DGV_ActFisica)

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
            tb_ID_Categoria.Text = DGV_ActFisica.Rows(fila).Cells(1).Value
            tb_Descripcion.Text = DGV_ActFisica.Rows(fila).Cells(3).Value
            tb_Frecuencia.Text = DGV_ActFisica.Rows(fila).Cells(4).Value

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
            RegistrarActFisica()
            CargaDataProcedure("EXECUTE sp_Consultar_Actividad_Fisica", tb_ID_Paciente.Text, "Act_Fisica", DGV_ActFisica)
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarActFisica()
            CargaDataProcedure("EXECUTE sp_Consultar_Actividad_Fisica", numID, "Act_Fisica", DGV_ActFisica)

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarActFisica(tb_ID_Paciente.Text)
            CargaDataProcedure("EXECUTE sp_Consultar_Actividad_Fisica", numID, "Act_Fisica", DGV_ActFisica)
            btAgregar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Limpiar()
        CargaDataProcedure("EXECUTE sp_Consultar_Actividad_Fisica", numID, "Act_Fisica", DGV_ActFisica)
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

    Private Sub frm_ActFisica_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub
End Class