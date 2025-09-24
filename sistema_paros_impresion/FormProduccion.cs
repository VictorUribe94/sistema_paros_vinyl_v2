using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static sistema_paros_vinyl.Clases.DatosGlobales;

namespace sistema_paros_vinyl
{
    public partial class FormProduccion : Form
    {
        Clases.CProduccion objProduccion = new Clases.CProduccion();
        List<Label> labels = new List<Label>();
        List<String> rechEmpaque = new List<String>();
        List<String> strConfirm = new List<String>();
        List<String> rechPrensa = new List<String>();
        List<String> listHoraJ = new List<String>();
        List<String> listHoraK = new List<String>();
        List<TextBox> txtBox = new List<TextBox>();
        String turnoActual, numeroMaquina, strHora, strMinuto, strFecha, strDia, strMes, strYear;
        frmPrincipal objFrmPrincipal;
        public FormUsuario objVisualUsuario;
        Clases.CUsuarios objUsuario = new Clases.CUsuarios();
        int malos = 0, sumRech = 0, rech = 0;
        int tipoFormato = 0;
        double tiempoCiclo = 0;
        bool sobreescribir = false;
        public int resultadoUsuario = 0, camb_Sobre = 0;
        public bool usuarioCreated = false;
        public FormProduccion()
        {
            InitializeComponent();
        }

        public FormProduccion(frmPrincipal objFrmPrincipal, String turnoActual, String numeroMaquina)
        {
            InitializeComponent();
            this.turnoActual = turnoActual;
            this.objFrmPrincipal = objFrmPrincipal;
            this.numeroMaquina = numeroMaquina;
            this.Text = "Registro de produccion de la prensa " + numeroMaquina;
            seleccionarTurno();
            cmbTurno.Enabled = false;
            dtpFecha.Enabled = false;
            rellenarEmpaque();
            rellenarList();
            rellenarPrensa();
            rellenarTxt();
            rellenarHoraJ();
            rellenarHoraK();
            seleccionarHora();
            seleccionarFecha();
            mostrarCiclo();
            seleccionIndexCmb();
            ponerOrdenActual();
            centrarForm();
        }

        public void ponerOrdenActual()
        {
            txtOrden.Text = objProduccion.currentOrder(numeroMaquina);
        }

        public void mostrarCiclo()
        {
            tiempoCiclo = objProduccion.mostrarCiclo(numeroMaquina, cmbTurno.SelectedItem.ToString(), strFecha);
            txtCiclo.Text = Convert.ToString(tiempoCiclo);
        }

        public void rellenarHoraJ()
        {
            listHoraJ.Add("07:45");
            listHoraJ.Add("08:45");
            listHoraJ.Add("09:45");
            listHoraJ.Add("10:45");
            listHoraJ.Add("11:45");
            listHoraJ.Add("12:45");
            listHoraJ.Add("13:45");
            listHoraJ.Add("14:45");
            listHoraJ.Add("15:45");
            listHoraJ.Add("16:45");
            listHoraJ.Add("17:45");
            listHoraJ.Add("18:45");
        }

        public void rellenarHoraK()
        {
            listHoraK.Add("19:45");
            listHoraK.Add("20:45");
            listHoraK.Add("21:45");
            listHoraK.Add("22:45");
            listHoraK.Add("23:45");
            listHoraK.Add("00:45");
            listHoraK.Add("01:45");
            listHoraK.Add("02:45");
            listHoraK.Add("03:45");
            listHoraK.Add("04:45");
            listHoraK.Add("05:45");
            listHoraK.Add("06:45");
        }

        public void bloquearBotones()
        {
            btnCambiar.Enabled = false;
            btnConsulta.Enabled = false;
        }

        public void desbloquearBotones()
        {
            btnCambiar.Enabled = true;
            btnConsulta.Enabled = true;
        }

        public void seleccionarFecha()
        {
            if(Convert.ToInt16(strHora)<18 && turnoActual == "K")
            {
                dtpFecha.Value = DateTime.Now.AddDays(-1);
            }
            else
            {
                dtpFecha.Value = DateTime.Now;
            }
            strDia = dtpFecha.Value.ToString("dd");
            strMes = dtpFecha.Value.ToString("MM");
            strYear = dtpFecha.Value.ToString("yyyy");
            strFecha = strYear + "-" + strMes + "-" + strDia;
        }
        public void seleccionarTurno()
        {
            if(turnoActual == "J")
            {
                cmbTurno.SelectedIndex = 0;
            }
            else
            {
                cmbTurno.SelectedIndex = 1;
            }
        }

