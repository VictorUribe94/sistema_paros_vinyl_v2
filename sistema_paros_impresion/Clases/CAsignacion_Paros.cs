using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using sistema_paros_vinyl.Clases;
using static sistema_paros_vinyl.Clases.DatosGlobales;

namespace sistema_paros_vinyl.Clases
{
    internal class CAsignacion_Paros
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

        public List<String> mostrarParosAsignados(int categoria)
        {
            List<String> paros = new List<String>();
            CConexion ObjConexion = new CConexion();
            int catLim = categoria + 99;
            String query = "Select nombre_paro from asignacion_paros_vinyl where id_paro BETWEEN  " + categoria + " AND " + catLim + ";";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, ObjConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        string addParo = dtR["nombre_paro"].ToString();
                        paros.Add(addParo);
                    }
                }
                else
                {
                    errorReport("No se encontro registro de paros");
                }
                ObjConexion.cerrarConexion();
                errorBD = false;

            }
            catch (Exception e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }
            return paros;
        }

        public String mostrarParoAsignado(string paro)
        {
            String numParo = "";
            CConexion ObjConexion = new CConexion();
            String query = "Select id_paro from asignacion_paros_vinyl where nombre_paro = '" + paro + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, ObjConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        numParo = dtR["id_paro"].ToString();
                    }
                }
                else
                {
                    errorReport("No se encontro registro de paros");
                }
                ObjConexion.cerrarConexion();
                errorBD = false;

            }
            catch (Exception e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }
            return numParo;
        }

        bool errorBD = false;
    }
}
