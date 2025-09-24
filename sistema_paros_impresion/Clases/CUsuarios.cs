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
    class CUsuarios
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
        public int buscarUsuarios(string numUsuario, string password, int tipoParo)
        {
            int retorno = 0;
            CConexion objConexion = new CConexion();
            DataColumn columna = new DataColumn();
            string query = "select * from usuarios_vinyl where nombre_usuario= '"+ numUsuario+"';";
            //tablaAsignacion.DataSource = null;
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0 )
                {
                    int i = 0;
                    foreach (DataRow dtR in dt.Rows)
                    {
                        numeroUsuario = dtR["nombre_usuario"].ToString();

                        privilegios = dtR["privilegio"].ToString();

                        passwordBd = dtR["password"].ToString();
                    }

                    switch(tipoParo)
                    {
                        case 1 :

                            if(privilegios == "Operador" || privilegios == "Supervisor" || privilegios == "Ingeniero")
                            {
                                
                            }
                            else
                            {
                                MessageBox.Show("No tienes privilegios para esta accion");
                            }
                            break;

                        case 2 :
                            if (privilegios == "Supervisor" || privilegios == "Ingeniero")
                            {
                                if(numeroUsuario == numUsuario && passwordBd == password)
                                {
                                    retorno = 1;
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o contraseña incorrectos");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No tienes privilegios para esta accion");
                            }
                            break;

                        case 3:
                            if (privilegios == "Tecnico" || privilegios == "Ingeniero")
                            {
                                if (numeroUsuario == numUsuario && passwordBd == password)
                                {
                                    retorno = 2;
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o contraseña incorrectos");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No tienes privilegios para esta accion");
                            }
                            break;

                        case 4:
                            if (privilegios == "Ingeniero")
                            {
                                if (numeroUsuario == numUsuario && passwordBd == password)
                                {
                                    retorno = 3;
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o contraseña incorrectos");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No tienes privilegios para esta accion");
                            }
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
                //tablaAsignacion.DataSource = dt;
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

        public String obtenerNombre(string numUsuario)
        {
            String nombre = "";
            string query;
            CConexionProd objConexionProd = new CConexionProd();
            DataColumn columna = new DataColumn();
            query = "select * from HRMEmployees where intRegister like '" + numUsuario + "%';";
            //tablaAsignacion.DataSource = null;
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, objConexionProd.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dtR in dt.Rows)
                    {
                        //if(dtR["intRegister"].ToString() != "32814")
                        //{
                            nombre = dtR["vchFirstName"].ToString() + " " + dtR["vchLastName1"].ToString();
                            break;
                        //}   
                    }
                }
                objConexionProd.cerrarConexion();
                errorBD = false;
            }
            catch(SqlException e)
            {
                if (!errorBD)
                    errorReport("No se pudo establecer conexion con la base de datos!");
                errorBD = true;
            }
         return nombre;
        }

        String id, numeroUsuario, privilegios, passwordBd;
        bool errorBD = false;
    }
}
