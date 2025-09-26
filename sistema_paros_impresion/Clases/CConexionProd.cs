using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static sistema_paros_vinyl.Clases.DatosGlobales;

namespace sistema_paros_vinyl.Clases
{
    internal class CConexionProd
    {
        SqlConnection conex = new SqlConnection();

        static string servidor = "GUADSSQL01";
        static string bd = "TCMXMfgCtrl";
        static string usuario = "User";
        static string password = "Password";
        static string puerto = "1433";

        string cadena_conexion = "server=" + servidor + ";" + "user id=" + usuario + ";" + "password=" + password + ";" +
            "database=" + bd + ";";

        public void errorReport(String error)
        {
            if (!limpiarError)
            {
                limpiarError = true;
                DialogResult result = MessageBox.Show(error, "Aviso", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    limpiarError = false;
                else
                    limpiarError = false;
            }


        }

        public SqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadena_conexion;
                conex.Open();
            }
            catch (SqlException e)
            {
                errorReport("No se pudo conectar a la base de datos\nerror:" + e.ToString());
            }

            return conex;
        }

        public SqlConnection cerrarConexion()
        {
            conex.Close();
            return conex;
        }
    }
}
