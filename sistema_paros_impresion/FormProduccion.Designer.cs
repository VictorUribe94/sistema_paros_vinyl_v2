namespace sistema_paros_vinyl
{
    partial class FormProduccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuenos = new System.Windows.Forms.TextBox();
            this.txtMalos = new System.Windows.Forms.TextBox();
            this.txtYield = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.lblRech1 = new System.Windows.Forms.Label();
            this.txtRech1 = new System.Windows.Forms.TextBox();
            this.txtRech2 = new System.Windows.Forms.TextBox();
            this.lblRech2 = new System.Windows.Forms.Label();
            this.txtRech3 = new System.Windows.Forms.TextBox();
            this.lblRech3 = new System.Windows.Forms.Label();
            this.txtRech4 = new System.Windows.Forms.TextBox();
            this.lblRech4 = new System.Windows.Forms.Label();
            this.txtRech5 = new System.Windows.Forms.TextBox();
            this.lblRech5 = new System.Windows.Forms.Label();
            this.txtRech10 = new System.Windows.Forms.TextBox();
            this.lblRech10 = new System.Windows.Forms.Label();
            this.txtRech9 = new System.Windows.Forms.TextBox();
            this.lblRech9 = new System.Windows.Forms.Label();
            this.txtRech8 = new System.Windows.Forms.TextBox();
            this.lblRech8 = new System.Windows.Forms.Label();
            this.txtRech7 = new System.Windows.Forms.TextBox();
            this.lblRech7 = new System.Windows.Forms.Label();
            this.txtRech6 = new System.Windows.Forms.TextBox();
            this.lblRech6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.txtPo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLabelA = new System.Windows.Forms.TextBox();
            this.txtLabelB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTurno
            // 
            this.cmbTurno.Enabled = false;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "J",
            "K"});
            this.cmbTurno.Location = new System.Drawing.Point(15, 33);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(53, 21);
            this.cmbTurno.TabIndex = 0;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(12, 79);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "fecha";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(15, 119);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(138, 23);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "cambiar turno y/o fecha";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(322, 14);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(73, 20);
            this.txtRegistro.TabIndex = 7;
            this.txtRegistro.TextChanged += new System.EventHandler(this.txtRegistro_TextChanged);
            this.txtRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistro_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(322, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "*Discos buenos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "*Discos malos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Yield";
            // 
            // txtBuenos
            // 
            this.txtBuenos.Location = new System.Drawing.Point(100, 211);
            this.txtBuenos.MaxLength = 4;
            this.txtBuenos.Name = "txtBuenos";
            this.txtBuenos.Size = new System.Drawing.Size(73, 20);
            this.txtBuenos.TabIndex = 15;
            this.txtBuenos.TextChanged += new System.EventHandler(this.txtBuenos_TextChanged);
            this.txtBuenos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuenos_KeyPress);
            // 
            // txtMalos
            // 
            this.txtMalos.Location = new System.Drawing.Point(259, 211);
            this.txtMalos.MaxLength = 4;
            this.txtMalos.Name = "txtMalos";
            this.txtMalos.Size = new System.Drawing.Size(73, 20);
            this.txtMalos.TabIndex = 16;
            this.txtMalos.TextChanged += new System.EventHandler(this.txtMalos_TextChanged);
            this.txtMalos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMalos_KeyPress);
            // 
            // txtYield
            // 
            this.txtYield.Enabled = false;
            this.txtYield.Location = new System.Drawing.Point(374, 211);
            this.txtYield.Name = "txtYield";
            this.txtYield.Size = new System.Drawing.Size(42, 20);
            this.txtYield.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(314, 425);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(422, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Causa de rechazo";
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Items.AddRange(new object[] {
            "Formato Empaque",
            "Formato Prensa"});
            this.cmbFormato.Location = new System.Drawing.Point(179, 119);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(121, 21);
            this.cmbFormato.TabIndex = 22;
            this.cmbFormato.SelectedIndexChanged += new System.EventHandler(this.cmbFormato_SelectedIndexChanged);
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.Location = new System.Drawing.Point(21, 154);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(108, 13);
            this.lblFormato.TabIndex = 23;
            this.lblFormato.Text = "Formato Empaque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hora";
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "00:45",
            "01:45",
            "02:45",
            "03:45",
            "04:45",
            "05:45",
            "06:45",
            "07:45",
            "08:45",
            "09:45",
            "10:45",
            "11:45",
            "12:45",
            "13:45",
            "14:45",
            "15:45",
            "16:45",
            "17:45",
            "18:45",
            "19:45",
            "20:45",
            "21:45",
            "22:45",
            "23:45"});
            this.cmbHora.Location = new System.Drawing.Point(63, 179);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(66, 21);
            this.cmbHora.TabIndex = 25;
            // 
            // lblRech1
            // 
            this.lblRech1.AutoSize = true;
            this.lblRech1.Location = new System.Drawing.Point(17, 275);
            this.lblRech1.Name = "lblRech1";
            this.lblRech1.Size = new System.Drawing.Size(51, 13);
            this.lblRech1.TabIndex = 26;
            this.lblRech1.Text = "Etiquetas";
            // 
            // txtRech1
            // 
            this.txtRech1.Location = new System.Drawing.Point(195, 272);
            this.txtRech1.Name = "txtRech1";
            this.txtRech1.Size = new System.Drawing.Size(40, 20);
            this.txtRech1.TabIndex = 27;
            this.txtRech1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech1_KeyPress);
            // 
            // txtRech2
            // 
            this.txtRech2.Location = new System.Drawing.Point(195, 300);
            this.txtRech2.Name = "txtRech2";
            this.txtRech2.Size = new System.Drawing.Size(40, 20);
            this.txtRech2.TabIndex = 29;
            this.txtRech2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech1_KeyPress);
            // 
            // lblRech2
            // 
            this.lblRech2.AutoSize = true;
            this.lblRech2.Location = new System.Drawing.Point(17, 303);
            this.lblRech2.Name = "lblRech2";
            this.lblRech2.Size = new System.Drawing.Size(83, 13);
            this.lblRech2.TabIndex = 28;
            this.lblRech2.Text = "Non fill/stitching";
            // 
            // txtRech3
            // 
            this.txtRech3.Location = new System.Drawing.Point(195, 327);
            this.txtRech3.Name = "txtRech3";
            this.txtRech3.Size = new System.Drawing.Size(40, 20);
            this.txtRech3.TabIndex = 31;
            this.txtRech3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech1_KeyPress);
            // 
            // lblRech3
            // 
            this.lblRech3.AutoSize = true;
            this.lblRech3.Location = new System.Drawing.Point(17, 330);
            this.lblRech3.Name = "lblRech3";
            this.lblRech3.Size = new System.Drawing.Size(96, 13);
            this.lblRech3.TabIndex = 30;
            this.lblRech3.Text = "Daño en cortadora";
            // 
            // txtRech4
            // 
            this.txtRech4.Location = new System.Drawing.Point(195, 356);
            this.txtRech4.Name = "txtRech4";
            this.txtRech4.Size = new System.Drawing.Size(40, 20);
            this.txtRech4.TabIndex = 33;
            this.txtRech4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech1_KeyPress);
            // 
            // lblRech4
            // 
            this.lblRech4.AutoSize = true;
            this.lblRech4.Location = new System.Drawing.Point(17, 359);
            this.lblRech4.Name = "lblRech4";
            this.lblRech4.Size = new System.Drawing.Size(36, 13);
            this.lblRech4.TabIndex = 32;
            this.lblRech4.Text = "Tallon";
            // 
            // txtRech5
            // 
            this.txtRech5.Location = new System.Drawing.Point(195, 386);
            this.txtRech5.Name = "txtRech5";
            this.txtRech5.Size = new System.Drawing.Size(40, 20);
            this.txtRech5.TabIndex = 35;
            this.txtRech5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech1_KeyPress);
            // 
            // lblRech5
            // 
            this.lblRech5.AutoSize = true;
            this.lblRech5.Location = new System.Drawing.Point(17, 389);
            this.lblRech5.Name = "lblRech5";
            this.lblRech5.Size = new System.Drawing.Size(163, 13);
            this.lblRech5.TabIndex = 34;
            this.lblRech5.Text = "Rebaba diametro interno/externo";
            // 
            // txtRech10
            // 
            this.txtRech10.Location = new System.Drawing.Point(463, 386);
            this.txtRech10.Name = "txtRech10";
            this.txtRech10.Size = new System.Drawing.Size(40, 20);
            this.txtRech10.TabIndex = 45;
            this.txtRech10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech1_KeyPress);
            // 
            // lblRech10
            // 
            this.lblRech10.AutoSize = true;
            this.lblRech10.Location = new System.Drawing.Point(277, 389);
            this.lblRech10.Name = "lblRech10";
            this.lblRech10.Size = new System.Drawing.Size(163, 13);
            this.lblRech10.TabIndex = 44;
            this.lblRech10.Text = "Daño por portadisco desalineado";
            // 
            // txtRech9
            // 
            this.txtRech9.Location = new System.Drawing.Point(463, 356);
            this.txtRech9.Name = "txtRech9";
            this.txtRech9.Size = new System.Drawing.Size(40, 20);
            this.txtRech9.TabIndex = 43;
            this.txtRech9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech1_KeyPress);
            // 
            // lblRech9
            // 
            this.lblRech9.AutoSize = true;
            this.lblRech9.Location = new System.Drawing.Point(277, 359);
            this.lblRech9.Name = "lblRech9";
            this.lblRech9.Size = new System.Drawing.Size(55, 13);
            this.lblRech9.TabIndex = 42;
            this.lblRech9.Text = "Sobrantes";
            // 
            // txtRech8
            // 
            this.txtRech8.Location = new System.Drawing.Point(463, 327);
            this.txtRech8.Name = "txtRech8";
            this.txtRech8.Size = new System.Drawing.Size(40, 20);
            this.txtRech8.TabIndex = 41;
            this.txtRech8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech1_KeyPress);
            // 
            // lblRech8
            // 
            this.lblRech8.AutoSize = true;
            this.lblRech8.Location = new System.Drawing.Point(277, 330);
            this.lblRech8.Name = "lblRech8";
            this.lblRech8.Size = new System.Drawing.Size(98, 13);
            this.lblRech8.TabIndex = 40;
            this.lblRech8.Text = "Dimple/abolladuras";
            // 
            // txtRech7
            // 
            this.txtRech7.Location = new System.Drawing.Point(463, 300);
            this.txtRech7.Name = "txtRech7";
            this.txtRech7.Size = new System.Drawing.Size(40, 20);
            this.txtRech7.TabIndex = 39;
            this.txtRech7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech1_KeyPress);
            // 
            // lblRech7
            // 
            this.lblRech7.AutoSize = true;
            this.lblRech7.Location = new System.Drawing.Point(277, 303);
            this.lblRech7.Name = "lblRech7";
            this.lblRech7.Size = new System.Drawing.Size(67, 13);
            this.lblRech7.TabIndex = 38;
            this.lblRech7.Text = "Deformacion";
            // 
            // txtRech6
            // 
            this.txtRech6.Location = new System.Drawing.Point(463, 272);
            this.txtRech6.Name = "txtRech6";
            this.txtRech6.Size = new System.Drawing.Size(40, 20);
            this.txtRech6.TabIndex = 37;
            this.txtRech6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRech1_KeyPress);
            // 
            // lblRech6
            // 
            this.lblRech6.AutoSize = true;
            this.lblRech6.Location = new System.Drawing.Point(277, 275);
            this.lblRech6.Name = "lblRech6";
            this.lblRech6.Size = new System.Drawing.Size(31, 13);
            this.lblRech6.TabIndex = 36;
            this.lblRech6.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "*Grupo";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbGrupo.Location = new System.Drawing.Point(91, 33);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(50, 21);
            this.cmbGrupo.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "*Orden";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(319, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Cantidad en PO";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(403, 88);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(100, 20);
            this.txtOrden.TabIndex = 50;
            // 
            // txtPo
            // 
            this.txtPo.Location = new System.Drawing.Point(403, 121);
            this.txtPo.Name = "txtPo";
            this.txtPo.Size = new System.Drawing.Size(100, 20);
            this.txtPo.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "*Tiempo de ciclo";
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(174, 34);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(83, 20);
            this.txtCiclo.TabIndex = 53;
            this.txtCiclo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiclo_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(434, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Total confirmado";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Enabled = false;
            this.txtConfirm.Location = new System.Drawing.Point(451, 211);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(59, 20);
            this.txtConfirm.TabIndex = 55;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(25, 425);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(128, 23);
            this.btnConsulta.TabIndex = 56;
            this.btnConsulta.Text = "Consulta de produccion";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(234, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Desperdicio de Etiquetas";
            // 
            // txtLabelA
            // 
            this.txtLabelA.Location = new System.Drawing.Point(229, 170);
            this.txtLabelA.Name = "txtLabelA";
            this.txtLabelA.Size = new System.Drawing.Size(52, 20);
            this.txtLabelA.TabIndex = 58;
            this.txtLabelA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtLabelB
            // 
            this.txtLabelB.Location = new System.Drawing.Point(344, 169);
            this.txtLabelB.Name = "txtLabelB";
            this.txtLabelB.Size = new System.Drawing.Size(52, 20);
            this.txtLabelB.TabIndex = 59;
            this.txtLabelB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(184, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "*Lado A";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(297, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "*Lado B";
            // 
            // FormProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 456);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtLabelB);
            this.Controls.Add(this.txtLabelA);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPo);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRech10);
            this.Controls.Add(this.lblRech10);
            this.Controls.Add(this.txtRech9);
            this.Controls.Add(this.lblRech9);
            this.Controls.Add(this.txtRech8);
            this.Controls.Add(this.lblRech8);
            this.Controls.Add(this.txtRech7);
            this.Controls.Add(this.lblRech7);
            this.Controls.Add(this.txtRech6);
            this.Controls.Add(this.lblRech6);
            this.Controls.Add(this.txtRech5);
            this.Controls.Add(this.lblRech5);
            this.Controls.Add(this.txtRech4);
            this.Controls.Add(this.lblRech4);
            this.Controls.Add(this.txtRech3);
            this.Controls.Add(this.lblRech3);
            this.Controls.Add(this.txtRech2);
            this.Controls.Add(this.lblRech2);
            this.Controls.Add(this.txtRech1);
            this.Controls.Add(this.lblRech1);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtYield);
            this.Controls.Add(this.txtMalos);
            this.Controls.Add(this.txtBuenos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbTurno);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(544, 495);
            this.MinimumSize = new System.Drawing.Size(544, 495);
            this.Name = "FormProduccion";
            this.Text = "Produccion de la prensa ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuenos;
        private System.Windows.Forms.TextBox txtMalos;
        private System.Windows.Forms.TextBox txtYield;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label lblRech1;
        private System.Windows.Forms.TextBox txtRech1;
        private System.Windows.Forms.TextBox txtRech2;
        private System.Windows.Forms.Label lblRech2;
        private System.Windows.Forms.TextBox txtRech3;
        private System.Windows.Forms.Label lblRech3;
        private System.Windows.Forms.TextBox txtRech4;
        private System.Windows.Forms.Label lblRech4;
        private System.Windows.Forms.TextBox txtRech5;
        private System.Windows.Forms.Label lblRech5;
        private System.Windows.Forms.TextBox txtRech10;
        private System.Windows.Forms.Label lblRech10;
        private System.Windows.Forms.TextBox txtRech9;
        private System.Windows.Forms.Label lblRech9;
        private System.Windows.Forms.TextBox txtRech8;
        private System.Windows.Forms.Label lblRech8;
        private System.Windows.Forms.TextBox txtRech7;
        private System.Windows.Forms.Label lblRech7;
        private System.Windows.Forms.TextBox txtRech6;
        private System.Windows.Forms.Label lblRech6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.TextBox txtPo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLabelA;
        private System.Windows.Forms.TextBox txtLabelB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}