using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace C__Nutriologia.Formularios.Catalogos
{
    public partial class Alimentos : Form
    {
        public Alimentos()
        {
            InitializeComponent();
        }
        private void RegistrarAlimento()
        {
            string ID;
            string Nombre;

            ID = tb_ID_Alimento.Text;
            Nombre = tb_Nombre.Text;

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            query = "EXECUTE sp_RegistrarAlimento " + ID + ", '" + Nombre + "', ";
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

        private void ActualizarAlimento()
        {
            string ID;
            string Nombre;

            ID = tb_ID_Alimento.Text;
            Nombre = tb_Nombre.Text;

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            query = "EXECUTE sp_ActualizarAlimento " + ID + ", '" + Nombre + "', ";
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

        private void EliminarAlimento(int numID)
        {
            string ID;

            ID = numID;

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            query = "EXECUTE sp_EliminarAlimento ";
            query = query + ID;

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
            GenerarNumID(tb_ID_Alimento, "Alimentos");
            CargaDatos("View_MostrarAlimentos", DGV_Alimentos);

            tb_Nombre.Text = "";

            btAgregar.Enabled = true;
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
        }
        private void Alimentos_Load(object sender, EventArgs e)
        {
            conexion();
            Limpiar();
        }

        private void DGV_Alimentos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila;

            try
            {
                fila = DGV_Alimentos.CurrentRow.Index;   // Regresa el renglon donde se dio el dobleclick
                tb_ID_Alimento.Text = DGV_Alimentos.Rows(fila).Cells(0).Value;
                tb_Nombre.Text = DGV_Alimentos.Rows(fila).Cells(1).Value;
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
                RegistrarAlimento();
                CargaDatos("View_MostrarAlimentos", DGV_Alimentos);
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
                ActualizarAlimento();
                CargaDatos("View_MostrarAlimentos", DGV_Alimentos);
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
                EliminarAlimento(tb_ID_Alimento.Text);
                CargaDatos("View_MostrarAlimentos", DGV_Alimentos);
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
            CargaDatos("View_MostrarAlimentos", DGV_Alimentos);
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

        private void frm_Alimentos_FormClosed(object sender, FormClosedEventArgs e)
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

        private void tb_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
    }
}