        public void seleccionarHora()
        {
            int i = 0, restMin = 0;
            strHora = DateTime.Now.ToString("HH");
            strMinuto = DateTime.Now.ToString("mm");
            cmbHora.Items.Clear();
            if (turnoActual == "J")
            {
                foreach(String str in listHoraJ)
                {
                    cmbHora.Items.Add(str);
                }
            }
            else
            {
                foreach(String str in listHoraK)
                {
                    cmbHora.Items.Add(str);
                }
            }
            foreach(String item in cmbHora.Items)
            {
                String[] arrHora = item.Split(':');
                if(strHora == arrHora[0])
                {
                    if(Convert.ToInt16(strMinuto) < Convert.ToInt16(arrHora[1]))
                    {
                        restMin = Convert.ToInt16(arrHora[1]) - Convert.ToInt16(strMinuto);
                        if(restMin <= 10)
                        {
                            cmbHora.SelectedIndex = i;
                        }
                        else
                        {
                            if(i==0)
                            {
                                cmbHora.SelectedIndex = i;
                            }
                            else if(i>0)
                            {
                                cmbHora.SelectedIndex = i-1;
                            }
                        }
                    }
                    else if(Convert.ToInt16(strMinuto) >= Convert.ToInt16(arrHora[1]))
                    {
                        cmbHora.SelectedIndex = i;
                    }
                }
                i++;
            }
        }

        public void seleccionIndexCmb()
        {
            cmbFormato.SelectedIndex = 0;
        }

        public void rellenarList()
        {
            labels.Add(lblRech1);
            labels.Add(lblRech2);
            labels.Add(lblRech3);
            labels.Add(lblRech4);
            labels.Add(lblRech5);
            labels.Add(lblRech6);
            labels.Add(lblRech7);
            labels.Add(lblRech8);
            labels.Add(lblRech9);
            labels.Add(lblRech10);
        }

        public void rellenarTxt()
        {
            txtBox.Add(txtRech1);
            txtBox.Add(txtRech2);
            txtBox.Add(txtRech3);
            txtBox.Add(txtRech4);
            txtBox.Add(txtRech5);
            txtBox.Add(txtRech6);
            txtBox.Add(txtRech7);
            txtBox.Add(txtRech8);
            txtBox.Add(txtRech9);
            txtBox.Add(txtRech10);
        }

        public void rellenarEmpaque()
        {
            rechEmpaque.Add("Etiquetas");
            rechEmpaque.Add("NonFill/Stitching");
            rechEmpaque.Add("Daño en cortadora");
            rechEmpaque.Add("Tallon");
            rechEmpaque.Add("Incrustacion");
            rechEmpaque.Add("Color");
            rechEmpaque.Add("Deformacion");
            rechEmpaque.Add("Dimple/abolladuras");
            rechEmpaque.Add("Sobrantes");
            rechEmpaque.Add("Otros");
        }

