﻿Public Class frm_Sistemas

    Private Sub RegistrarSistema()
        Dim ID_Sistema As String
        Dim Nombre As String

        ID_Sistema = tb_ID_Sistema.Text
        Nombre = tbNombre.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_RegistrarSistema " & ID_Sistema & ", '" & Nombre & "', "
        query = query & ActiveUser.ToString() & ", " & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub ActualizarSistema()
        Dim ID_Sistema As String
        Dim Nombre As String

        ID_Sistema = tb_ID_Sistema.Text
        Nombre = tbNombre.Text

        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_ActualizarSistema " & ID_Sistema & ", '" & Nombre & "', "
        query = query & ActiveUser.ToString()

        cmd.CommandText = query

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Error al insertar registros...revisar información")
        End Try
    End Sub

    Private Sub EliminarSistema(numID As Integer)
        Dim ID_Sistema As String

        ID_Sistema = numID


        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        query = "EXECUTE sp_EliminarSistema "
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
        GenerarNumID(tb_ID_Sistema, "Sistemas")
        CargaDatos("View_MostrarSistemas", DGV_Sistemas)
        tbNombre.Text = ""

        btAgregar.Enabled = True
        btModificar.Enabled = False
        btEliminar.Enabled = False
    End Sub

    Private Sub frm_Sistemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        Limpiar()
    End Sub

    Private Sub DGV_Sistemas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Sistemas.CellContentClick
        Dim fila As Integer

        Try
            fila = DGV_Sistemas.CurrentRow.Index   'Regresa el renglon donde se dio el dobleclick
            tb_ID_Sistema.Text = DGV_Sistemas.Rows(fila).Cells(0).Value
            tbNombre.Text = DGV_Sistemas.Rows(fila).Cells(1).Value

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
            RegistrarSistema()
            Limpiar()

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Try
            ActualizarSistema()
            CargaDatos("View_MostrarSistemas", DGV_Sistemas)

        Catch ex As Exception
            MsgBox("Error en los datos")
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Try
            EliminarSistema(tb_ID_Sistema.Text)
            CargaDatos("View_MostrarSistemas", DGV_Sistemas)
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

    Private Sub frm_Sistemas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            conn.Close()
            MainMenu.Show()
        Catch ex As Exception
            conn.Close()
            MainMenu.Show()
        End Try
    End Sub

End Class