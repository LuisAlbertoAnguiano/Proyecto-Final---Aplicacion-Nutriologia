Imports System.Data.SqlClient
Public Class MainMenu

    Private Sub OcultarMostrarMenu(Panel)
        If Panel.Visible = True Then
            Panel.Visible = False
        Else
            Panel.Visible = True
        End If
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        OcultarMostrarMenu(PanelSubMenuCatalogo)
    End Sub

    Private Sub bt_Consultar_Click(sender As Object, e As EventArgs) Handles bt_Consultar.Click
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
    End Sub

    Private Sub bt_Pacientes_Click(sender As Object, e As EventArgs) Handles bt_Pacientes.Click
        conn.Close()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        frm_Pacientes.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Catalogos_Click(sender As Object, e As EventArgs) Handles bt_Catalogos.Click
        OcultarMostrarMenu(PanelSubMenuCatalogo)
    End Sub

    Private Sub bt_CategoriasFisicas_Click(sender As Object, e As EventArgs) Handles bt_CategoriasFisicas.Click
        conn.Close()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        frm_CategoriasFisicas.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Dietas_Click(sender As Object, e As EventArgs) Handles bt_Dietas.Click
        conn.Close()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        frm_Dietas.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Sistemas_Click(sender As Object, e As EventArgs) Handles bt_Sistemas.Click
        conn.Close()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        frm_Sistemas.Show()
        Me.Hide()
    End Sub

    Private Sub bt_ActFisica_Click(sender As Object, e As EventArgs) Handles bt_ActFisica.Click
        conn.Close()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        frm_ActFisica.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Citas_Click(sender As Object, e As EventArgs) Handles bt_Citas.Click
        conn.Close()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        frm_Citas.Show()
        Me.Hide()
    End Sub

    Private Sub bt_DiagClinico_Click(sender As Object, e As EventArgs) Handles bt_DiagClinico.Click
        conn.Close()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        frm_DiagClinico.Show()
        Me.Hide()
    End Sub

    Private Sub bt_DietasPaciente_Click(sender As Object, e As EventArgs) Handles bt_DietasPaciente.Click
        conn.Close()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        frm_DietasPaciente.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Alimentos_Click(sender As Object, e As EventArgs) Handles bt_Alimentos.Click
        conn.Close()
        OcultarMostrarMenu(PanelSubMenuCatalogo)
        frm_Alimentos.Show()
        Me.Hide()
    End Sub

    Private Sub bt_FrecAlimentaria_Click(sender As Object, e As EventArgs) Handles bt_FrecAlimentaria.Click
        conn.Close()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        frm_FrecAlimentaria.Show()
        Me.Hide()
    End Sub

    Private Sub bt_Revision_Click(sender As Object, e As EventArgs) Handles bt_Revision.Click
        conn.Close()
        OcultarMostrarMenu(Panel_ConsultarSubMenu)
        frm_Revision.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        conn.Close()
        Login.Show()
    End Sub
End Class