        public void rellenarPrensa()
        {
            rechPrensa.Add("Etiquetas");
            rechPrensa.Add("NonFill/Stitching");
            rechPrensa.Add("Estampador dañado");
            rechPrensa.Add("Disco pegado en molde");
            rechPrensa.Add("Daño en cortadora");
            rechPrensa.Add("Incrustacion");
            rechPrensa.Add("Rebaba en diametro interno/externo");
            rechPrensa.Add("Rebaba del hold stamper");
            rechPrensa.Add("Daño por portadisco desalineado");
            rechPrensa.Add("Otros");
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sumRech = 0;
            if(txtBuenos.Text != "" && txtMalos.Text != "" && txtRegistro.Text != "" && txtOrden.Text != ""  && cmbGrupo.SelectedIndex != -1 && txtCiclo.Text != "")
            {
                bool datosCompletos = false;
                if(tipoFormato == 2)
                {
                    if(txtLabelB.Text != "" && txtLabelA.Text != "")
                    {
                        datosCompletos = true;
                    }
                }
                else if(tipoFormato == 1)
                {
                    datosCompletos = true;
                }
                if(datosCompletos)
                {
                    if (Convert.ToInt16(txtMalos.Text) > 0)
                    {
                        malos = Convert.ToInt16(txtMalos.Text);
                        foreach (TextBox txt in txtBox)
                        {
                            if (txt.Text == "")
                            {
                                rech = 0;
                            }
                            else
                            {
                                rech = Convert.ToInt16(txt.Text);
                            }
                            sumRech = sumRech + rech;
                        }
                        if (malos == sumRech)
                        {
                            if (!objProduccion.boolProduccion(numeroMaquina, strFecha, turnoActual, cmbHora.SelectedItem.ToString(), Convert.ToString(tipoFormato)))
                            {
                                guardarProduccion();
                            }
                            else
                            {
                                string caption = "Datos existentes en base de datos!";
                                DialogResult result;
                                string message = "Ya se encuentran guardados datos de la produccion con la fecha, hora, turno y maquina actuales, desea sobreescribir los datos?";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                result = MessageBox.Show(message, caption, buttons);

                                if (result == DialogResult.Yes)
                                {

                                    camb_Sobre = 2;
                                    objVisualUsuario = new FormUsuario(this, 2);
                                    usuarioCreated = true;
                                    objVisualUsuario.Show();
                                    this.Enabled = false;
                                    objVisualUsuario.Owner = this;
                                    objVisualUsuario.FormClosed += ObjVisualUsuario_FormClosed;
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Las cantidades de rechazo y discos malos no coinciden!");
                        }
                    }
                    else
                    {
                        if (!objProduccion.boolProduccion(numeroMaquina, strFecha, turnoActual, cmbHora.SelectedItem.ToString(), Convert.ToString(tipoFormato)))
                        {
                            guardarProduccion();
                        }
                        else
                        {
                            string caption = "Datos existentes en base de datos!";
                            DialogResult result;
                            string message = "Ya se encuentran guardados datos de la produccion con la fecha, hora, turno y maquina actuales, desea sobreescribir los datos?";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            result = MessageBox.Show(message, caption, buttons);

                            if (result == DialogResult.Yes)
                            {
                                camb_Sobre = 2;
                                objVisualUsuario = new FormUsuario(this, 2);
                                usuarioCreated = true;
                                objVisualUsuario.Show();
                                this.Enabled = false;
                                objVisualUsuario.Owner = this;
                                objVisualUsuario.FormClosed += ObjVisualUsuario_FormClosed;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Completar todos los espacios con *");
                }
                
            }
            else
            {
                MessageBox.Show("Completar todos los espacios con *");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            camb_Sobre = 1;          
            objVisualUsuario = new FormUsuario(this, 2);
            usuarioCreated = true;
            objVisualUsuario.Show();
            this.Enabled = false;
            objVisualUsuario.Owner = this;
            objVisualUsuario.FormClosed += ObjVisualUsuario_FormClosed;
        }

        private void txtPrensados_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBuenos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmpacados_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTurno.SelectedIndex == 0)
            {
                cmbHora.Text = "";
                cmbHora.Items.Clear();
                foreach (String str in listHoraJ)
                {
                    cmbHora.Items.Add(str);
                }
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                cmbHora.Text = "";
                cmbHora.Items.Clear();
                foreach (String str in listHoraK)
                {
                    cmbHora.Items.Add(str);
                }
            }
        }

        private void txtCiclo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            String message;
            message = obtenerProduccionMsg();
            if(message != "")
            {
                MessageBox.Show(message, "Datos Capturados en base de datos");
            }
            else
            {
                MessageBox.Show("No hay datos guardados!", "Datos Capturados en base de datos");
            }

        }

        private void txtRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;   
            }
            
        }

        private void txtRegistro_TextChanged(object sender, EventArgs e)
        {
            if(txtRegistro.Text!="")
            {
                txtNombre.Text = objUsuario.obtenerNombre(txtRegistro.Text);
            }
            else
            {
                txtNombre.Text = "";
            }
            
        }

        public void obtenerProduccion()
        {
            int produccion = 0;
            String[] substrings;
            strConfirm.Clear();
            strConfirm = objProduccion.mostrarProduccion(numeroMaquina, turnoActual, strFecha, tipoFormato);
            if (strConfirm.Count > 0)
            {
                foreach (String str in strConfirm)
                {
                    substrings = str.Split(',');
                    produccion = produccion + Convert.ToInt16(substrings[0]);          
                }
                txtConfirm.Text = Convert.ToString(produccion);
            }
            else
            {
                txtConfirm.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            centrarForm();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public String obtenerProduccionMsg()
        {
            String[] substrings;
            String message = "";
            if(tipoFormato == 1)
            {
                message = "Formato Empaque\nHora\tDiscos buenos\tDiscos malos\n";
            }
            else if(tipoFormato == 2)
            {
                message = "Formato Prensa\nHora\tDiscos buenos\tDiscos malos\n";
            }
            
            strConfirm.Clear();
            strConfirm = objProduccion.mostrarProduccion(numeroMaquina, turnoActual, strFecha, tipoFormato);
            if (strConfirm.Count > 0)
            {
                foreach (String str in strConfirm)
                {
                    substrings = str.Split(',');
                    message = message + substrings[2] + "\t" + substrings[0] + "\t\t" + substrings[1] + "\n";
                    
                }
                
            }
            else
            {
                message = "";
            }
            return message;
        }

        private void cmbFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cmbFormato.SelectedIndex == 0)
            {
                int i = 0;
                foreach(Label lbl in labels)
                {
                    lbl.Text = rechEmpaque[i];
                    i++;
                }
                tipoFormato = 1;
                lblFormato.Text = "Formato Empaque";
                ocultarDesperdicio();
                obtenerProduccion();
                
            }
            else if(cmbFormato.SelectedIndex == 1)
            {
                int i = 0;
                foreach (Label lbl in labels)
                {
                    lbl.Text = rechPrensa[i];
                    i++;
                }
                tipoFormato = 2;
                lblFormato.Text = "Formato Prensa";
                mostrarDesperdicio();
                obtenerProduccion();
            }
        }

        public void ocultarDesperdicio()
        {
            txtLabelA.Visible = false;
            txtLabelB.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
        }

        public void mostrarDesperdicio()
        {
            txtLabelA.Visible = true;
            txtLabelB.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
        }

        private void txtRech1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuenos_TextChanged(object sender, EventArgs e)
        {
            obtenerYield();
        }

        private void txtMalos_TextChanged(object sender, EventArgs e)
        {
            obtenerYield();
        }

        public void obtenerYield()
        {
            double dblYield = 0, produccion=0;
            if(txtBuenos.Text!="" && txtMalos.Text!="")
            {
                produccion = Convert.ToDouble(txtBuenos.Text) + Convert.ToDouble(txtMalos.Text);
                if(produccion > 0)
                {
                    dblYield = Convert.ToDouble(txtBuenos.Text) / produccion;
                    dblYield = dblYield * 100;
                    txtYield.Text = Convert.ToString(Math.Round(dblYield)) + "%";
                }
                else
                {
                    txtYield.Text = "0%";
                }
                
            }
            else
            {
                txtYield.Text = "";
            }
        }

        public void centrarForm()
        {
            this.CenterToScreen();
        }

        private void ObjVisualUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            usuarioCreated = false;
            if(camb_Sobre == 1)
            {
                if (resultadoUsuario != 0)
                {
                    cmbTurno.Enabled = true;
                    dtpFecha.Enabled = true;
                }
            }
            else if(camb_Sobre == 2)
            {
                if (resultadoUsuario != 0)
                {
                    modificarProduccion();
                }   
            }
            camb_Sobre = 0;
        }

