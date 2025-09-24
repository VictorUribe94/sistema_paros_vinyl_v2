using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using static sistema_paros_vinyl.Clases.DatosGlobales;

namespace sistema_paros_vinyl.Clases
{
    internal class CProduccion
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
        public List<String> obtenerProduccionHoras(String numMaquina, String turno, String fecha, int formato)
        {
            String buenos = "", malos = "", total = "", hora = "";
            List<String> strConfirm = new List<string>();
            CConexion objConexion = new CConexion();
            string query = "select * from produccion_vinyl where maquina ='" + numMaquina + "' and fecha='" + fecha + "' and turno='" + turno + "' and tipo_formato= '" + formato + "';";
            try
            {
                
               SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        hora = dtR["hora"].ToString();
                        buenos = dtR["buenos"].ToString();
                        malos = dtR["malos"].ToString();
                        total = Convert.ToString(Convert.ToDouble(buenos) + Convert.ToDouble(malos));
                        strConfirm.Add(hora + "," +total);
                    }

                }


                objConexion.cerrarConexion();
                errorBD = false;
            }
            catch (SqlException e)
            {
                if (!errorBD)
                   errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }

            return strConfirm;
        }
        public int mostrarProduccion(String numMaquina, String turno, String fecha)
        {
            String buenos = "";
            int produccion = 0;
            CConexion objConexion = new CConexion();
            string query = "select * from produccion_vinyl where maquina ='" + numMaquina + "' and fecha='" + fecha + "' and turno='" + turno + "' and tipo_formato= '2';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        buenos = dtR["buenos"].ToString();
                        produccion = produccion + Convert.ToInt16(buenos);
                    }

                }


                objConexion.cerrarConexion();
            }
            catch (SqlException e)
            {
                errorReport("No se pudo establecer conexion con la base de datos!");
            }

            return produccion;
        }

        public int mostrarProduccionConfirm(String numMaquina, String turno, String fecha)
        {
            string confirm;
            int produccion = 0;
            CConexionProd objConexion = new CConexionProd();
            string query = "select * from MLDConfirmation where intMLDMachineLink ='" + numMaquina + "' and dtmProductionDate='" + fecha + "' and chrShift='" + turno + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        confirm = dtR["intDiscsQty"].ToString();
                        produccion = produccion + Convert.ToInt16(confirm);
                    }

                }


                objConexion.cerrarConexion();
                errorBD = false;
            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }

            return produccion;
        }

        public bool boolProduccionConfirm(String numMaquina, String turno, String fecha)
        {
            bool confirm = false;
            CConexionProd objConexion = new CConexionProd();
            string query = "select * from MLDConfirmation where intMLDMachineLink ='" + numMaquina + "' and dtmProductionDate='" + fecha + "' and chrShift='" + turno + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    confirm = true;

                }


                objConexion.cerrarConexion();
                errorBD = false;
            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }

            return confirm;
        }


        public int mostrarProduccionConfirmEmp_Pre(String numMaquina, String turno, String fecha, int formato)
        {
            string confirm;
            int produccion = 0;
            CConexion objConexion = new CConexion();
            string query = "select * from produccion_vinyl where maquina ='" + numMaquina + "' and fecha='" + fecha + "' and turno='" + turno + "' and tipo_formato='" + formato + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        confirm = dtR["buenos"].ToString();
                        produccion = produccion + Convert.ToInt16(confirm);
                    }

                }


                objConexion.cerrarConexion();
                errorBD = false;
            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }

            return produccion;
        }

        public List<int> revisarDatoProd(String numMaquina, String turno, String fecha, String hora)
        {
            List<int> tiposFormatos = new List<int>();
            tiposFormatos.Add(0);
            CConexion objConexion = new CConexion();
            string query = "select * from produccion_vinyl where maquina ='" + numMaquina + "' and fecha='" + fecha + "' and turno='" + turno + "' and hora='" + hora + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        tiposFormatos.Add(Convert.ToInt16(dtR["tipo_formato"].ToString()));
                    }

                }


                objConexion.cerrarConexion();
                errorBD = false;
            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }

            return tiposFormatos;
        }


        public List<String> mostrarProduccion(String numMaquina, String turno, String fecha, int formato)
        {
            String buenos = "", malos = "", total = "", hora = "";
            List<String> strConfirm = new List<string>();
            CConexion objConexion = new CConexion();
            string query = "select * from produccion_vinyl where maquina ='" + numMaquina + "' and fecha='" + fecha + "' and turno='" + turno + "' and tipo_formato= '" + formato + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        hora = dtR["hora"].ToString();
                        buenos = dtR["buenos"].ToString();
                        malos = dtR["malos"].ToString();
                        total = buenos + "," + malos + "," + hora;
                        strConfirm.Add(total);
                    }

                }


                objConexion.cerrarConexion();
                errorBD = false;
            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }

            return strConfirm;
        }

        public double mostrarCiclo(String numMaquina, String turno, String fecha)
        {
            String strCiclo = "";
            double ciclo = 0;
            CConexion objConexion = new CConexion();
            string query = "select * from produccion_vinyl where maquina ='" + numMaquina + "' and fecha='" + fecha + "' and turno='" + turno + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        strCiclo = dtR["ciclo"].ToString();                        
                        if(strCiclo != null && strCiclo!="0" && strCiclo != "")
                        ciclo = Convert.ToDouble(strCiclo);
                    }

                }


                objConexion.cerrarConexion();
                errorBD = false;
            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }

            return ciclo;
        }
        public void insertarProduccion(String turno, String fecha, String hora, String numMaquina, String buenos, String malos, String yield, String rechazo, String tipoFormato, String orden, String po, String grupo, String registro, String nombre, String ciclo, String labelA, String labelB)
        {

            try
            {
                CConexion objConexion = new CConexion();
                string query = "insert into produccion_vinyl (turno,fecha,hora,maquina,buenos,malos,yield,rechazo,tipo_formato,orden,po,grupo,registro,nombre, ciclo, labelA, labelB)" +
                    "values ('" + turno + "','" + fecha + "','" + hora + "','" + numMaquina + "','" + buenos + "','" + malos + "','" + yield + "','" + rechazo + "','" + tipoFormato + "','" + orden + "','" + po + "','" + grupo + "','" + registro + "','" + nombre + "','" + ciclo + "','" + labelA + "','" + labelB + "');";

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

        public void modificarProduccion(String turno, String fecha, String hora, String numMaquina, String buenos, String malos, String yield, String rechazo, String tipoFormato, String orden, String po, String grupo, String registro, String nombre, String ciclo, String labelA, String labelB)
        {

            try
            {
                CConexion objConexion = new CConexion();
                string query = "update produccion_vinyl set buenos='" + buenos + "' ,malos='" + malos + "' ,yield='" + yield + "',rechazo='" + rechazo + "',orden='" + orden + "',po='" + po + "',grupo='" + grupo + "',registro='" + registro + "',nombre='" + nombre + "',ciclo='" + ciclo + "',labelA='" + labelA + "',labelB='" + labelB +
                "' where turno='" + turno + "' and fecha='" + fecha + "'and hora='" + hora + "'and maquina='" + numMaquina + "'and tipo_formato='" + tipoFormato + "';";

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
                    errorReport("No se pudo actualizar!\nError: " + e.ToString());
                errorBD = true;
            }
        }

        public bool boolProduccion(String numMaquina, String fecha, String turno, String hora, String tipoFormato)
        {
            bool retorno = false;
            CConexion objConexion = new CConexion();
            string query = "select * from produccion_vinyl where maquina ='" + numMaquina + "' and fecha='" + fecha + "' and turno='" + turno + "' and hora='" + hora + "' and tipo_formato= '"+ tipoFormato +"';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }


                objConexion.cerrarConexion();
                errorBD = false;
            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }

            return retorno;
        }

        public String currentOrder(String numeroMaquina)
        {
            String strCurrentOrder = "";
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            String query1, query2;
            String machineKey;
            CConexion objConexion = new CConexion();
            CConexionProd objConexionProd = new CConexionProd();
            query1 = "select * from asignacion_maquinas_vinyl where numero_maquina = '" + numeroMaquina + "';";
            try
            {
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, objConexion.establecerConexion());
                adapter1.Fill(dt1);
                objConexion.cerrarConexion();
                
                foreach (DataRow dtr1 in dt1.Rows)
                {
                    machineKey = dtr1["intMLDMachineKey"].ToString();
                    query2 = "select * from MLDCurrentOrder where intMLDMachineLink ='" + machineKey + "';";
                    SqlDataAdapter adapter2 = new SqlDataAdapter(query2, objConexionProd.establecerConexion());
                    adapter2.Fill(dt2);
                    objConexionProd.cerrarConexion();

                    foreach (DataRow dtr2 in dt2.Rows)
                    {
                        strCurrentOrder = dtr2["bintSalesOrder"].ToString();       
                    }
                    errorBD = false;
                }
            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }


            return strCurrentOrder;

        }


        bool errorBD = false;
    }
}
