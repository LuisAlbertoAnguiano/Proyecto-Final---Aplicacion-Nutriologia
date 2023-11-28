Public Class frm_Dietas

    Private Sub RegistrarDieta()
        Dim ID_Dieta As String
        Dim Nombre As String

        ID_Dieta = tb_ID_Dieta.Text
        Nombre = tbNombre.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_RegistrarDieta " & ID_Dieta & ", '" & Nombre & "', "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub ActualizarDieta()
        Dim ID_Dieta As String
        Dim Nombre As String

        ID_Dieta = tb_ID_Dieta.Text
        Nombre = tbNombre.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarDieta " & ID_Dieta & ", '" & Nombre & "', "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarDieta(numID As Integer)
        Dim ID_Sistema As String

        ID_Sistema = numID


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarDieta "
        query = query & ID_Sistema

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al eliminar registros...revisar información")
        End Try
    End Sub

    Private Sub Limpiar()
        GenerarNumID(tb_ID_Dieta, "Dietas")
        CargaDatos("View_MostrarDietas", DGV_Dietas)

        tbNombre.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
    End Sub
    Private Sub frm_Dietas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        Limpiar()
    End Sub

    Private Sub DGV_Dietas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Dietas.CellMouseClick
        Dim fila As Integer

        Try
            fila = DGV_Dietas.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Dieta.Text = DGV_Dietas.Rows(fila).Cells(0).Value
            tbNombre.Text = DGV_Dietas.Rows(fila).Cells(1).Value

            btAgregar.Enabled = False
            btModificar.Enabled = True
            btEliminar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = False
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Try
            RegistrarDieta()
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarDieta()
            CargaDatos("View_MostrarDietas", DGV_Dietas)

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarDieta(tb_ID_Dieta.Text)
            CargaDatos("View_MostrarDietas", DGV_Dietas)
            btAgregar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Limpiar()
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

    Private Sub frm_Dietas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub
End Class