        public void guardarProduccion()
        {
            String strTxt = "";
            String strRechazo = "";
            int i = 0;
            foreach (TextBox txt in txtBox)
            {
                if(i>0)
                {
                    strRechazo += ",";
                }
                if (txt.Text == "")
                {
                    strTxt = "0";
                }
                else
                {
                    strTxt = txt.Text;
                }
                strRechazo += strTxt;
                txt.Text = "";
                i++;
            }
            objProduccion.insertarProduccion(turnoActual, strFecha, cmbHora.SelectedItem.ToString(), numeroMaquina, txtBuenos.Text, txtMalos.Text, txtYield.Text, strRechazo, Convert.ToString(tipoFormato), txtOrden.Text, txtPo.Text, cmbGrupo.SelectedItem.ToString(), txtRegistro.Text, txtNombre.Text, txtCiclo.Text, txtLabelA.Text, txtLabelB.Text);
            txtLabelA.Text = "";
            txtLabelB.Text = "";
            MessageBox.Show("Produccion guardada", "Aviso");
            obtenerProduccion();
        }

        public void modificarProduccion()
        {
            String strTxt = "";
            String strRechazo = "";
            int i = 0;
            foreach (TextBox txt in txtBox)
            {
                if (i > 0)
                {
                    strRechazo += ",";
                }
                if (txt.Text == "")
                {
                    strTxt = "0";
                }
                else
                {
                    strTxt = txt.Text;
                }
                strRechazo += strTxt;
                txt.Text = "";
                i++;
            }
            objProduccion.modificarProduccion(turnoActual, strFecha, cmbHora.SelectedItem.ToString(), numeroMaquina, txtBuenos.Text, txtMalos.Text, txtYield.Text, strRechazo, Convert.ToString(tipoFormato), txtOrden.Text, txtPo.Text, cmbGrupo.SelectedItem.ToString(),txtRegistro.Text,txtNombre.Text, txtCiclo.Text, txtLabelA.Text, txtLabelB.Text);
            MessageBox.Show("Produccion guardada", "Aviso");
            obtenerProduccion();
        }
    }
}
