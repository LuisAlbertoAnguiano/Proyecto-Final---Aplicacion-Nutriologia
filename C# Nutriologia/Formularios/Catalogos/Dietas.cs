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
    public partial class Dietas : Form
    {
        public Dietas()
        {
            InitializeComponent();
        }

        private void RegistrarDieta()
        {
            string ID_Dieta;
            string Nombre;

            ID_Dieta = tb_ID_Dieta.Text;
            Nombre = tbNombre.Text;

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            query = "EXECUTE sp_RegistrarDieta " + ID_Dieta + ", '" + Nombre + "', ";
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

        private void ActualizarDieta()
        {
            string ID_Dieta;
            string Nombre;

            ID_Dieta = tb_ID_Dieta.Text;
            Nombre = tbNombre.Text;

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            query = "EXECUTE sp_ActualizarDieta " + ID_Dieta + ", '" + Nombre + "', ";
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

        private void EliminarDieta(int numID)
        {
            string ID_Sistema;

            ID_Sistema = numID;


            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            query = "EXECUTE sp_EliminarDieta ";
            query = query + ID_Sistema;

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
            GenerarNumID(tb_ID_Dieta, "Dietas");
            CargaDatos("View_MostrarDietas", DGV_Dietas);

            tbNombre.Text = "";

            btAgregar.Enabled = true;
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
        }
        private void Dietas_Load(object sender, EventArgs e)
        {
            conexion();
            Limpiar();
        }
        private void DGV_Dietas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;

            try
            {
                fila = DGV_Dietas.CurrentRow.Index;   // Regresa el renglon donde se dio el dobleclick
                tb_ID_Dieta.Text = DGV_Dietas.Rows(fila).Cells(0).Value;
                tbNombre.Text = DGV_Dietas.Rows(fila).Cells(1).Value;

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

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistrarDieta();
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
                ActualizarDieta();
                CargaDatos("View_MostrarDietas", DGV_Dietas);
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
                EliminarDieta(tb_ID_Dieta.Text);
                CargaDatos("View_MostrarDietas", DGV_Dietas);
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

        private void frm_Dietas_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
