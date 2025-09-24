using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_paros_vinyl
{
    public partial class FormUsuario : Form
    {

        Clases.CUsuarios objUsuario = new Clases.CUsuarios();
        FormProduccion objFormProduccion;
        frmPrincipal objForm1;
        int tipoParo, resultado;
        String numUsuario, password;
        bool correctUser = false;
        public int tipoUsuario = 0;

        public FormUsuario()
        {
            InitializeComponent();
        }

        public FormUsuario(FormProduccion objFormProduccion, int tipoParo)
        {
            InitializeComponent();
            resultado = 0;
            tipoUsuario = 1;
            this.tipoParo = tipoParo;
            this.objFormProduccion = objFormProduccion;
        }

        public FormUsuario(frmPrincipal objForm1, int tipoParo)
        {
            InitializeComponent();
            resultado = 0;
            tipoUsuario = 2;
            this.tipoParo = tipoParo;
            this.objForm1 = objForm1;
        }

        private void FormUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(tipoUsuario == 1)
            {
                objFormProduccion.resultadoUsuario = resultado;
                objFormProduccion.Enabled = true;
            }
            else if(tipoUsuario == 2)
            {
                objForm1.resultadoCerrar = resultado;
                objForm1.Enabled = true;
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsuario.Text != "")
            {
                numUsuario = txtUsuario.Text;
                password = txtPassword.Text;
                resultado = objUsuario.buscarUsuarios(numUsuario, password, tipoParo);
                if (resultado != 0)
                {
                    if(tipoUsuario == 1)
                    {
                        objFormProduccion.resultadoUsuario = resultado;
                        objFormProduccion.Enabled = true;
                    }
                    else if ( tipoUsuario == 2)
                    {
                        objForm1.resultadoCerrar = resultado;
                        objForm1.Enabled = true;
                    }
                    correctUser = true;
                    this.Close();
                }
                else
                {
                    txtPassword.Text = "";
                    txtUsuario.Text = "";
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            correctUser = false;
            if(tipoUsuario == 1)
            {
                objFormProduccion.resultadoUsuario = 0;
                objFormProduccion.Enabled = true;
            }
            else if(tipoUsuario == 2)
            {
                objForm1.resultadoCerrar = 0;
                objForm1.Enabled = true;
            }
            
            this.Close();
        }
    }
}
