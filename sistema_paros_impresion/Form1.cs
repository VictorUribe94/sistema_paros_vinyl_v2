using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Data.SqlClient;
using sistema_paros_vinyl.Clases;
using static sistema_paros_vinyl.Clases.DatosGlobales;

namespace sistema_paros_vinyl
{

    public partial class frmPrincipal : Form
    {
        int contDatosErroneos = 0;
        bool estadoConexion = false;
        bool prodOpen = false;
        bool userOpen = false;
        bool changePort = false;
        bool datoEmp = false;
        bool datoPren = false;
        bool bandhorasInicio = false;
        bool bandErrorIP = false;
        FormProduccion objFormProduccion;
        FormUsuario objVisualUsuario;
        Color backgroundColor = new Color();
        String strPuerto = "COM4";
        SerialPort puerto;
        System.Windows.Forms.Timer loopArduino, loopDatos, loopSerialPorts;
        String strDatos, strMaquinaTrabajando, strMaquinaNoTrabajando, strDiscProd, strYield, strMaquinaTrabajandoArd, strMaquinaNoTrabajandoArd, strDiscProdArd, strYieldArd;
        double discBuenos, discMalos, discProd, yield, bandDiscProd, band2DiscProd, estadoUvs;
        bool bandCambioPuerto = false, actualizar = false, actualizacionCompleta = false, paroMaquina = true, bandMaquina = false, bandParoMaquina = true, pantallaUsuario = false, ipEncontrada = false, bandPuertoAbierto = false, reconexionCompletada = false, intentoReconexion = false, bandTurno = false, bandResetArduino = false, bandCancelar = false, eventCmb = false, bandResetArduinoCero = false, bandUv = true, cerrar = false, bandCambioTurno = false;
        bool maquinaConectada = false, bandReconex = false, prodCreated = false, capturaProduccion = false;
        double tiempoParo = 0, tiempoParoMinutos, millis1 = 0, millis2 = 0, millis3 = 0;
        int contWind = 0, contClick2 = 0, contRun = 0, cmblen = -1, contMaquinaCorriendo = 0, contMaquinaParada = 0, tipoParo = 0, bandProduccion = 0, contEsperaConexion = 0, contReset = 0, kHora = 18, kMin = 45, jHora = 6, jMin = 45, contClick = 0, contClosed = 0;
        Double horaActual, minutoActual;
        String strHoraParo, strTiempoParo, turnoActual, tipo_Paro, ultConex, cambioTurno, cambioTurnoBand;
        String direccionIp, nombreMaquina, tipoMaquina, numeroMaquina;
        Clases.CParos objParo;
        Clases.CAsignacion objAsignacion;
        Clases.CAsignacion_Paros objAsignacionParo;
        Clases.CUsuarios objUsuarios;
        Clases.CProduccion objProduccion;
        Clases.CConexion objConexion;
        Form formPrincipal;
        String IDmaquina, fechaQuery, fechaQueryAyer;
        Double discProd2 = 0, discBuenos2 = 0, discMalos2 = 0;
        String strMaquinaTrabajando2 = "", strYield2, strDiscProd2 = "", strMaquinaNoTrabajando2 = "";
        String strHora, strMinuto, strSegundo, strDia, strMes, strYear, strHoraCompleta, strFecha, strEstadoUvs;
        String strDiaAyer, strMesAyer, strYearAyer, strFechaAyer, strBandHora;
        List<String> metaProd = new List<String>();
        List<String> horaK = new List<String>();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        List<String> horaJ = new List<String>();
        List<String> revisiones = new List<String>();
        List<String> guardados = new List<String>();
        List<String> prodCapturada = new List<String>();
        List<int> tipoFormato = new List<int>();
        List<System.Windows.Forms.Label> labelsPrensa = new List<System.Windows.Forms.Label>();
        List<System.Windows.Forms.Label> labelsEmpaque = new List<System.Windows.Forms.Label>();
        List<System.Windows.Forms.Label> labelsHoras = new List<System.Windows.Forms.Label>();
        int contStat = 0, datoMaquinaTrabajando = 0;
        String strStat = "";
        bool mostrarLbl = false;
        bool forzarProd = false, mensajeErrorMostrado = false;
        bool generarRevision = false, band1Revision = false, band2Revision = false, bandTopMost = false;
        public int resultadoCerrar = 0;
        String hostname = "";
        String bandFecha;
        String strMetaRev = "";
        String horasMensaje = "";
        int tipoProduccion = 0;
        DialogResult result;
        


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

        private void rbtnBook_CheckedChanged(object sender, EventArgs e)
        {
            tipoProduccion = 0;
            if (turnoActual == "K" && Convert.ToInt16(strHora) < 18)
            {
                rellenarInfoProd(fechaQueryAyer, strFechaAyer);
                //txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirm(IDmaquina, turnoActual, fechaQueryAyer));
            }
            else
            {
                rellenarInfoProd(fechaQuery, strFecha);
                //txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirm(IDmaquina, turnoActual, fechaQuery));
            }
        }

        private void rbtnEmpaque_CheckedChanged(object sender, EventArgs e)
        {
            tipoProduccion = 1;
            if (turnoActual == "K" && Convert.ToInt16(strHora) < 18)
            {
                rellenarInfoProd(fechaQueryAyer, strFechaAyer);
                //txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirm(IDmaquina, turnoActual, fechaQueryAyer));
            }
            else
            {
                rellenarInfoProd(fechaQuery, strFecha);
                //txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirm(IDmaquina, turnoActual, fechaQuery));
            }
        }

        private void rbtnPrensa_CheckedChanged(object sender, EventArgs e)
        {
            tipoProduccion = 2;
            if (turnoActual == "K" && Convert.ToInt16(strHora) < 18)
            {
                rellenarInfoProd(fechaQueryAyer, strFechaAyer);
                //txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirm(IDmaquina, turnoActual, fechaQueryAyer));
            }
            else
            {
                rellenarInfoProd(fechaQuery, strFecha);
                //txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirm(IDmaquina, turnoActual, fechaQuery));
            }
        }

        private void frmPrincipal_Leave(object sender, EventArgs e)
        {

        }

        private void timerArdConex_Tick(object sender, EventArgs e)
        {
            if(!puerto.IsOpen)
                puerto.Open();
            timerArdConex.Stop();
            bandReconex = false;
        }
        private void lblEstatus_Click(object sender, EventArgs e)
        {
            contStat++;   
            if(contStat>=5)
            {
                if(mostrarLbl)
                {
                    mostrarLbl = false;
                }
                else
                {
                    mostrarLbl = true;
                }
                contStat = 0;
            }
        }
        private void cmbSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            loopSerialPorts.Stop();
        }

        private void StatusMachines_Tick(object sender, EventArgs e)
        {
            if (maquinaConectada)
            {
                objAsignacion.maquinaConectada(1, numeroMaquina);
            }
        }


        private void timerRes_Tick(object sender, EventArgs e)
        {
            if (cerrar)
            {
                this.Close();
            }
        }
        private void btnProduccion_Click(object sender, EventArgs e)
        {
            abrirFormProd();
        }

        public void abrirFormProd()
        {
            if(!prodCreated)
            {
                prodCreated = true;
                prodOpen = true;
                this.TopMost = false;
                objFormProduccion = new FormProduccion(this, turnoActual, numeroMaquina);
                this.Enabled = false;
                objFormProduccion.Owner = this;
                objFormProduccion.centrarForm();
                objFormProduccion.Show();
                if (forzarProd)
                    forzarVentanaProd();
                objFormProduccion.FormClosed += ObjFormProduccion_FormClosed;
            }
            else
            {
                objFormProduccion.centrarForm();
                objFormProduccion.Show();
                forzarVentanaProd();
            }
            
        }

