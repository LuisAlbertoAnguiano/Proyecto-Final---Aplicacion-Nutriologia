using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;

namespace C__Nutriologia
{
    public class ConexionBD
    {
        public static SqlConnection conn = new SqlConnection();

        public static void conexion()
        {
            try
            {
                conn.ConnectionString = @"Data Source = ASREN-PC\SQLSERVER; Initial Catalog = BD_Nutriologo; 
            Integrated Security = True";

                conn.Open();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("No se conecto a la base de datos...", Constants.vbInformation, ex.Message);
            }
        }
}
