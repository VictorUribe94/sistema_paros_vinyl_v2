using sistema_paros_vinyl.Clases;

namespace sistema_paros_vinyl
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblConnect = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cmbSerial = new System.Windows.Forms.ComboBox();
            this.cmbParo = new System.Windows.Forms.ComboBox();
            this.lblParo = new System.Windows.Forms.Label();
            this.lblFondoGris = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.timerTiempoParo = new System.Windows.Forms.Timer(this.components);
            this.lblHoraParo = new System.Windows.Forms.Label();
            this.lblTiempoParo = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.timerProduccion = new System.Windows.Forms.Timer(this.components);
            this.timerReconexion = new System.Windows.Forms.Timer(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbFallas = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cmbProceso = new System.Windows.Forms.ComboBox();
            this.lblTiempoEnParo = new System.Windows.Forms.Label();
            this.lblTiempoParoActual = new System.Windows.Forms.Label();
            this.timerClosed = new System.Windows.Forms.Timer(this.components);
            this.timerConexion = new System.Windows.Forms.Timer(this.components);
            this.callWindow = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnProduccion = new System.Windows.Forms.Button();
            this.lblMeta = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtMeta = new System.Windows.Forms.TextBox();
            this.lblStat = new System.Windows.Forms.Label();
            this.lblStatText = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.timerRes = new System.Windows.Forms.Timer(this.components);
            this.StatusMachines = new System.Windows.Forms.Timer(this.components);
            this.lblEstatus = new System.Windows.Forms.Label();
            this.timerArdConex = new System.Windows.Forms.Timer(this.components);
            this.rbtnBook = new System.Windows.Forms.RadioButton();
            this.rbtnEmpaque = new System.Windows.Forms.RadioButton();
            this.rbtnPrensa = new System.Windows.Forms.RadioButton();
            this.lblHora1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblHora3 = new System.Windows.Forms.Label();
            this.lblHora4 = new System.Windows.Forms.Label();
            this.lblHora5 = new System.Windows.Forms.Label();
            this.lblHora6 = new System.Windows.Forms.Label();
            this.lblHora12 = new System.Windows.Forms.Label();
            this.lblHora11 = new System.Windows.Forms.Label();
            this.lblHora10 = new System.Windows.Forms.Label();
            this.lblHora9 = new System.Windows.Forms.Label();
            this.lblHora8 = new System.Windows.Forms.Label();
            this.lblHora7 = new System.Windows.Forms.Label();
            this.pr12 = new System.Windows.Forms.Label();
            this.pr11 = new System.Windows.Forms.Label();
            this.pr10 = new System.Windows.Forms.Label();
            this.pr9 = new System.Windows.Forms.Label();
            this.pr8 = new System.Windows.Forms.Label();
            this.pr7 = new System.Windows.Forms.Label();
            this.pr6 = new System.Windows.Forms.Label();
            this.pr5 = new System.Windows.Forms.Label();
            this.pr4 = new System.Windows.Forms.Label();
            this.pr3 = new System.Windows.Forms.Label();
            this.pr2 = new System.Windows.Forms.Label();
            this.pr1 = new System.Windows.Forms.Label();
            this.em12 = new System.Windows.Forms.Label();
            this.em11 = new System.Windows.Forms.Label();
            this.em10 = new System.Windows.Forms.Label();
            this.em9 = new System.Windows.Forms.Label();
            this.em8 = new System.Windows.Forms.Label();
            this.em7 = new System.Windows.Forms.Label();
            this.em6 = new System.Windows.Forms.Label();
            this.em5 = new System.Windows.Forms.Label();
            this.em4 = new System.Windows.Forms.Label();
            this.em3 = new System.Windows.Forms.Label();
            this.em2 = new System.Windows.Forms.Label();
            this.em1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConnect
            // 
            this.lblConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnect.ForeColor = System.Drawing.Color.White;
            this.lblConnect.Location = new System.Drawing.Point(42, 75);
            this.lblConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(594, 354);
            this.lblConnect.TabIndex = 0;
            this.lblConnect.Text = "CONNECT TO PRESS";
            this.lblConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(518, 460);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(256, 440);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(112, 35);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cmbSerial
            // 
            this.cmbSerial.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerial.FormattingEnabled = true;
            this.cmbSerial.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25",
            "COM26",
            "COM27",
            "COM28",
            "COM29",
            "COM30"});
            this.cmbSerial.Location = new System.Drawing.Point(36, 440);
            this.cmbSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSerial.Name = "cmbSerial";
            this.cmbSerial.Size = new System.Drawing.Size(180, 28);
            this.cmbSerial.TabIndex = 3;
            this.cmbSerial.SelectedIndexChanged += new System.EventHandler(this.cmbSerial_SelectedIndexChanged);
            // 
            // cmbParo
            // 
            this.cmbParo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParo.FormattingEnabled = true;
            this.cmbParo.Location = new System.Drawing.Point(60, 74);
            this.cmbParo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbParo.Name = "cmbParo";
            this.cmbParo.Size = new System.Drawing.Size(298, 28);
            this.cmbParo.TabIndex = 4;
            this.cmbParo.SelectedValueChanged += new System.EventHandler(this.cmbParo_SelectedValueChanged);
            // 
            // lblParo
            // 
            this.lblParo.AutoSize = true;
            this.lblParo.Location = new System.Drawing.Point(56, 49);
            this.lblParo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParo.Name = "lblParo";
            this.lblParo.Size = new System.Drawing.Size(208, 20);
            this.lblParo.TabIndex = 5;
            this.lblParo.Text = "Seleccione la causa de paro";
            // 
            // lblFondoGris
            // 
            this.lblFondoGris.BackColor = System.Drawing.Color.Gray;
            this.lblFondoGris.Location = new System.Drawing.Point(75, 32);
            this.lblFondoGris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFondoGris.Name = "lblFondoGris";
            this.lblFondoGris.Size = new System.Drawing.Size(382, 402);
            this.lblFondoGris.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(94, 143);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(236, 26);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(88, 238);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 26);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Gray;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(90, 111);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 20);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Gray;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(84, 200);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(105, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Contraseña";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Location = new System.Drawing.Point(314, 337);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 35);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(18, 500);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 20);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(207, 500);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha";
            // 
            // timerHora
            // 
            this.timerHora.Interval = 500;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // timerTiempoParo
            // 
            this.timerTiempoParo.Interval = 1000;
            this.timerTiempoParo.Tick += new System.EventHandler(this.timerTiempoParo_Tick);
            // 
            // lblHoraParo
            // 
            this.lblHoraParo.AutoSize = true;
            this.lblHoraParo.Location = new System.Drawing.Point(513, 352);
            this.lblHoraParo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraParo.Name = "lblHoraParo";
            this.lblHoraParo.Size = new System.Drawing.Size(77, 20);
            this.lblHoraParo.TabIndex = 20;
            this.lblHoraParo.Text = "hora paro";
            // 
            // lblTiempoParo
            // 
            this.lblTiempoParo.AutoSize = true;
            this.lblTiempoParo.Location = new System.Drawing.Point(512, 405);
            this.lblTiempoParo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoParo.Name = "lblTiempoParo";
            this.lblTiempoParo.Size = new System.Drawing.Size(94, 20);
            this.lblTiempoParo.TabIndex = 21;
            this.lblTiempoParo.Text = "tiempo Paro";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(16, 12);
            this.lblIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(94, 20);
            this.lblIp.TabIndex = 22;
            this.lblIp.Text = "Direccion IP";
            this.lblIp.Click += new System.EventHandler(this.lblIp_Click);
            // 
            // lblDataBase
            // 
            this.lblDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBase.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataBase.Location = new System.Drawing.Point(76, 109);
            this.lblDataBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(492, 222);
            this.lblDataBase.TabIndex = 23;
            this.lblDataBase.Text = "Database Error";
            this.lblDataBase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(274, 369);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(112, 35);
            this.btnAyuda.TabIndex = 24;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // timerProduccion
            // 
            this.timerProduccion.Interval = 5000;
            this.timerProduccion.Tick += new System.EventHandler(this.timerProduccion_Tick);
            // 
            // timerReconexion
            // 
            this.timerReconexion.Interval = 1000;
            this.timerReconexion.Tick += new System.EventHandler(this.timerReconexion_Tick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(105, 337);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbFallas
            // 
            this.cmbFallas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFallas.FormattingEnabled = true;
            this.cmbFallas.Location = new System.Drawing.Point(94, 74);
            this.cmbFallas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFallas.Name = "cmbFallas";
            this.cmbFallas.Size = new System.Drawing.Size(264, 28);
            this.cmbFallas.TabIndex = 26;
            this.cmbFallas.Visible = false;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.BackColor = System.Drawing.Color.Gray;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.Location = new System.Drawing.Point(93, 49);
            this.lblOpcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(198, 20);
            this.lblOpcion.TabIndex = 27;
            this.lblOpcion.Text = "Seleccione una opción";
            this.lblOpcion.Visible = false;
            // 
            // cmbProceso
            // 
            this.cmbProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProceso.FormattingEnabled = true;
            this.cmbProceso.Location = new System.Drawing.Point(94, 74);
            this.cmbProceso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProceso.Name = "cmbProceso";
            this.cmbProceso.Size = new System.Drawing.Size(264, 28);
            this.cmbProceso.TabIndex = 28;
            this.cmbProceso.Visible = false;
            // 
            // lblTiempoEnParo
            // 
            this.lblTiempoEnParo.AutoSize = true;
            this.lblTiempoEnParo.Location = new System.Drawing.Point(352, 500);
            this.lblTiempoEnParo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoEnParo.Name = "lblTiempoEnParo";
            this.lblTiempoEnParo.Size = new System.Drawing.Size(123, 20);
            this.lblTiempoEnParo.TabIndex = 31;
            this.lblTiempoEnParo.Text = "Tiempo en paro:";
            // 
            // lblTiempoParoActual
            // 
            this.lblTiempoParoActual.AutoSize = true;
            this.lblTiempoParoActual.Location = new System.Drawing.Point(488, 500);
            this.lblTiempoParoActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoParoActual.Name = "lblTiempoParoActual";
            this.lblTiempoParoActual.Size = new System.Drawing.Size(51, 20);
            this.lblTiempoParoActual.TabIndex = 32;
            this.lblTiempoParoActual.Text = "label3";
            // 
            // timerClosed
            // 
            this.timerClosed.Interval = 1000;
            this.timerClosed.Tick += new System.EventHandler(this.timerClosed_Tick);
            // 
            // timerConexion
            // 
            this.timerConexion.Enabled = true;
            this.timerConexion.Interval = 5000;
            this.timerConexion.Tick += new System.EventHandler(this.timerConexion_Tick);
            // 
            // callWindow
            // 
            this.callWindow.Interval = 1000;
            this.callWindow.Tick += new System.EventHandler(this.callWindow_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(134, 194);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(406, 120);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "RUNNING";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProduccion
            // 
            this.btnProduccion.Location = new System.Drawing.Point(684, 32);
            this.btnProduccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(112, 35);
            this.btnProduccion.TabIndex = 33;
            this.btnProduccion.Text = "Produccion";
            this.btnProduccion.UseVisualStyleBackColor = true;
            this.btnProduccion.Click += new System.EventHandler(this.btnProduccion_Click);
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.Location = new System.Drawing.Point(174, 12);
            this.lblMeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(149, 20);
            this.lblMeta.TabIndex = 34;
            this.lblMeta.Text = "Meta de produccion";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(174, 49);
            this.lblConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(171, 20);
            this.lblConfirm.TabIndex = 35;
            this.lblConfirm.Text = "Produccion confirmada";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Enabled = false;
            this.txtConfirm.Location = new System.Drawing.Point(357, 45);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(68, 26);
            this.txtConfirm.TabIndex = 36;
            // 
            // txtMeta
            // 
            this.txtMeta.Enabled = false;
            this.txtMeta.Location = new System.Drawing.Point(357, 8);
            this.txtMeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMeta.Name = "txtMeta";
            this.txtMeta.Size = new System.Drawing.Size(68, 26);
            this.txtMeta.TabIndex = 37;
            // 
            // lblStat
            // 
            this.lblStat.Location = new System.Drawing.Point(462, 46);
            this.lblStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(70, 29);
            this.lblStat.TabIndex = 38;
            // 
            // lblStatText
            // 
            this.lblStatText.AutoSize = true;
            this.lblStatText.Location = new System.Drawing.Point(462, 12);
            this.lblStatText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatText.Name = "lblStatText";
            this.lblStatText.Size = new System.Drawing.Size(64, 20);
            this.lblStatText.TabIndex = 39;
            this.lblStatText.Text = "Estatus";
            // 
            // lblCerrar
            // 
            this.lblCerrar.Location = new System.Drawing.Point(614, 2);
            this.lblCerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(56, 20);
            this.lblCerrar.TabIndex = 40;
            this.lblCerrar.DoubleClick += new System.EventHandler(this.lblCerrar_DoubleClick);
            // 
            // timerRes
            // 
            this.timerRes.Interval = 1000;
            this.timerRes.Tick += new System.EventHandler(this.timerRes_Tick);
            // 
            // StatusMachines
            // 
            this.StatusMachines.Enabled = true;
            this.StatusMachines.Interval = 5000;
            this.StatusMachines.Tick += new System.EventHandler(this.StatusMachines_Tick);
            // 
            // lblEstatus
            // 
            this.lblEstatus.Location = new System.Drawing.Point(588, 502);
            this.lblEstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(80, 35);
            this.lblEstatus.TabIndex = 41;
            this.lblEstatus.Click += new System.EventHandler(this.lblEstatus_Click);
            // 
            // timerArdConex
            // 
            this.timerArdConex.Interval = 500;
            this.timerArdConex.Tick += new System.EventHandler(this.timerArdConex_Tick);
            // 
            // rbtnBook
            // 
            this.rbtnBook.AutoSize = true;
            this.rbtnBook.Location = new System.Drawing.Point(22, 49);
            this.rbtnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnBook.Name = "rbtnBook";
            this.rbtnBook.Size = new System.Drawing.Size(116, 24);
            this.rbtnBook.TabIndex = 42;
            this.rbtnBook.TabStop = true;
            this.rbtnBook.Tag = "produccion";
            this.rbtnBook.Text = "Confirmado";
            this.rbtnBook.UseVisualStyleBackColor = true;
            this.rbtnBook.CheckedChanged += new System.EventHandler(this.rbtnBook_CheckedChanged);
            // 
            // rbtnEmpaque
            // 
            this.rbtnEmpaque.AutoSize = true;
            this.rbtnEmpaque.Location = new System.Drawing.Point(22, 80);
            this.rbtnEmpaque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnEmpaque.Name = "rbtnEmpaque";
            this.rbtnEmpaque.Size = new System.Drawing.Size(103, 24);
            this.rbtnEmpaque.TabIndex = 43;
            this.rbtnEmpaque.TabStop = true;
            this.rbtnEmpaque.Tag = "produccion";
            this.rbtnEmpaque.Text = "Empaque";
            this.rbtnEmpaque.UseVisualStyleBackColor = true;
            this.rbtnEmpaque.CheckedChanged += new System.EventHandler(this.rbtnEmpaque_CheckedChanged);
            // 
            // rbtnPrensa
            // 
            this.rbtnPrensa.AutoSize = true;
            this.rbtnPrensa.Location = new System.Drawing.Point(22, 111);
            this.rbtnPrensa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnPrensa.Name = "rbtnPrensa";
            this.rbtnPrensa.Size = new System.Drawing.Size(84, 24);
            this.rbtnPrensa.TabIndex = 44;
            this.rbtnPrensa.TabStop = true;
            this.rbtnPrensa.Tag = "produccion";
            this.rbtnPrensa.Text = "Prensa";
            this.rbtnPrensa.UseVisualStyleBackColor = true;
            this.rbtnPrensa.CheckedChanged += new System.EventHandler(this.rbtnPrensa_CheckedChanged);
            // 
            // lblHora1
            // 
            this.lblHora1.AutoSize = true;
            this.lblHora1.Location = new System.Drawing.Point(100, 554);
            this.lblHora1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora1.Name = "lblHora1";
            this.lblHora1.Size = new System.Drawing.Size(49, 20);
            this.lblHora1.TabIndex = 45;
            this.lblHora1.Text = "07:45";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 586);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Prensa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 617);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Empaque";
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.Location = new System.Drawing.Point(160, 554);
            this.lblHora2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(49, 20);
            this.lblHora2.TabIndex = 48;
            this.lblHora2.Text = "07:45";
            // 
            // lblHora3
            // 
            this.lblHora3.AutoSize = true;
            this.lblHora3.Location = new System.Drawing.Point(220, 554);
            this.lblHora3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora3.Name = "lblHora3";
            this.lblHora3.Size = new System.Drawing.Size(49, 20);
            this.lblHora3.TabIndex = 49;
            this.lblHora3.Text = "07:45";
            // 
            // lblHora4
            // 
            this.lblHora4.AutoSize = true;
            this.lblHora4.Location = new System.Drawing.Point(280, 554);
            this.lblHora4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora4.Name = "lblHora4";
            this.lblHora4.Size = new System.Drawing.Size(49, 20);
            this.lblHora4.TabIndex = 50;
            this.lblHora4.Text = "07:45";
            // 
            // lblHora5
            // 
            this.lblHora5.AutoSize = true;
            this.lblHora5.Location = new System.Drawing.Point(340, 554);
            this.lblHora5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora5.Name = "lblHora5";
            this.lblHora5.Size = new System.Drawing.Size(49, 20);
            this.lblHora5.TabIndex = 51;
            this.lblHora5.Text = "07:45";
            // 
            // lblHora6
            // 
            this.lblHora6.AutoSize = true;
            this.lblHora6.Location = new System.Drawing.Point(400, 554);
            this.lblHora6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora6.Name = "lblHora6";
            this.lblHora6.Size = new System.Drawing.Size(49, 20);
            this.lblHora6.TabIndex = 52;
            this.lblHora6.Text = "07:45";
            // 
            // lblHora12
            // 
            this.lblHora12.AutoSize = true;
            this.lblHora12.Location = new System.Drawing.Point(760, 554);
            this.lblHora12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora12.Name = "lblHora12";
            this.lblHora12.Size = new System.Drawing.Size(49, 20);
            this.lblHora12.TabIndex = 58;
            this.lblHora12.Text = "07:45";
            // 
            // lblHora11
            // 
            this.lblHora11.AutoSize = true;
            this.lblHora11.Location = new System.Drawing.Point(700, 554);
            this.lblHora11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora11.Name = "lblHora11";
            this.lblHora11.Size = new System.Drawing.Size(49, 20);
            this.lblHora11.TabIndex = 57;
            this.lblHora11.Text = "07:45";
            // 
            // lblHora10
            // 
            this.lblHora10.AutoSize = true;
            this.lblHora10.Location = new System.Drawing.Point(640, 554);
            this.lblHora10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora10.Name = "lblHora10";
            this.lblHora10.Size = new System.Drawing.Size(49, 20);
            this.lblHora10.TabIndex = 56;
            this.lblHora10.Text = "07:45";
            // 
            // lblHora9
            // 
            this.lblHora9.AutoSize = true;
            this.lblHora9.Location = new System.Drawing.Point(580, 554);
            this.lblHora9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora9.Name = "lblHora9";
            this.lblHora9.Size = new System.Drawing.Size(49, 20);
            this.lblHora9.TabIndex = 55;
            this.lblHora9.Text = "07:45";
            // 
            // lblHora8
            // 
            this.lblHora8.AutoSize = true;
            this.lblHora8.Location = new System.Drawing.Point(520, 554);
            this.lblHora8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora8.Name = "lblHora8";
            this.lblHora8.Size = new System.Drawing.Size(49, 20);
            this.lblHora8.TabIndex = 54;
            this.lblHora8.Text = "07:45";
            // 
            // lblHora7
            // 
            this.lblHora7.AutoSize = true;
            this.lblHora7.Location = new System.Drawing.Point(460, 554);
            this.lblHora7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora7.Name = "lblHora7";
            this.lblHora7.Size = new System.Drawing.Size(49, 20);
            this.lblHora7.TabIndex = 53;
            this.lblHora7.Text = "07:45";
            // 
            // pr12
            // 
            this.pr12.AutoSize = true;
            this.pr12.Location = new System.Drawing.Point(760, 586);
            this.pr12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr12.Name = "pr12";
            this.pr12.Size = new System.Drawing.Size(36, 20);
            this.pr12.TabIndex = 70;
            this.pr12.Text = "110";
            // 
            // pr11
            // 
            this.pr11.AutoSize = true;
            this.pr11.Location = new System.Drawing.Point(700, 586);
            this.pr11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr11.Name = "pr11";
            this.pr11.Size = new System.Drawing.Size(36, 20);
            this.pr11.TabIndex = 69;
            this.pr11.Text = "110";
            // 
            // pr10
            // 
            this.pr10.AutoSize = true;
            this.pr10.Location = new System.Drawing.Point(640, 586);
            this.pr10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr10.Name = "pr10";
            this.pr10.Size = new System.Drawing.Size(36, 20);
            this.pr10.TabIndex = 68;
            this.pr10.Text = "110";
            // 
            // pr9
            // 
            this.pr9.AutoSize = true;
            this.pr9.Location = new System.Drawing.Point(580, 586);
            this.pr9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr9.Name = "pr9";
            this.pr9.Size = new System.Drawing.Size(36, 20);
            this.pr9.TabIndex = 67;
            this.pr9.Text = "110";
            // 
            // pr8
            // 
            this.pr8.AutoSize = true;
            this.pr8.Location = new System.Drawing.Point(520, 586);
            this.pr8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr8.Name = "pr8";
            this.pr8.Size = new System.Drawing.Size(36, 20);
            this.pr8.TabIndex = 66;
            this.pr8.Text = "110";
            // 
            // pr7
            // 
            this.pr7.AutoSize = true;
            this.pr7.Location = new System.Drawing.Point(460, 586);
            this.pr7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr7.Name = "pr7";
            this.pr7.Size = new System.Drawing.Size(36, 20);
            this.pr7.TabIndex = 65;
            this.pr7.Text = "110";
            // 
            // pr6
            // 
            this.pr6.AutoSize = true;
            this.pr6.Location = new System.Drawing.Point(400, 586);
            this.pr6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr6.Name = "pr6";
            this.pr6.Size = new System.Drawing.Size(36, 20);
            this.pr6.TabIndex = 64;
            this.pr6.Text = "110";
            // 
            // pr5
            // 
            this.pr5.AutoSize = true;
            this.pr5.Location = new System.Drawing.Point(340, 586);
            this.pr5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr5.Name = "pr5";
            this.pr5.Size = new System.Drawing.Size(36, 20);
            this.pr5.TabIndex = 63;
            this.pr5.Text = "110";
            // 
            // pr4
            // 
            this.pr4.AutoSize = true;
            this.pr4.Location = new System.Drawing.Point(280, 586);
            this.pr4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr4.Name = "pr4";
            this.pr4.Size = new System.Drawing.Size(36, 20);
            this.pr4.TabIndex = 62;
            this.pr4.Text = "110";
            // 
            // pr3
            // 
            this.pr3.AutoSize = true;
            this.pr3.Location = new System.Drawing.Point(220, 586);
            this.pr3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr3.Name = "pr3";
            this.pr3.Size = new System.Drawing.Size(36, 20);
            this.pr3.TabIndex = 61;
            this.pr3.Text = "110";
            // 
            // pr2
            // 
            this.pr2.AutoSize = true;
            this.pr2.Location = new System.Drawing.Point(160, 586);
            this.pr2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr2.Name = "pr2";
            this.pr2.Size = new System.Drawing.Size(36, 20);
            this.pr2.TabIndex = 60;
            this.pr2.Text = "110";
            // 
            // pr1
            // 
            this.pr1.AutoSize = true;
            this.pr1.Location = new System.Drawing.Point(100, 586);
            this.pr1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pr1.Name = "pr1";
            this.pr1.Size = new System.Drawing.Size(36, 20);
            this.pr1.TabIndex = 59;
            this.pr1.Text = "110";
            // 
            // em12
            // 
            this.em12.AutoSize = true;
            this.em12.Location = new System.Drawing.Point(760, 617);
            this.em12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em12.Name = "em12";
            this.em12.Size = new System.Drawing.Size(36, 20);
            this.em12.TabIndex = 82;
            this.em12.Text = "110";
            // 
            // em11
            // 
            this.em11.AutoSize = true;
            this.em11.Location = new System.Drawing.Point(700, 617);
            this.em11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em11.Name = "em11";
            this.em11.Size = new System.Drawing.Size(36, 20);
            this.em11.TabIndex = 81;
            this.em11.Text = "110";
            // 
            // em10
            // 
            this.em10.AutoSize = true;
            this.em10.Location = new System.Drawing.Point(640, 617);
            this.em10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em10.Name = "em10";
            this.em10.Size = new System.Drawing.Size(36, 20);
            this.em10.TabIndex = 80;
            this.em10.Text = "110";
            // 
            // em9
            // 
            this.em9.AutoSize = true;
            this.em9.Location = new System.Drawing.Point(580, 617);
            this.em9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em9.Name = "em9";
            this.em9.Size = new System.Drawing.Size(36, 20);
            this.em9.TabIndex = 79;
            this.em9.Text = "110";
            // 
            // em8
            // 
            this.em8.AutoSize = true;
            this.em8.Location = new System.Drawing.Point(520, 617);
            this.em8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em8.Name = "em8";
            this.em8.Size = new System.Drawing.Size(36, 20);
            this.em8.TabIndex = 78;
            this.em8.Text = "110";
            // 
            // em7
            // 
            this.em7.AutoSize = true;
            this.em7.Location = new System.Drawing.Point(460, 617);
            this.em7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em7.Name = "em7";
            this.em7.Size = new System.Drawing.Size(36, 20);
            this.em7.TabIndex = 77;
            this.em7.Text = "110";
            // 
            // em6
            // 
            this.em6.AutoSize = true;
            this.em6.Location = new System.Drawing.Point(400, 617);
            this.em6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em6.Name = "em6";
            this.em6.Size = new System.Drawing.Size(36, 20);
            this.em6.TabIndex = 76;
            this.em6.Text = "110";
            // 
            // em5
            // 
            this.em5.AutoSize = true;
            this.em5.Location = new System.Drawing.Point(340, 617);
            this.em5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em5.Name = "em5";
            this.em5.Size = new System.Drawing.Size(36, 20);
            this.em5.TabIndex = 75;
            this.em5.Text = "110";
            // 
            // em4
            // 
            this.em4.AutoSize = true;
            this.em4.Location = new System.Drawing.Point(280, 617);
            this.em4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em4.Name = "em4";
            this.em4.Size = new System.Drawing.Size(36, 20);
            this.em4.TabIndex = 74;
            this.em4.Text = "110";
            // 
            // em3
            // 
            this.em3.AutoSize = true;
            this.em3.Location = new System.Drawing.Point(220, 617);
            this.em3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em3.Name = "em3";
            this.em3.Size = new System.Drawing.Size(36, 20);
            this.em3.TabIndex = 73;
            this.em3.Text = "110";
            // 
            // em2
            // 
            this.em2.AutoSize = true;
            this.em2.Location = new System.Drawing.Point(160, 617);
            this.em2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em2.Name = "em2";
            this.em2.Size = new System.Drawing.Size(36, 20);
            this.em2.TabIndex = 72;
            this.em2.Text = "110";
            // 
            // em1
            // 
            this.em1.AutoSize = true;
            this.em1.Location = new System.Drawing.Point(100, 617);
            this.em1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.em1.Name = "em1";
            this.em1.Size = new System.Drawing.Size(36, 20);
            this.em1.TabIndex = 71;
            this.em1.Text = "110";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(818, 651);
            this.ControlBox = false;
            this.Controls.Add(this.em12);
            this.Controls.Add(this.em11);
            this.Controls.Add(this.em10);
            this.Controls.Add(this.em9);
            this.Controls.Add(this.em8);
            this.Controls.Add(this.em7);
            this.Controls.Add(this.em6);
            this.Controls.Add(this.em5);
            this.Controls.Add(this.em4);
            this.Controls.Add(this.em3);
            this.Controls.Add(this.em2);
            this.Controls.Add(this.em1);
            this.Controls.Add(this.pr12);
            this.Controls.Add(this.pr11);
            this.Controls.Add(this.pr10);
            this.Controls.Add(this.pr9);
            this.Controls.Add(this.pr8);
            this.Controls.Add(this.pr7);
            this.Controls.Add(this.pr6);
            this.Controls.Add(this.pr5);
            this.Controls.Add(this.pr4);
            this.Controls.Add(this.pr3);
            this.Controls.Add(this.pr2);
            this.Controls.Add(this.pr1);
            this.Controls.Add(this.lblHora12);
            this.Controls.Add(this.lblHora11);
            this.Controls.Add(this.lblHora10);
            this.Controls.Add(this.lblHora9);
            this.Controls.Add(this.lblHora8);
            this.Controls.Add(this.lblHora7);
            this.Controls.Add(this.lblHora6);
            this.Controls.Add(this.lblHora5);
            this.Controls.Add(this.lblHora4);
            this.Controls.Add(this.lblHora3);
            this.Controls.Add(this.lblHora2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHora1);
            this.Controls.Add(this.rbtnPrensa);
            this.Controls.Add(this.rbtnEmpaque);
            this.Controls.Add(this.rbtnBook);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.lblStatText);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.txtMeta);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblMeta);
            this.Controls.Add(this.btnProduccion);
            this.Controls.Add(this.lblTiempoParoActual);
            this.Controls.Add(this.lblTiempoEnParo);
            this.Controls.Add(this.cmbProceso);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.cmbFallas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.lblTiempoParo);
            this.Controls.Add(this.lblHoraParo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblParo);
            this.Controls.Add(this.cmbParo);
            this.Controls.Add(this.cmbSerial);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFondoGris);
            this.Controls.Add(this.lblConnect);
            this.Controls.Add(this.lblDataBase);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(679, 564);
            this.Name = "frmPrincipal";
            this.Text = "Sistema Paros  Vinyl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing_1);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Leave += new System.EventHandler(this.frmPrincipal_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cmbSerial;
        private System.Windows.Forms.ComboBox cmbParo;
        private System.Windows.Forms.Label lblParo;
        private System.Windows.Forms.Label lblFondoGris;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label lblHoraParo;
        private System.Windows.Forms.Label lblTiempoParo;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Timer timerProduccion;
        private System.Windows.Forms.Timer timerReconexion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbFallas;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cmbProceso;
        private System.Windows.Forms.Label lblTiempoEnParo;
        private System.Windows.Forms.Label lblTiempoParoActual;
        public System.Windows.Forms.Timer timerTiempoParo;
        private System.Windows.Forms.Timer timerClosed;
        private System.Windows.Forms.Timer timerConexion;
        private System.Windows.Forms.Timer callWindow;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnProduccion;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtMeta;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label lblStatText;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Timer timerRes;
        private System.Windows.Forms.Timer StatusMachines;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Timer timerArdConex;
        private System.Windows.Forms.RadioButton rbtnBook;
        private System.Windows.Forms.RadioButton rbtnEmpaque;
        private System.Windows.Forms.RadioButton rbtnPrensa;
        private System.Windows.Forms.Label lblHora1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblHora3;
        private System.Windows.Forms.Label lblHora4;
        private System.Windows.Forms.Label lblHora5;
        private System.Windows.Forms.Label lblHora6;
        private System.Windows.Forms.Label lblHora12;
        private System.Windows.Forms.Label lblHora11;
        private System.Windows.Forms.Label lblHora10;
        private System.Windows.Forms.Label lblHora9;
        private System.Windows.Forms.Label lblHora8;
        private System.Windows.Forms.Label lblHora7;
        private System.Windows.Forms.Label pr12;
        private System.Windows.Forms.Label pr11;
        private System.Windows.Forms.Label pr10;
        private System.Windows.Forms.Label pr9;
        private System.Windows.Forms.Label pr8;
        private System.Windows.Forms.Label pr7;
        private System.Windows.Forms.Label pr6;
        private System.Windows.Forms.Label pr5;
        private System.Windows.Forms.Label pr4;
        private System.Windows.Forms.Label pr3;
        private System.Windows.Forms.Label pr2;
        private System.Windows.Forms.Label pr1;
        private System.Windows.Forms.Label em12;
        private System.Windows.Forms.Label em11;
        private System.Windows.Forms.Label em10;
        private System.Windows.Forms.Label em9;
        private System.Windows.Forms.Label em8;
        private System.Windows.Forms.Label em7;
        private System.Windows.Forms.Label em6;
        private System.Windows.Forms.Label em5;
        private System.Windows.Forms.Label em4;
        private System.Windows.Forms.Label em3;
        private System.Windows.Forms.Label em2;
        private System.Windows.Forms.Label em1;
    }
}

