Public Class frm_Alimentos

    Private Sub RegistrarAlimento()
        Dim ID As String
        Dim Nombre As String

        ID = tb_ID_Alimento.Text
        Nombre = tb_Nombre.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_RegistrarAlimento " & ID & ", '" & Nombre & "', "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub ActualizarAlimento()
        Dim ID As String
        Dim Nombre As String

        ID = tb_ID_Alimento.Text
        Nombre = tb_Nombre.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarAlimento " & ID & ", '" & Nombre & "', "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarAlimento(numID As Integer)
        Dim ID As String

        ID = numID

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarAlimento "
        query = query & ID

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al eliminar registros...revisar información")
        End Try
    End Sub

    Private Sub Limpiar()
        GenerarNumID(tb_ID_Alimento, "Alimentos")
        CargaDatos("View_MostrarAlimentos", DGV_Alimentos)

        tb_Nombre.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
    End Sub
    Private Sub frm_Alimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        Limpiar()
    End Sub

    Private Sub DGV_Alimentos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_Alimentos.CellMouseClick
        Dim fila As Integer

        Try
            fila = DGV_Alimentos.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Alimento.Text = DGV_Alimentos.Rows(fila).Cells(0).Value
            tb_Nombre.Text = DGV_Alimentos.Rows(fila).Cells(1).Value
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
            RegistrarAlimento()
            CargaDatos("View_MostrarAlimentos", DGV_Alimentos)
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarAlimento()
            CargaDatos("View_MostrarAlimentos", DGV_Alimentos)

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarAlimento(tb_ID_Alimento.Text)
            CargaDatos("View_MostrarAlimentos", DGV_Alimentos)
            btAgregar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Limpiar()
        CargaDatos("View_MostrarAlimentos", DGV_Alimentos)
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

    Private Sub frm_Alimentos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub

    Private Sub tb_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Nombre.KeyPress
        SoloLetras(e)
    End Sub
End Class