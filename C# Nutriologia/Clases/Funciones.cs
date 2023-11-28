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
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace C__Nutriologia.Clases
{
    public class Funciones: ConexionBD
    {
        public static int ActiveUser = new int();
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader dr;
        public static string query;
        public static int numID;

        public static void GenerarNumID(TextBox textbox, DataTable Tabla)
        {
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            numID = -1;
            try
            {
                query = "SELECT * FROM " + Tabla;
                cmd.CommandText = query;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error en la consulta");
            }

            try
            {
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                        // Obtener el numero del ID del ultimo registro
                        numID = (int)Conversion.Val(dr[0].ToString());
                }

                dr.Close();

                if ((numID <= 0))
                    numID = 1;
                else
                    numID = numID + 1;

                textbox.Text = numID.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        // Funcion para mostrar una tabla en un dataGridView
        public static void CargaDatos(DataTable Tabla, DataGrid DataGridView)
        {
            SqlDataAdapter oda = new SqlDataAdapter();
            DataSet ods = new DataSet();
            string datos;
            datos = "";

            if (Strings.Len(datos) == 0)
            {
                query = "SELECT * FROM " + Tabla;
                oda = new SqlDataAdapter(query, conn);  // Ejecutar la query (consulta) en la BD a la que apunta conn
                ods.Tables.Add(Tabla);         // Generar tabla en memoria
                oda.Fill(ods.Tables(Tabla));   // Poblar tabla
                DataGridView.DataSource = ods.Tables(Tabla);
                DataGridView.Visible = true;
            }
        }

        public static void CargaDataProcedure(object Instruccion, object NumID, object Tabla, object DataGridView)
        {
            SqlDataAdapter oda = new SqlDataAdapter();
            DataSet ods = new DataSet();
            string datos;
            datos = "";

            if (Strings.Len(datos) == 0)
            {
                query = Instruccion + " " + NumID;
                oda = new SqlDataAdapter(query, conn);  // Ejecutar la query (consulta) en la BD a la que apunta conn
                ods.Tables.Add(Tabla);         // Generar tabla en memoria
                oda.Fill(ods.Tables(Tabla));   // Poblar tabla
                DataGridView.DataSource = ods.Tables(Tabla);
                DataGridView.Visible = true;
            }
        }

        public static void IdentificarUsuario(object DataGridView, object Nombre)
        {
            try
            {
                query = "SELECT * FROM Usuario WHERE Nombre = '" + Nombre + "'";
                SqlDataAdapter oda = new SqlDataAdapter();
                DataSet ods = new DataSet();
                oda = new SqlDataAdapter(query, conn);  // Ejecutar la query (consulta) en la BD a la que apunta conn
                ods.Tables.Add("Usuario");         // Generar tabla en memoria
                oda.Fill(ods.Tables("Usuario"));   // Poblar tabla
                DataGridView.DataSource = ods.Tables("Usuario");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
