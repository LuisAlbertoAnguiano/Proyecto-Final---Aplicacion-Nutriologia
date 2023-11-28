using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace C__Nutriologia.Formularios.Catalogos
{
    public partial class CategoriasFisicas : Form
    {
        public CategoriasFisicas()
        {
            InitializeComponent();
        }
        private void RegistrarCategoriaFisica()
        {
            string ID_Categoria;
            string Nombre;

            ID_Categoria = tb_ID_Categoria.Text;
            Nombre = tbNombre.Text;

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            query = "EXECUTE sp_RegistrarC_Fisica " + ID_Categoria + ", '" + Nombre + "', ";
            query = query + ActiveUser.ToString() + ", " + ActiveUser.ToString();

            cmd.CommandText = query;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
                Interaction.MsgBox("Error al insertar registros...revisar información");
            }
        }

        private void ActualizarCategoriaFisica()
        {
            string ID_Categoria;
            string Nombre;

            ID_Categoria = tb_ID_Categoria.Text;
            Nombre = tbNombre.Text;

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            query = "EXECUTE sp_ActualizarC_Fisica " + ID_Categoria + ", '" + Nombre + "', ";
            query = query + ActiveUser.ToString();

            cmd.CommandText = query;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
                Interaction.MsgBox("Error al insertar registros...revisar información");
            }
        }

        private void EliminarCategoria(int numID)
        {
            string ID_Categoria;

            ID_Categoria = numID;


            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            query = "EXECUTE sp_EliminarC_Fisica ";
            query = query + ID_Categoria;

            cmd.CommandText = query;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
                Interaction.MsgBox("Error al eliminar registros...revisar información");
            }
        }

        private void Limpiar()
        {
            GenerarNumID(tb_ID_Categoria, "CategoriaFisica");

            tbNombre.Text = "";

            btAgregar.Enabled = true;
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
        }
        private void CategoriasFisicas_Load(object sender, EventArgs e)
        {
            conexion();
            CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas);
            Limpiar();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistrarCategoriaFisica();
                CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas);
                Limpiar();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error en los datos");
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarCategoriaFisica();
                CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error en los datos");
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarCategoria(tb_ID_Categoria.Text);
                CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas);
                btAgregar.Enabled = true;
                btEliminar.Enabled = false;
                btModificar.Enabled = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            CargaDatos("View_MostrarCategoriaFisica", DGV_CategoriasFisicas);
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                conn.Close();
                MainMenu.Show();
            }
            catch (Exception ex)
            {
                Close();
                conn.Close();
                MainMenu.Show();
            }
        }

        private void frm_CategoriasFisicas_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                conn.Close();
                MainMenu.Show();
            }
            catch (Exception ex)
            {
                conn.Close();
                MainMenu.Show();
            }
        }

        private void DGV_CategoriasFisicas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;

            try
            {
                fila = DGV_CategoriasFisicas.CurrentRow.Index;   // Regresa el renglon donde se dio el dobleclick
                tb_ID_Categoria.Text = DGV_CategoriasFisicas.Rows(fila).Cells(0).Value;
                tbNombre.Text = DGV_CategoriasFisicas.Rows(fila).Cells(1).Value;

                btAgregar.Enabled = false;
                btModificar.Enabled = true;
                btEliminar.Enabled = true;
            }
            catch (Exception ex)
            {
                btAgregar.Enabled = false;
                btModificar.Enabled = true;
                btEliminar.Enabled = true;
            }
        }
    }
}
