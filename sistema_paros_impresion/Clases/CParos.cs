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
    class CParos
    {
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
        public void insertarParo(String numeroMaquina, String fecha, String turno, String tipoParo, String tiempoParo)
        {

            try
            {
                CConexion objConexion = new CConexion();
                String[] fechaSQL = fecha.Split(' ');
                string query = "insert into paros_vinyl (numero_maquina,fecha,turno,tipo_paro,tiempo_paro)" +
                    "values ('" + numeroMaquina + "','" + fechaSQL[1]+" " + fechaSQL[0] + "','" + turno + "','" + tipoParo + "','" + tiempoParo + "');";

                SqlCommand myCommand = new SqlCommand(query, objConexion.establecerConexion());
                SqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {

                }
                objConexion.cerrarConexion();
                errorBD = false;
            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("Error: " + e.ToString());
                errorBD = true;
            }
        }

        bool errorBD = false;
    }
}
