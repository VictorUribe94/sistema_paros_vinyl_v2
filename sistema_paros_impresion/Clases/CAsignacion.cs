using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using static sistema_paros_vinyl.Clases.DatosGlobales;

namespace sistema_paros_vinyl.Clases
{
    class CAsignacion
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
        public String obtenerCOM(String maquina)
        {
            String strCOM = "COM4";
            CConexion objConexion = new CConexion();
            string query = "select * from asignacion_maquinas_vinyl where numero_maquina='" + numeroMaquina + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {

                        strCOM = dtR["strPuerto"].ToString();
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

            return strCOM;
        }
        public String obtenerID(string numeroMaquina)
        {
            String IDmaquina = "";
            CConexion objConexion = new CConexion();
            string query = "select * from asignacion_maquinas_vinyl where numero_maquina='" + numeroMaquina + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {

                        IDmaquina = dtR["intMLDMachineKey"].ToString();
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
            return IDmaquina;
        }
        public void maquinaConectada(int conectada, string numeroMaquina)
        {
            try
            {
                CConexion objConexion = new CConexion();
                string query = "update asignacion_maquinas_vinyl set conexion='" +
                conectada + "' where numero_maquina='" + numeroMaquina + "';";

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
        public bool actualizarSistema(string numeroMaquina)
        {
            int numActualizacion = 0;
            CConexion objConexion = new CConexion();
            String query = "select actualizacion from asignacion_maquinas_vinyl where numero_maquina = '" + numeroMaquina + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow dtR in dt.Rows)
                    {
                        numActualizacion =Convert.ToInt16(dtR["actualizacion"].ToString());
                    }
                    
                }
                if(numActualizacion != 0 && numActualizacion != 99)
                {
                    try
                    {
                        objConexion = new CConexion();
                        query = "update asignacion_maquinas_vinyl set actualizacion = 0, version = " + numActualizacion + " where numero_maquina='" + numeroMaquina + "';";

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
                    return true;
                }

            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }
            return false;
        }

        public bool actualizarSistemaCompleto(string numeroMaquina)
        {
            int numActualizacion = 0;
            CConexion objConexion = new CConexion();
            String query = "select actualizacion from asignacion_maquinas_vinyl where numero_maquina = '" + numeroMaquina + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        numActualizacion = Convert.ToInt16(dtR["actualizacion"].ToString());
                    }

                }
                if (numActualizacion == 99)
                {
                    try
                    {
                        objConexion = new CConexion();
                        query = "update asignacion_maquinas_vinyl set actualizacion = 0 where numero_maquina='" + numeroMaquina + "';";

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
                        return false;
                    }
                    return true;
                }

            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }
            return false;
        }
        public String seleccionarMaquina(String direccionIp)
        {
            numeroMaquina = "NULL";
            CConexion objConexion = new CConexion();
            string query = "select * from asignacion_maquinas_vinyl where direccion_ip='"+direccionIp+"';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {

                        numeroMaquina = dtR["numero_maquina"].ToString();

                    }
                }
                else
                {
                    errorReport("La direccion IP no está registrada en el catalogo");
                }
                objConexion.cerrarConexion();
            }
            catch (SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = false;
            }
            return numeroMaquina;
        }

        public String retornoUltConex(String numMaquina)
        {
            String ultConex = "";
            CConexion objConexion = new CConexion();
            string query = "select * from asignacion_maquinas_vinyl where numero_maquina='" + numMaquina + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        ultConex = dtR["ult_conex"].ToString();
                    }
                }
                else
                {
                    errorReport("No se encuentran datos de conexion");
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
            return ultConex;
        }

        public String retornoConex(String numMaquina)
        {
            String conex = "";
            CConexion objConexion = new CConexion();
            string query = "select * from asignacion_maquinas_vinyl where numero_maquina='" + numMaquina + "';";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        conex = dtR["conexion"].ToString();
                    }
                }
                else
                {
                    errorReport("No se encuentran datos de conexion");
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
            return conex;
        }

        public void maquinaConectada(int conectada, string numeroMaquina, String fechaConexion)
        {
            try
            {
                CConexion objConexion = new CConexion();
                string query = "update asignacion_maquinas_vinyl set conexion='" +
                conectada + "' , ult_conex='"+fechaConexion +  "' where numero_maquina='" + numeroMaquina + "';";

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

        public void maquinaCorriendo(int run, string numeroMaquina)
        {
            try
            {
                CConexion objConexion = new CConexion();
                string query = "update asignacion_maquinas_vinyl set run='" +
                run + "' where numero_maquina='" + numeroMaquina + "';";

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

        public void mostrarAsignacion(DataGridView tablaAsignacion)
        {
            CConexion objConexion = new CConexion();
            string query = "select * from asignacion_maquinas_vinyl";
            tablaAsignacion.DataSource = null;
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAsignacion.DataSource = dt;
                objConexion.cerrarConexion();
            }
            catch (SqlException e)
            {
                errorReport("No se pudo establecer conexion con la base de datos!");
            }
        }

        public void insertarAsignacion(TextBox numeroMaquina, TextBox direccionIp)
        {

            try
            {
                CConexion objConexion = new CConexion();
                string query = "insert into asignacion_maquinas_vinyl (numero_maquina,direccion_ip)" +
                    "values ('" + numeroMaquina.Text + "','" + direccionIp.Text + "');";

                SqlCommand myCommand = new SqlCommand(query, objConexion.establecerConexion());
                SqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {

                }
                objConexion.cerrarConexion();
            }
            catch (SqlException e)
            {
                errorReport("Error: " + e.ToString());
            }
        }

        public void seleccionarAsignacion(DataGridView tabla,TextBox numeroMaquina, TextBox direccionIp)
        {

            try
            {
                numeroMaquina.Text = tabla.CurrentRow.Cells[0].Value.ToString();
                direccionIp.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            }
            catch (SqlException e)
            {
                errorReport("No se pudo seleccionar\nError: " + e.ToString());
            }
        }

        public void modificarHostname(String numeroMaquina, String hostname)
        {

            try
            {
                CConexion objConexion = new CConexion();
                string query = "update asignacion_maquinas_vinyl set hostname='" + hostname + "' where numero_maquina='" + numeroMaquina + "';";

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

        public void eliminarAsignacion(TextBox numeroMaquina)
        {

            try
            {
                CConexion objConexion = new CConexion();
                string query = "delete from asignacion_maquinas_vinyl where numero_maquina='" +
                numeroMaquina.Text + "';";

                SqlCommand myCommand = new SqlCommand(query, objConexion.establecerConexion());
                SqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {

                }
                objConexion.cerrarConexion();
            }
            catch (SqlException e)
            {
                if(!errorBD)
                    errorReport("No se pudo actualizar!\nError: " + e.ToString());
                errorBD = true;
            }
        }


        String  numeroMaquina = "";
        bool errorBD = false;
    }
}