        public void forzarVentanaProd()
        {
            objFormProduccion.WindowState = FormWindowState.Normal;
            objFormProduccion.bloquearBotones();
            objFormProduccion.TopMost = true;
            objFormProduccion.MinimizeBox = false;
            objFormProduccion.centrarForm();
            objFormProduccion.LocationChanged += ObjFormProduccion_LocationChanged;
            objFormProduccion.FormClosing += ObjFormProduccion_FormClosing;
            objFormProduccion.Leave += ObjFormProduccion_Leave;
        }

        private void ObjFormProduccion_Leave(object sender, EventArgs e)
        {
            if (forzarProd)
                objFormProduccion.centrarForm();
        }

        private void ObjFormProduccion_LocationChanged(object sender, EventArgs e)
        {
            if (forzarProd)
                objFormProduccion.centrarForm();
        }

        private void ObjFormProduccion_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if(forzarProd && !actualizar && !actualizacionCompleta)
            {
                mensajeErrorMostrado = false;
                bandTopMost = false;
                mostrarMensajeError(datoEmp, datoPren);
                e.Cancel = true;
            }
        }

        private void ObjFormProduccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            prodOpen = false;
            this.Enabled = true;
            prodCreated = false;
        }
        private void lblCerrar_DoubleClick(object sender, EventArgs e)
        {
            userOpen = true;
            this.TopMost = false;
            objVisualUsuario = new FormUsuario(this, 3);
            objVisualUsuario.Show();
            this.Enabled = false;
            objVisualUsuario.Owner = this;
            objVisualUsuario.FormClosed += ObjVisualUsuario_FormClosed;
        }

        private void ObjVisualUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(resultadoCerrar != 0)
            {
                cerrar = true;
                userOpen = false;
            }
        }

        //ok
        private void lblIp_Click(object sender, EventArgs e)
        {
            contClick2 += 1;
            if (contClick2 >= 4)
            {
                strPuerto = "";
                puerto.Close();
                bandCambioPuerto = true;
                pantallaConexionArduino();
                contClick2 = 0;
                
            }
        }

        
        //ok
        private void callWindow_Tick(object sender, EventArgs e)
        {
            if(!prodOpen && !userOpen)
            {
                if (cmbParo.Text == "" && !this.TopMost && !objFormProduccion.TopMost)
                    this.TopMost = true;
                else if(cmbParo.Text != "" && !generarRevision)
                    this.TopMost = false;
                callWindow.Enabled = false;
                contWind += 1;
                if (contWind == 180)
                {
                    contWind = 0;
                    Point deskPoint = new Point(0, 0);
                    this.DesktopLocation = deskPoint;
                }
            }
            
        }
        //ok
        private void timerClosed_Tick(object sender, EventArgs e)
        {
            contClosed++;
            if (contClosed >= 3)
            {
                contClosed = 0;
                objAsignacion.maquinaConectada(1, numeroMaquina, ultConex);
                timerClosed.Stop();
            }
        }
        //ok
        private void timerConexion_Tick(object sender, EventArgs e)
        {
            string conex = objAsignacion.retornoConex(numeroMaquina);
            if (conex == "0" && puerto.IsOpen)
                objAsignacion.maquinaConectada(1, numeroMaquina, ultConex);
        }
        
        //ok
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pantallaUsuario = false;
            cmbParo.SelectedIndex = -1;
            lblFondoGris.Visible = false;
            lblUsuario.Visible = false;
            lblPassword.Visible = false;
            lblOpcion.Visible = false;
            txtUsuario.Visible = false;
            txtPassword.Visible = false;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            cmbFallas.Visible = false;
            cmbProceso.Visible = false;
            cmbParo.Visible = true;
            lblParo.Visible = true;
            lblTiempoEnParo.Visible = true;
            lblTiempoParoActual.Visible = true;
            btnCerrar.Visible = true;
            txtUsuario.Text = "";
            txtPassword.Text = "";
            cmbFallas.SelectedIndex = -1;
            cmbProceso.SelectedIndex = -1;
        }
        
        private void timerReconexion_Tick(object sender, EventArgs e)
        {
            contEsperaConexion++;
            
        }
       

        //diaTurno = ok
        private string diaTurno()
        {
            String strKday, strKmes, strKyear;
            String fecha;
            if (DateTime.Now.Hour < jHora)
            {
                strKday = DateTime.Now.AddDays(-1).ToString("dd");
                strKmes = DateTime.Now.AddDays(-1).ToString("MM");
                strKyear = DateTime.Now.AddDays(-1).ToString("yyyy");
                fecha = strKyear + "-" + strKmes + "-" + strKday;
                
            }
            else if (DateTime.Now.Hour == jHora && DateTime.Now.Minute < jMin)
            {
                strKday = DateTime.Now.AddDays(-1).ToString("dd");
                strKmes = DateTime.Now.AddDays(-1).ToString("MM");
                strKyear = DateTime.Now.AddDays(-1).ToString("yyyy");
                fecha = strKyear + "-" + strKmes + "-" + strKday;

            }
            else
            {
                strKday = DateTime.Now.ToString("dd");
                strMes = DateTime.Now.ToString("MM");
                strYear = DateTime.Now.ToString("yyyy");
                fecha = strYear + "-" + strMes + "-" + strKday;
            }
            return fecha; 
        }
        private void timerProduccion_Tick(object sender, EventArgs e)
        {
            strFecha = diaTurno();
            if (!paroMaquina)
            {
                objAsignacion.maquinaCorriendo(1, nombreMaquina);
                if(this.TopMost && !prodOpen && !userOpen && !generarRevision)
                    this.TopMost = false;
            }
            else if(paroMaquina)
            {
                objAsignacion.maquinaCorriendo(0, nombreMaquina);
            }
            try
            {
                actualizar = objAsignacion.actualizarSistema(numeroMaquina);
                if (actualizar)
                    {
                        this.Close();
                    }
                else
                {
                    actualizacionCompleta = objAsignacion.actualizarSistemaCompleto(numeroMaquina);
                    if (actualizacionCompleta)
                    {
                        this.Close();
                    }
                }
                
            }
            catch (SqlException error)
            {
                //MessageBox.Show("Error en base de datos" + error.ToString());
                errorReport("Error en base de datos" + error.ToString());
            }
            if(turnoActual == "J")
            {
                int i = 0;
                foreach (String str in horaJ)
                {
                    labelsHoras[i].Text = str;
                    labelsHoras[i].Visible = true;
                    String[] arrHora = str.Split(':');
                    if(strHora == arrHora[0])
                    {
                        if(Convert.ToInt16(arrHora[1]) > Convert.ToInt16(strMinuto) )
                        {
                            txtMeta.Text = metaProd[i];
                        }
                        else
                        {
                            txtMeta.Text = metaProd[i+1];
                        }                 
                    }
                    i++;
                }
            }

            else if(turnoActual == "K")
            {
                int i = 0;
                foreach (String str in horaK)
                {
                    labelsHoras[i].Text = str;
                    labelsHoras[i].Visible = true;
                    String[] arrHora = str.Split(':');
                    if (strHora == arrHora[0])
                    {
                        if (Convert.ToInt16(arrHora[1]) > Convert.ToInt16(strMinuto))
                        {
                            txtMeta.Text = metaProd[i];
                        }
                        else
                        {
                            txtMeta.Text = metaProd[i+1];
                        }
                    }
                    i++;
                }
                
            }

            mostrarProdCapturada();

            if (turnoActual == "K" && Convert.ToInt16(strHora)<18)
            {
                rellenarInfoProd(fechaQueryAyer, strFechaAyer);
                //txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirm(IDmaquina, turnoActual, fechaQueryAyer));
            }
            else
            {
                rellenarInfoProd(fechaQuery, strFecha);
                //txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirm(IDmaquina, turnoActual, fechaQuery));
            }            
            
            if(Convert.ToInt16(txtConfirm.Text)>=Convert.ToInt16(txtMeta.Text))
            {
                lblStat.BackColor = Color.DarkGreen;
            }
            else
            {
                lblStat.BackColor = Color.Red;
            }
            if(cerrar)
            {
                this.Close();
            }
        }

        public void rellenarInfoProd(String fechaQuery, String fecha)
        {
            if(tipoProduccion == 0)
                txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirm(IDmaquina, turnoActual, fechaQuery));
            else if (tipoProduccion == 1)
                txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirmEmp_Pre(numeroMaquina, turnoActual, fecha, 1));
            else if (tipoProduccion == 2)
                txtConfirm.Text = Convert.ToString(objProduccion.mostrarProduccionConfirmEmp_Pre(numeroMaquina, turnoActual, fecha, 2));
        }

        public void cerrarParo()
        {
            if (tiempoParo < 60)
            {
                strTiempoParo = "1 minuto";
            }
            else if (tiempoParo > 60 && tiempoParo < 96)
            {
                tiempoParoMinutos = tiempoParo / 60;
                strTiempoParo = Convert.ToString(Math.Round(tiempoParoMinutos)) + " minuto";

            }
            else if (tiempoParo > 96)
            {
                tiempoParoMinutos = tiempoParo / 60;
                strTiempoParo = Convert.ToString(Math.Round(tiempoParoMinutos)) + " minutos";
            }
            tiempoParo = 0;
            if (cmbParo.Text == "")
            {
                tipo_Paro = "0 - Paro sin captura";
            }
            else
            {
                string fallaSelect = objAsignacionParo.mostrarParoAsignado(cmbParo.Text);
                tipo_Paro = fallaSelect + " - " + cmbParo.Text;
            }
            if(bandCambioTurno)
            {
                objParo.insertarParo(numeroMaquina, strHoraParo, cambioTurnoBand, tipo_Paro, strTiempoParo);
                strHoraParo = strHoraCompleta + " " + strFecha;
                bandCambioTurno = false;
            }
            else
            {
                if (eventCmb)
                {
                    cmbParo.Items.RemoveAt(cmblen);
                    eventCmb = false;
                }
                objParo.insertarParo(numeroMaquina, strHoraParo, turnoActual, tipo_Paro, strTiempoParo);
                strHoraParo = strHoraCompleta + " " + strFecha;
                cmbParo.SelectedIndex = -1;
            }
            
        }
        //btnCerrar_click = ok
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrarParo();
        }
        //btnayuda_click = ok
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Contactar al departamento de ingenieria para resolver el problema");
            errorReport("Contactar al departamento de ingenieria para resolver el problema");
        }
        //timertiempoparo_tick = ok
        private void timerTiempoParo_Tick(object sender, EventArgs e)
        {
            tiempoParo += 1;
            
            lblTiempoParoActual.Text = TimeSpan.FromSeconds(tiempoParo).ToString("c");
        }
        //obtenerHoraInicio = ok
        public void obtenerHoraInicio()
        {
            estadoConexion = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            strHora = DateTime.Now.ToString("HH");
            strMinuto = DateTime.Now.ToString("mm");
            strSegundo = DateTime.Now.ToString("ss");
            strDia = DateTime.Now.ToString("dd");
            strMes = DateTime.Now.ToString("MM");
            strYear = DateTime.Now.ToString("yyyy");
            strHoraCompleta = strHora + ":" + strMinuto + ":" + strSegundo;
            strFecha = strYear + "-" + strMes + "-" + strDia;
            fechaQuery = strYear + "-" + strMes + "-" + strDia;
        }

        public void revisarHora(Double hora, Double minuto)
        {
            tipoFormato.Clear();
            strMetaRev = "";
            datoEmp = false;
            datoPren = false;
            if (hora == 18 || hora == 6)
            {
                if (minuto == 20 && !band1Revision)
                {
                    if (turnoActual == "K")
                        strMetaRev = "06:45";
                    else if (turnoActual == "J")
                        strMetaRev = "18:45";
                    generarRevision = true;
                    if(!revisiones.Contains(strMetaRev))
                        revisiones.Add(strMetaRev);
                    band1Revision = true;
                }
                else if(minuto > 20 && band1Revision)
                {
                    band1Revision = false;
                }
            }
            else
            {
                if(minuto == 45 && !band1Revision)
                {
                    int i = 0;
                    if(turnoActual == "K")
                    {
                        foreach (String str in horaK)
                        {
                            String[] arrHora = str.Split(':');
                            if (strHora == arrHora[0])
                            {
                                strMetaRev = horaK[i];
                            }
                            i++;
                        }
                    }
                    else if(turnoActual == "J")
                    {
                        foreach (String str in horaJ)
                        {
                            String[] arrHora = str.Split(':');
                            if (strHora == arrHora[0])
                            {
                                strMetaRev = horaJ[i];
                            }
                            i++;
                        }
                    } 
                    generarRevision = true;
                    if (!revisiones.Contains(strMetaRev))
                        revisiones.Add(strMetaRev);
                    band1Revision = true;

                }
                else if(minuto > 45 && band1Revision)
                {
                    band1Revision = false;
                }
            }
            if(generarRevision)
            {
                if(revisiones.Count > 0)
                {
                    foreach(String str in revisiones)
                    {
                        if (turnoActual == "K" && hora < 18)
                        {
                            tipoFormato = objProduccion.revisarDatoProd(numeroMaquina, turnoActual, strFechaAyer, str);
                        }
                        else
                        {
                            tipoFormato = objProduccion.revisarDatoProd(numeroMaquina, turnoActual, strFecha, str);
                        }
                        foreach (int j in tipoFormato)
                        {
                            if (j == 1)
                                datoEmp = true;
                            else if (j == 2)
                                datoPren = true;
                        }
                        if (!datoEmp || !datoPren)
                        {
                            if(!this.TopMost && !bandTopMost && !objFormProduccion.TopMost)
                            {
                                this.TopMost = true;
                                bandTopMost = true;
                            }    
                            mostrarMensajeError(datoEmp, datoPren);


                        }
                        else if (datoPren && datoEmp)
                        {
                            guardados.Add(str);
                            
                        }
                    }
                    foreach(String str in guardados)
                        if(revisiones.Contains(str))
                            revisiones.Remove(str);
                }
                else
                {
                    bandTopMost = false;
                    generarRevision = false;
                    forzarProd = false;
                    mensajeErrorMostrado = false;
                    if (prodCreated)
                    {
                        objFormProduccion.TopMost = false;
                        objFormProduccion.MinimizeBox = true;
                        objFormProduccion.Close();
                    }
                    objFormProduccion.desbloquearBotones();    
                    guardados.Clear();

                }
                
            }
            
        }

        public void mostrarMensajeError(bool datoEmp1, bool datoPren1)
        {
            if(prodCreated)
            {
                if(objFormProduccion.usuarioCreated)
                {
                    objFormProduccion.objVisualUsuario.Close();
                    this.Enabled = true;
                }
            }
            horasMensaje = "";
            foreach(String str in revisiones)
            {
                horasMensaje = horasMensaje + str + "\n";
            }
            if (!datoEmp1 && !datoPren1)
            {
                if (!mensajeErrorMostrado)
                {
                    mensajeErrorMostrado = true;
                    result = MessageBox.Show("Favor de capturar datos de producción de prensa y empaque correspondiente a la hora:\n " + horasMensaje);

                }
            }

            else if (!datoEmp1 && datoPren1)
            {
                if (!mensajeErrorMostrado)
                {
                    mensajeErrorMostrado = true;
                    result = MessageBox.Show("Favor de capturar datos de producción de empaque correspondiente a la hora: \n " + horasMensaje);
                }
            }
            else if (datoEmp1 && !datoPren1)
            {
                if (!mensajeErrorMostrado)
                {
                    mensajeErrorMostrado = true;
                    result = MessageBox.Show("Favor de capturar datos de producción de prensa correspondiente a la hora:\n " + horasMensaje);
                }
            }
            if (result == DialogResult.OK)
            {
                if (this.TopMost)
                    this.TopMost = false;
                if (!forzarProd)
                {
                    forzarProd = true;
                    abrirFormProd();
                }
            }
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            estadoConexion = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (!estadoConexion)
                ipEncontrada = false;
            strHora = DateTime.Now.ToString("HH");
            strMinuto = DateTime.Now.ToString("mm");
            strSegundo = DateTime.Now.ToString("ss");
            strDia = DateTime.Now.ToString("dd");
            strMes = DateTime.Now.ToString("MM");
            strYear = DateTime.Now.ToString("yyyy");
            strDiaAyer = DateTime.Now.AddDays(-1).ToString("dd");
            strMesAyer = DateTime.Now.AddDays(-1).ToString("MM");
            strYearAyer = DateTime.Now.AddDays(-1).ToString("yyyy");
            strHoraCompleta = strHora + ":" + strMinuto + ":" + strSegundo;
            strFechaAyer = strYearAyer + "-" + strMesAyer + "-" + strDiaAyer;
            strFecha = strYear + "-" + strMes + "-" + strDia;
            fechaQuery = strYear + "-" + strMes + "-" + strDia;
            fechaQueryAyer = strYearAyer + "-" + strMesAyer + "-" + strDiaAyer;

            lblHora.Text = strHoraCompleta;
            lblFecha.Text = strFecha;

            lblHoraParo.Text = strHoraParo;
            lblTiempoParo.Text = strTiempoParo;

            horaActual = Convert.ToDouble(DateTime.Now.Hour.ToString());
            minutoActual = Convert.ToDouble(DateTime.Now.Minute.ToString());

            if (horaActual > jHora && horaActual < kHora)
            { 
                turnoActual = "J";
            }
            else if(horaActual == jHora || horaActual == kHora)
            {
                if(horaActual == jHora && minutoActual >= jMin)
                {
                    turnoActual = "J";
                }
                else if(horaActual == jHora && minutoActual < jMin)
                {
                    turnoActual = "K";
                }
                else if(horaActual == kHora && minutoActual >=kMin)
                {
                    turnoActual = "K";
                }
                else if(horaActual == kHora && minutoActual <kMin)
                {
                    turnoActual = "J";
                }
            }
            else
            {
                turnoActual = "K";
            }

            if (!bandTurno)
            {
                cambioTurno = turnoActual;
                bandTurno = true;
            }

            if (cambioTurno != turnoActual)
            {
                restablecerValoresProduccion();
                ocultarEmpaque();
                ocultarPrensa();
                if(paroMaquina && puerto.IsOpen)
                {
                    cambioTurnoBand = cambioTurno;
                    bandCambioTurno = true;
                    String bandParoAbierto = cmbParo.Text;
                    cerrarParo(); 
                    cmbParo.Text = bandParoAbierto;
                }
                if (puerto.IsOpen)
                {
                    bandReconex = true;
                    puerto.Close();
                    timerArdConex.Start();
                }
                bandTurno = false;
            }
            if (!mostrarLbl)
            {
                lblEstatus.Text = "";
            }
            else
            {
                lblEstatus.Text = strPuerto;
            }
            if (turnoActual == "K" && horaActual < 18)
                bandFecha = fechaQueryAyer;
            else
                bandFecha = fechaQuery;
            if (objProduccion.boolProduccionConfirm(IDmaquina, turnoActual, bandFecha))
                revisarHora(horaActual, minutoActual);
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        //conectarArduino = ok IMPORTANTE ASIGNACION RUN, STOP
        public void conectarArduino()
        {
            if(nombreMaquina != "NULL" && !bandCambioPuerto)
            {
                if (!puerto.IsOpen)
                {
                    try
                    {
                        puerto.Open();
                        puerto.DataReceived += Puerto_DataReceived;
                        ultConex = strHoraCompleta + " " + strFecha;
                        objAsignacion.maquinaConectada(1, numeroMaquina, ultConex);
                        maquinaConectada = true;
                        bandPuertoAbierto = true;
                        loopDatos.Start();
                    }
                    catch (Exception error)
                    {
                        if (bandPuertoAbierto)
                        {
                            ultConex = strHoraCompleta + " " + strFecha;
                            bandPuertoAbierto = false;
                        }
                        else
                        {
                            ultConex = objAsignacion.retornoUltConex(numeroMaquina);
                        }
                        if(ultConex == "")
                        {
                            ultConex = "Sin conexion";
                        }
                        paroMaquina = true;
                        objAsignacion.maquinaCorriendo(0, numeroMaquina);
                        objAsignacion.maquinaConectada(0, numeroMaquina, ultConex);
                        maquinaConectada = false;
                        //MessageBox.Show("No se pudo establecer la conexion, seleccione el puerto correcto y vuelva a intentar");
                        bandCambioPuerto = true;
                        pantallaConexionArduino();
                        //errorReport("No se pudo establecer la conexion, seleccione el puerto correcto y vuelva a intentar");

                    }
                }
            }
        }

        public void restablecerValoresProduccion()
        {
            if(forzarProd)
            {
                forzarProd = false;
                generarRevision = false;
                bandTopMost = false;
                revisiones.Clear();
                guardados.Clear();
                if (prodCreated)
                {
                    objFormProduccion.TopMost = false;
                    objFormProduccion.MinimizeBox = true;
                    objFormProduccion.desbloquearBotones();
                    objFormProduccion.Close();
                }
            }
            else
            {
                if (prodCreated)
                {
                    objFormProduccion.Close();
                }
            }
        }

        public void conectarMaquina()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    direccionIp = ip.ToString();
                }
            }
            nombreMaquina = objAsignacion.seleccionarMaquina(direccionIp);
            if (nombreMaquina == "NULL")
            {
                ipEncontrada = false;
                callWindow.Enabled = false;
                if(this.TopMost && !prodOpen && !userOpen && !generarRevision)
                    this.TopMost = false;
                timerProduccion.Stop();
                timerConexion.Stop();
                bandErrorIP = true;
                timerRes.Start();
                backgroundColor = Color.LightSkyBlue;
                Properties.Settings.Default.FormBackground = backgroundColor;
                Properties.Settings.Default.Save();
                this.BackColor = backgroundColor;
                lblCerrar.BackColor = Color.LightSkyBlue;
                lblEstatus.BackColor = Color.LightSkyBlue;
                cmbParo.Visible = false;
                lblParo.Visible = false;
                lblTiempoEnParo.Visible = false;
                lblTiempoParoActual.Visible = false;
                btnCerrar.Visible = false;
                btnProduccion.Visible = false;
                lblDataBase.Visible = true;
                btnAyuda.Visible = true;
            }
            else
            {
                bandErrorIP = false;
                ipEncontrada = true;
                timerProduccion.Start();
                timerConexion.Start();
                btnProduccion.Visible = true;
                String[] substrings = nombreMaquina.Split(' ');
                if (substrings.Length == 1)
                {
                    numeroMaquina = substrings[0];
                }
                objAsignacion.modificarHostname(numeroMaquina, Dns.GetHostName());
            }
            lblIp.Text = nombreMaquina;
        }

        public void llenarListLabelsPrensa()
        {
            labelsPrensa.Add(pr1);
            labelsPrensa.Add(pr2);
            labelsPrensa.Add(pr3);
            labelsPrensa.Add(pr4);
            labelsPrensa.Add(pr5);
            labelsPrensa.Add(pr6);
            labelsPrensa.Add(pr7);
            labelsPrensa.Add(pr8);
            labelsPrensa.Add(pr9);
            labelsPrensa.Add(pr10);
            labelsPrensa.Add(pr11);
            labelsPrensa.Add(pr12);
        }

        public void llenarListLabelsEmpaque()
        {
            labelsEmpaque.Add(em1);
            labelsEmpaque.Add(em2);
            labelsEmpaque.Add(em3);
            labelsEmpaque.Add(em4);
            labelsEmpaque.Add(em5);
            labelsEmpaque.Add(em6);
            labelsEmpaque.Add(em7);
            labelsEmpaque.Add(em8);
            labelsEmpaque.Add(em9);
            labelsEmpaque.Add(em10);
            labelsEmpaque.Add(em11);
            labelsEmpaque.Add(em12);
        }

        public void llenarListLabelsHoras()
        {
            labelsHoras.Add(lblHora1);
            labelsHoras.Add(lblHora2);
            labelsHoras.Add(lblHora3);
            labelsHoras.Add(lblHora4);
            labelsHoras.Add(lblHora5);
            labelsHoras.Add(lblHora6);
            labelsHoras.Add(lblHora7);
            labelsHoras.Add(lblHora8);
            labelsHoras.Add(lblHora9);
            labelsHoras.Add(lblHora10);
            labelsHoras.Add(lblHora11);
            labelsHoras.Add(lblHora12);
        }

        public frmPrincipal()
        {
            limpiarError = false;
            InitializeComponent();
            llenarListLabelsPrensa();
            llenarListLabelsEmpaque();
            llenarListLabelsHoras();
            objFormProduccion = new FormProduccion();
            objAsignacion = new Clases.CAsignacion();
            objProduccion = new Clases.CProduccion();
            objUsuarios = new Clases.CUsuarios();
            objParo = new Clases.CParos();
            objAsignacionParo = new Clases.CAsignacion_Paros();
            objConexion = new Clases.CConexion();
            InitializeContextMenu();
            timerProduccion.Start();
            timerHora.Start();
            lblConnect.Visible = false;
            cmbSerial.Visible = false;
            btnConectar.Visible = false;
            lblFondoGris.Visible = false;
            lblUsuario.Visible = false;
            lblPassword.Visible = false;
            lblOpcion.Visible = false;
            txtUsuario.Visible = false;
            txtPassword.Visible = false;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            lblStatus.Visible = false;
            lblDataBase.Visible = false;
            btnAyuda.Visible = false;
            lblHoraParo.Visible = false;
            lblTiempoParo.Visible = false;
            lblStat.Visible = false;
            lblStatText.Visible = false;
            lblMeta.Visible = false;
            rbtnBook.Visible = false;
            rbtnEmpaque.Visible = false;
            rbtnPrensa.Visible = false;
            lblConfirm.Visible = false;
            txtConfirm.Visible = false;
            txtMeta.Visible = false;
            lblEstatus.Text = "";
            txtConfirm.Text = "0";
            txtMeta.Text = "0";
            

            rbtnBook.Checked = true;
            conectarMaquina();
            strPuerto = objAsignacion.obtenerCOM(nombreMaquina);
            puerto = new SerialPort(strPuerto);
            puerto.BaudRate = 9600;
            puerto.Parity = Parity.None;
            puerto.StopBits = StopBits.One;
            puerto.DataBits = 8;

            loopArduino = new System.Windows.Forms.Timer();
            loopArduino.Interval = 500;
            loopArduino.Tick += LoopArduino_Tick;
            loopArduino.Start();

            loopDatos = new System.Windows.Forms.Timer();
            loopDatos.Interval = 1000;
            loopDatos.Tick += LoopDatos_Tick;

            loopSerialPorts = new System.Windows.Forms.Timer();
            loopSerialPorts.Interval = 3000;
            loopSerialPorts.Tick += LoopSerialPorts_Tick;

            loopSerialPorts.Stop();

            formPrincipal = this;

            if(ipEncontrada)
            {
                backgroundColor = Color.DarkOrange;
                Properties.Settings.Default.FormBackground = backgroundColor;
                Properties.Settings.Default.Save();
                this.BackColor = backgroundColor;
                lblCerrar.BackColor = Color.DarkOrange;
                lblEstatus.BackColor = Color.DarkOrange;
            }

            ocultarPrensa();
            ocultarEmpaque();
            obtenerHoraInicio();
            ocultarLabelsHoras();
            
            conectarArduino();
            llenarK();
            llenarJ();
            llenarMeta();
            obtenerIDmaquina();
        }

        public void mostrarProdCapturada()
        {
            prodCapturada.Clear();
            if(turnoActual == "K" && horaActual < 18)
                prodCapturada = objProduccion.obtenerProduccionHoras(numeroMaquina, turnoActual, strFechaAyer, 1);
            else
                prodCapturada = objProduccion.obtenerProduccionHoras(numeroMaquina, turnoActual, strFecha, 1);

            int i = 0;
            foreach (System.Windows.Forms.Label lbl in labelsHoras)
            {
                
                foreach(String str in prodCapturada)
                {
                    String[] strSplit = str.Split(',');
                    if (lbl.Text == strSplit[0])
                    {
                        labelsEmpaque[i].Text = strSplit[1];
                        labelsEmpaque[i].Visible = true;
                    }
                    
                }
                i++;
            }
            prodCapturada.Clear();

            if (turnoActual == "K" && horaActual < 18)
                prodCapturada = objProduccion.obtenerProduccionHoras(numeroMaquina, turnoActual, strFechaAyer, 2);
            else
                prodCapturada = objProduccion.obtenerProduccionHoras(numeroMaquina, turnoActual, strFecha, 2);

            i = 0;
            foreach (System.Windows.Forms.Label lbl in labelsHoras)
            {
                
                foreach (String str in prodCapturada)
                {
                    String[] strSplit = str.Split(',');
                    if (lbl.Text == strSplit[0])
                    {
                        labelsPrensa[i].Text = strSplit[1];
                        labelsPrensa[i].Visible = true;
                    }
                    
                }
                i++;
            }
        }

        public void ocultarPrensa()
        {
            foreach (System.Windows.Forms.Label lbl in labelsPrensa)
                lbl.Visible = false;
        }

        public void ocultarEmpaque()
        {
            foreach (System.Windows.Forms.Label lbl in labelsEmpaque)
                lbl.Visible = false;
        }

        public void ocultarLabelsHoras()
        {
            foreach(System.Windows.Forms.Label lbl in labelsHoras)
            {
                lbl.Visible = false;
            }
        }
        public void mostrarLabelsHoras()
        {
            foreach (System.Windows.Forms.Label lbl in labelsHoras)
            {
                lbl.Visible = true;
            }
        }

        public void obtenerIDmaquina()
        {
            IDmaquina = objAsignacion.obtenerID(nombreMaquina);
        }
        private void LoopSerialPorts_Tick(object sender, EventArgs e)
        {
            rellenarCmbSerial();
        }

        public void llenarMeta()
        {
            metaProd.Add("0");
            metaProd.Add("104");
            metaProd.Add("208");
            metaProd.Add("312");
            metaProd.Add("416");
            metaProd.Add("520");
            metaProd.Add("625");
            metaProd.Add("729");
            metaProd.Add("833");
            metaProd.Add("937");
            metaProd.Add("1041");
            metaProd.Add("1145");
            metaProd.Add("1250");
        }

        public void llenarJ()
        {
            horaJ.Add("07:45");
            horaJ.Add("08:45");
            horaJ.Add("09:45");
            horaJ.Add("10:45");
            horaJ.Add("11:45");
            horaJ.Add("12:45");
            horaJ.Add("13:45");
            horaJ.Add("14:45");
            horaJ.Add("15:45");
            horaJ.Add("16:45");
            horaJ.Add("17:45");
            horaJ.Add("18:45");
        }

        public void llenarK()
        {
            horaK.Add("19:45");
            horaK.Add("20:45");
            horaK.Add("21:45");
            horaK.Add("22:45");
            horaK.Add("23:45");
            horaK.Add("00:45");
            horaK.Add("01:45");
            horaK.Add("02:45");
            horaK.Add("03:45");
            horaK.Add("04:45");
            horaK.Add("05:45");
            horaK.Add("06:45");
        }
        public void InitializeContextMenu()
        {
            //Fallas Principales
            List<String> fallaPrincipal = new List<string>();
            fallaPrincipal = objAsignacionParo.mostrarParosAsignados(100);
            foreach(string s in fallaPrincipal)
            {
                this.cmbParo.Items.Add(s);
            }
            //Fallas Equipo
            List<String> fallaEquipo = new List<string>();
            fallaEquipo = objAsignacionParo.mostrarParosAsignados(200);
            foreach(string s in fallaEquipo)
            {
                this.cmbFallas.Items.Add(s);
            }
            List<string> fallaProceso = new List<string>();
            fallaProceso = objAsignacionParo.mostrarParosAsignados(300);
            foreach(string s in fallaProceso)
            {
                this.cmbProceso.Items.Add(s);
            }
        }

        public void rellenarCmbSerial()
        {
            int contError = 0;
            cmbSerial.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                try
                {
                    String[] substringsPuerto = port.Split('M');
                    if (Convert.ToInt16(substringsPuerto[1]) > 3)
                        cmbSerial.Items.Add(port);
                }
                catch(Exception error)
                {
                    contError++;
                    if(contError >2)
                        errorReport ("Error en los puertos serie:\n" + error.ToString());

                }
            }
        }

        public void pantallaConexionArduino()             
        {
            loopSerialPorts.Start();
            callWindow.Enabled = false;
            if (this.TopMost && !prodOpen && !userOpen && !generarRevision)
                this.TopMost = false;
            backgroundColor = Color.LightSkyBlue;
            Properties.Settings.Default.FormBackground = backgroundColor;
            Properties.Settings.Default.Save();
            this.BackColor = backgroundColor;
            lblCerrar.BackColor = Color.LightSkyBlue;
            lblEstatus.BackColor = Color.LightSkyBlue;
            lblConnect.Visible = true;
            cmbSerial.Visible = true;
            btnConectar.Visible = true;
            cmbParo.Visible = false;
            lblParo.Visible = false;
            lblTiempoEnParo.Visible = false;
            lblTiempoParoActual.Visible = false;
            btnCerrar.Visible = false;
            lblStatus.Visible = false;
            lblFondoGris.Visible = false;
            lblUsuario.Visible = false;
            lblPassword.Visible = false;
            lblStat.Visible = true;
            lblStatText.Visible = true;
            lblMeta.Visible = true;
            rbtnBook.Visible = true;
            rbtnEmpaque.Visible = true;
            rbtnPrensa.Visible = true;
            lblConfirm.Visible = true;
            txtConfirm.Visible = true;
            txtMeta.Visible = true;

            txtUsuario.Visible = false;
            txtPassword.Visible = false;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;

            rellenarCmbSerial();
        }
        private void LoopDatos_Tick(object sender, EventArgs e)
        {
            if(!bandReconex)
            {
                if (bandPuertoAbierto)
                {
                    if (!puerto.IsOpen)
                    {
                        loopDatos.Stop();
                        conectarArduino();
                    }
                }
            }    
        }
       private void detectarArduino()
        {
            bool flag = false;
            String[] ports = SerialPort.GetPortNames();
            String[] substringsPorts;
            foreach(string port in ports)
            {
                substringsPorts = port.Split('M');
                if (Convert.ToInt16(substringsPorts[1]) > 3)
                {
                    strPuerto = port;
                    flag = true;
                    break;
                }
            }
            if (!puerto.IsOpen)
            {
                if (!flag && cmbSerial.Text!= "")
                    strPuerto = cmbSerial.Text;
                if (strPuerto != "")
                {
                    puerto = new SerialPort(strPuerto);
                    puerto.BaudRate = 9600;
                    puerto.Parity = Parity.None;
                    puerto.StopBits = StopBits.One;
                    puerto.DataBits = 8;
                    conectarArduino();
                }
                if (puerto.IsOpen)
                {
                    backgroundColor = Color.DarkOrange;
                    Properties.Settings.Default.FormBackground = backgroundColor;
                    Properties.Settings.Default.Save();
                    this.BackColor = backgroundColor;
                    lblCerrar.BackColor = Color.DarkOrange;
                    lblEstatus.BackColor = Color.DarkOrange;

                    lblConnect.Visible = false;
                    cmbSerial.Visible = false;
                    btnConectar.Visible = false;
                    cmbParo.Visible = true;
                    lblParo.Visible = true;
                    lblTiempoEnParo.Visible = true;
                    lblTiempoParoActual.Visible = true;
                    lblStatus.Visible = true;
                    lblStatus.Text = "STOP";
                    btnCerrar.Visible = true;
                    lblStat.Visible = false;
                    lblStatText.Visible = false;
                    lblMeta.Visible = false;
                    rbtnBook.Visible = false;
                    rbtnEmpaque.Visible = false;
                    rbtnPrensa.Visible = false;
                    lblConfirm.Visible = false;
                    txtConfirm.Visible = false;
                    txtMeta.Visible = false;
                }

            }


        }


        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(!actualizar)
            {
                try
                {

                    strDatos = puerto.ReadLine();
                    string[] substrings = strDatos.Split('/');
                    if (substrings[0] == "~")
                    {
                        strMaquinaTrabajandoArd = substrings[1];
                        strStat = substrings[1];
                        datoMaquinaTrabajando = Convert.ToInt16(strMaquinaTrabajandoArd);
                    }
                    else
                    {
                        errorReport("Error con los datos recibidos, revisar puerto!\nPuerto actual: " + strPuerto+"\nUsar un puerto diferente!");
                        puerto.Close();
                        bandCambioPuerto = true;
                        changePort = true;
                    }
                }
                catch (Exception error)
                {
                    
                    if(contDatosErroneos > 2)
                    {
                        errorReport("Error con los datos recibidos" +
                        "\nError:" + error.ToString());
                        puerto.Close();
                        conectarArduino();
                    }
                    contDatosErroneos++;
                }
            }   
        }
        private void LoopArduino_Tick(object sender, EventArgs e)
        {
            if(changePort)
            {
                pantallaConexionArduino();
                changePort = false;
            }
            if (!intentoReconexion)
            {
                if (ipEncontrada)
                {
                    if (puerto.IsOpen)
                    {    
                        if (paroMaquina)
                        {
                            if (!pantallaUsuario)
                            {
                                if (bandParoMaquina)
                                {
                                    strHoraParo = strHoraCompleta + " " + strFecha;
                                    timerTiempoParo.Enabled = true;
                                    bandParoMaquina = false;
                                }
                                callWindow.Enabled = true;
                                backgroundColor = Color.DarkOrange;
                                Properties.Settings.Default.FormBackground = backgroundColor;
                                Properties.Settings.Default.Save();
                                this.BackColor = backgroundColor;
                                lblCerrar.BackColor = Color.DarkOrange;
                                lblEstatus.BackColor = Color.DarkOrange;
                                objAsignacion.maquinaCorriendo(0, numeroMaquina);
                                cmbParo.Visible = true;
                                lblParo.Visible = true;
                                lblTiempoEnParo.Visible = true;
                                lblTiempoParoActual.Visible = true;
                                btnCerrar.Visible = true;
                                lblStatus.Visible = true;
                                lblStatus.Text = "STOP";
                                lblStat.Visible = false;
                                lblStatText.Visible = false;
                                lblMeta.Visible = false;
                                rbtnBook.Visible = false;
                                rbtnEmpaque.Visible = false;
                                rbtnPrensa.Visible = false;
                                lblConfirm.Visible = false;
                                txtConfirm.Visible = false;
                                txtMeta.Visible = false;
                            }

                        }
                        else
                        {
                            if (!bandParoMaquina)
                                
                            {
                                
                                timerTiempoParo.Enabled = false;
                                if (tiempoParo < 60)
                                {
                                    strTiempoParo = "1 minuto";
                                }
                                else if (tiempoParo > 60 && tiempoParo < 96)
                                {
                                    tiempoParoMinutos = tiempoParo / 60;
                                    strTiempoParo = Convert.ToString(Math.Round(tiempoParoMinutos)) + " minuto";

                                }
                                else if (tiempoParo > 96)
                                {
                                    tiempoParoMinutos = tiempoParo / 60;
                                    strTiempoParo = Convert.ToString(Math.Round(tiempoParoMinutos)) + " minutos";
                                }
                                bandParoMaquina = true;
                                tiempoParo = 0;
                                if (cmbParo.Text == "" || pantallaUsuario == true)
                                {
                                    tipo_Paro = "0 - Paro sin captura";
                                }
                                else
                                {
                                    string numP = objAsignacionParo.mostrarParoAsignado(cmbParo.Text); 
                                    tipo_Paro = numP + " - " + cmbParo.Text;
                                }
                                if (eventCmb)
                                {
                                    cmbParo.Items.RemoveAt(cmblen);
                                    eventCmb = false;
                                }
                                objParo.insertarParo(numeroMaquina, strHoraParo, turnoActual, tipo_Paro, strTiempoParo);
                                cmbParo.SelectedIndex = -1;
                                cmbParo.Items.Clear();
                                cmbFallas.Items.Clear();
                                cmbProceso.Items.Clear();
                                InitializeContextMenu();
                            }
                            callWindow.Enabled = false;
                            if (this.TopMost && !prodOpen && !userOpen && !generarRevision)
                                this.TopMost = false;
                            backgroundColor = Color.LimeGreen;
                            Properties.Settings.Default.FormBackground = backgroundColor;
                            Properties.Settings.Default.Save();
                            this.BackColor = backgroundColor;
                            lblCerrar.BackColor = Color.LimeGreen;
                            lblEstatus.BackColor = Color.LimeGreen;
                            objAsignacion.maquinaCorriendo(1, numeroMaquina);
                            txtUsuario.Visible = false;
                            txtPassword.Visible = false;
                            cmbParo.Visible = false;
                            cmbFallas.Visible = false;
                            cmbProceso.Visible = false;
                            lblUsuario.Visible = false;
                            lblPassword.Visible = false;
                            lblOpcion.Visible = false;
                            lblFondoGris.Visible = false;
                            btnAceptar.Visible = false;
                            btnCancelar.Visible = false;
                            lblParo.Visible = false;
                            lblTiempoEnParo.Visible = false;
                            lblTiempoParoActual.Visible = false;
                            btnCerrar.Visible = false;
                            lblStatus.Visible = true;
                            lblStatus.Text = "RUNNING";
                            pantallaUsuario = false;
                            cmbFallas.SelectedIndex = -1;
                            cmbProceso.SelectedIndex = -1;
                            txtUsuario.Text = "";
                            txtPassword.Text = "";
                            lblStat.Visible = true;
                            lblStatText.Visible = true;
                            lblMeta.Visible = true;
                            rbtnBook.Visible = true;
                            rbtnEmpaque.Visible = true;
                            rbtnPrensa.Visible = true;
                            lblConfirm.Visible = true;
                            txtConfirm.Visible = true;
                            txtMeta.Visible = true;


                        }
                        if (!bandMaquina)
                        {
                            bandDiscProd = discProd;
                            bandMaquina = true;
                        }
                        else if (bandMaquina)
                        {
                            band2DiscProd = discProd;
                            bandMaquina = false;
                        }
                        if (bandDiscProd != band2DiscProd && contMaquinaCorriendo < 5)
                        {
                            contMaquinaCorriendo += 1;
                          
                        }
                        if (datoMaquinaTrabajando == 1)
                        {
                            paroMaquina = false;      
                        }
                        if(bandDiscProd == band2DiscProd)
                        {
                            contRun += 1;
                        }
                        else
                        {
                            contRun = 0;
                        }
                        if (datoMaquinaTrabajando == 0)
                        {
                            paroMaquina = true;
                           
                           
                        }
                        


                    }

                }
                else
                {
                    if(!bandErrorIP)
                    {
                        bandErrorIP = true;
                        conectarMaquina();
                    }
                    
                }
            }
            if(contEsperaConexion > 6)
            {
                intentoReconexion = false;
                timerReconexion.Stop();
                contEsperaConexion = 0;
            }
            
            
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {      
            if (cmbSerial.Text != "" && !puerto.IsOpen)
            {
                bandCambioPuerto = false;
                strPuerto = cmbSerial.Text;
                puerto = new SerialPort(strPuerto);
                puerto.BaudRate = 9600;
                puerto.Parity = Parity.None;
                puerto.StopBits = StopBits.One;
                puerto.DataBits = 8;

                conectarArduino();
                if (puerto.IsOpen)
                {
                    loopSerialPorts.Stop();
                    backgroundColor = Color.DarkOrange;
                    Properties.Settings.Default.FormBackground = backgroundColor;
                    Properties.Settings.Default.Save();
                    this.BackColor = backgroundColor;
                    lblCerrar.BackColor = Color.DarkOrange;
                    lblEstatus.BackColor = Color.DarkOrange;

                    lblConnect.Visible = false;
                    cmbSerial.Visible = false;
                    btnConectar.Visible = false;
                    cmbParo.Visible = true;
                    lblParo.Visible = true;
                    btnCerrar.Visible = true;
                    lblStat.Visible = false;
                    lblStatText.Visible = false;
                    lblMeta.Visible = false;
                    rbtnBook.Visible = false;
                    rbtnEmpaque.Visible = false;
                    rbtnPrensa.Visible = false;
                    lblConfirm.Visible = false;
                    txtConfirm.Visible = false;
                    txtMeta.Visible = false;
                }

            }
        }
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if(puerto.IsOpen)
            {
                ultConex = strHoraCompleta + " " + strFecha;
                objAsignacion.maquinaConectada(0, numeroMaquina, ultConex);
                objAsignacion.maquinaCorriendo(0, numeroMaquina);
                puerto.Close();
            }
            if(actualizar && !cerrar)
            {
                String userName = Environment.UserName.ToString();
                System.Diagnostics.Process.Start("\"C://Users/" + userName + "/paros vinyl/update.bat\"");
            }
            if (actualizacionCompleta && !cerrar)
            {
                String userName = Environment.UserName.ToString();
                System.Diagnostics.Process.Start("\"C://Users/" + userName + "/paros vinyl/iniciarActualizacion.bat\"");
            }




        }
        private void frmPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (!actualizar && !cerrar && !actualizacionCompleta)
                e.Cancel = true;

            if (!actualizar && !cerrar)
            {
                objAsignacion.maquinaConectada(0, numeroMaquina, ultConex);
                objAsignacion.maquinaCorriendo(0, numeroMaquina);
                timerClosed.Start();
            }
        }
        private void cmbParo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (eventCmb)
            {
                cmbParo.Items.RemoveAt(cmblen);
                eventCmb = false;
            }
            if (cmbParo.SelectedIndex != -1)
            {
                if (cmbParo.SelectedItem.ToString() == "falla de equipo")
                {
                    pantallaUsuario = true;
                    cmbParo.SelectedIndex = -1;
                    cmbFallas.SelectedIndex = -1;
                    tipoParo = 3;
                    lblFondoGris.Visible = true;
                    lblUsuario.Visible = true;
                    lblPassword.Visible = true;
                    txtUsuario.Visible = true;
                    txtPassword.Visible = true;
                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;
                    lblOpcion.Visible = true;
                    cmbParo.Visible = false;
                    lblParo.Visible = false;
                    lblTiempoEnParo.Visible = false;
                    lblTiempoParoActual.Visible = false;
                    btnCerrar.Visible = false;
                    cmbFallas.Visible = true;
                }
                else if (cmbParo.SelectedItem.ToString() == "paro programado")
                {
                    pantallaUsuario = true;
                    cmbParo.SelectedIndex = 0;
                    tipoParo = 2;
                    lblFondoGris.Visible = true;
                    lblUsuario.Visible = true;
                    lblPassword.Visible = true;
                    txtUsuario.Visible = true;
                    txtPassword.Visible = true;
                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;
                    cmbParo.Visible = false;
                    lblParo.Visible = false;
                    lblTiempoEnParo.Visible = false;
                    lblTiempoParoActual.Visible = false;
                    btnCerrar.Visible = false;
                }
                else if (cmbParo.SelectedItem.ToString() == "problemas de proceso")
                {
                    pantallaUsuario = true;
                    cmbParo.SelectedIndex = -1;
                    cmbProceso.SelectedIndex = -1;
                    tipoParo = 4;
                    lblFondoGris.Visible = true;
                    lblOpcion.Visible = true;
                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;
                    cmbParo.Visible = false;
                    lblParo.Visible = false;
                    lblTiempoEnParo.Visible = false;
                    lblTiempoParoActual.Visible = false;
                    btnCerrar.Visible = false;
                    cmbProceso.Visible = true;
                }
            }
            else
            {
                tipoParo = 1;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int retornoConsulta;

            if(tipoParo == 4)
            {
                pantallaUsuario = false;
                if (cmbProceso.SelectedIndex != -1)
                    {
                        string fallaP = objAsignacionParo.mostrarParoAsignado(cmbProceso.Text);
                        cmbParo.Items.Add(cmbProceso.Text);
                        cmblen = cmbParo.Items.Count-1;
                        cmbParo.SelectedIndex = cmblen;
                        eventCmb = true;
                        lblFondoGris.Visible = false;
                        lblUsuario.Visible = false;
                        lblPassword.Visible = false;
                        lblOpcion.Visible = false;
                        txtUsuario.Visible = false;
                        txtPassword.Visible = false;
                        btnAceptar.Visible = false;
                        btnCancelar.Visible = false;
                        cmbFallas.Visible = false;
                        cmbProceso.Visible = false;
                        cmbParo.Visible = true;
                        lblParo.Visible = true;
                        lblTiempoEnParo.Visible = true;
                        lblTiempoParoActual.Visible = true;
                        btnCerrar.Visible = true;
                        cmbFallas.SelectedIndex = -1;
                        cmbProceso.SelectedIndex = -1;
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                    }
                else
                    {
                    
                    pantallaUsuario = true;
                    cmbParo.SelectedIndex = -1;
                    cmbProceso.SelectedIndex = -1;
                    tipoParo = 4;
                    lblFondoGris.Visible = true;
                    lblOpcion.Visible = true;
                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;
                    cmbParo.Visible = false;
                    lblParo.Visible = false;
                    lblTiempoEnParo.Visible = false;
                    lblTiempoParoActual.Visible = false;
                    btnCerrar.Visible = false;
                    cmbProceso.Visible = true;
                    MessageBox.Show("Seleccione una opción valida");
                }
               
            }
            if(txtUsuario.Text != "" || txtPassword.Text != "")
            {
                retornoConsulta = objUsuarios.buscarUsuarios(txtUsuario.Text, txtPassword.Text, tipoParo);
                if(retornoConsulta == 0)
                {
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
                else if(retornoConsulta == 1)
                {
                    pantallaUsuario = false;
                    cmbParo.SelectedIndex = 0;
                    lblFondoGris.Visible = false;
                    lblUsuario.Visible = false;
                    lblPassword.Visible = false;
                    lblOpcion.Visible = false;
                    txtUsuario.Visible = false;
                    txtPassword.Visible = false;
                    btnAceptar.Visible = false;
                    btnCancelar.Visible = false;
                    cmbFallas.Visible = false;
                    cmbProceso.Visible = false;
                    cmbParo.Visible = true;
                    lblParo.Visible = true;
                    lblTiempoEnParo.Visible = true;
                    lblTiempoParoActual.Visible = true;
                    btnCerrar.Visible = true;
                    cmbFallas.SelectedIndex = -1;
                    cmbProceso.SelectedIndex = -1;
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
                else if(retornoConsulta == 2)
                {
                    pantallaUsuario = false;
                    if (cmbFallas.SelectedIndex != -1)
                    {
                        cmbParo.Items.Add(cmbFallas.Text);
                        cmblen = cmbParo.Items.Count - 1;
                        cmbParo.SelectedIndex = cmblen;
                        eventCmb = true;
                        lblFondoGris.Visible = false;
                        lblUsuario.Visible = false;
                        lblPassword.Visible = false;
                        lblOpcion.Visible = false;
                        txtUsuario.Visible = false;
                        txtPassword.Visible = false;
                        btnAceptar.Visible = false;
                        btnCancelar.Visible = false;
                        cmbFallas.Visible = false;
                        cmbProceso.Visible = false;
                        cmbParo.Visible = true;
                        lblParo.Visible = true;
                        lblTiempoEnParo.Visible = true;
                        lblTiempoParoActual.Visible = true;
                        btnCerrar.Visible = true;
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                        cmbFallas.SelectedIndex = -1;
                        cmbProceso.SelectedIndex = -1;
                    }
                    else
                    {
                        pantallaUsuario = true;
                        cmbParo.SelectedIndex = -1;
                        cmbFallas.SelectedIndex = -1;
                        tipoParo = 3;
                        lblFondoGris.Visible = true;
                        lblUsuario.Visible = true;
                        lblPassword.Visible = true;
                        txtUsuario.Visible = true;
                        txtPassword.Visible = true;
                        btnAceptar.Visible = true;
                        btnCancelar.Visible = true;
                        lblOpcion.Visible = true;
                        cmbParo.Visible = false;
                        lblParo.Visible = false;
                        lblTiempoEnParo.Visible = false;
                        lblTiempoParoActual.Visible = false;
                        btnCerrar.Visible = false;
                        cmbFallas.Visible = true;
                        MessageBox.Show("Seleccione una opción valida");
                    }
                    
                }
                

            }
            else if (tipoParo != 4)
            {
                MessageBox.Show("Llenar todos los campos");
            }
            
        }
    }

    
}
