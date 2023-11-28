Imports System.Data.SqlClient
Public Class frm_CategoriasFisicas

    Private Sub RegistrarCategoriaFisica()
        Dim ID_Categoria As String
        Dim Nombre As String

        ID_Categoria = tb_ID_Categoria.Text
        Nombre = tbNombre.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_RegistrarC_Fisica " & ID_Categoria & ", '" & Nombre & "', "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub ActualizarCategoriaFisica()
        Dim ID_Categoria As String
        Dim Nombre As String

        ID_Categoria = tb_ID_Categoria.Text
        Nombre = tbNombre.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarC_Fisica " & ID_Categoria & ", '" & Nombre & "', "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarCategoria(numID As Integer)
        Dim ID_Categoria As String

        ID_Categoria = numID


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarC_Fisica "
        query = query & ID_Categoria

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al eliminar registros...revisar información")
        End Try
    End Sub

    Private Sub Limpiar()
        GenerarNumID(tb_ID_Categoria, "CategoriaFisica")

        tbNombre.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
    End Sub

    Private Sub frm_CategoriasFisicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas)
        Limpiar()
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Try
            RegistrarCategoriaFisica()
            CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas)
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarCategoriaFisica()
            CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas)

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarCategoria(tb_ID_Categoria.Text)
            CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas)
            btAgregar.Enabled = True
            btEliminar.Enabled = False
            btModificar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Limpiar()
        CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas)
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

    Private Sub frm_CategoriasFisicas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub

    Private Sub DGV_CategoriasFisicas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_CategoriasFisicas.CellMouseClick
        Dim fila As Integer

        Try
            fila = DGV_CategoriasFisicas.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Categoria.Text = DGV_CategoriasFisicas.Rows(fila).Cells(0).Value
            tbNombre.Text = DGV_CategoriasFisicas.Rows(fila).Cells(1).Value

            btAgregar.Enabled = False
            btModificar.Enabled = True
            btEliminar.Enabled = True
        Catch ex As Exception
            btAgregar.Enabled = False
            btModificar.Enabled = True
            btEliminar.Enabled = True
        End Try
    End Sub
End Class