namespace BancoClient.Presentacion
{
    partial class FormCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.cCodCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUltimoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarCta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.txtCBU = new System.Windows.Forms.TextBox();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCBU = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.UltimoMov = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.cboBuscarTipoCuenta = new System.Windows.Forms.ComboBox();
            this.cboBuscarCli = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.LimpiarFiltro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimpiarFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(884, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuentas.ForeColor = System.Drawing.Color.White;
            this.lblCuentas.Location = new System.Drawing.Point(23, 35);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(188, 24);
            this.lblCuentas.TabIndex = 1;
            this.lblCuentas.Text = "Listado de Cuentas";
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodCuenta,
            this.cTipoCuenta,
            this.cCBU,
            this.cSaldo,
            this.cCliente,
            this.cUltimoMov});
            this.dgvCuentas.EnableHeadersVisualStyles = false;
            this.dgvCuentas.GridColor = System.Drawing.Color.White;
            this.dgvCuentas.Location = new System.Drawing.Point(12, 137);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCuentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentas.RowTemplate.Height = 25;
            this.dgvCuentas.Size = new System.Drawing.Size(745, 348);
            this.dgvCuentas.TabIndex = 2;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // cCodCuenta
            // 
            this.cCodCuenta.HeaderText = "ID Cuenta";
            this.cCodCuenta.Name = "cCodCuenta";
            this.cCodCuenta.ReadOnly = true;
            this.cCodCuenta.Width = 53;
            // 
            // cTipoCuenta
            // 
            this.cTipoCuenta.HeaderText = "Tipo de Cuenta";
            this.cTipoCuenta.Name = "cTipoCuenta";
            this.cTipoCuenta.ReadOnly = true;
            this.cTipoCuenta.Width = 150;
            // 
            // cCBU
            // 
            this.cCBU.HeaderText = "CBU";
            this.cCBU.Name = "cCBU";
            this.cCBU.ReadOnly = true;
            this.cCBU.Width = 200;
            // 
            // cSaldo
            // 
            this.cSaldo.HeaderText = "Saldo";
            this.cSaldo.Name = "cSaldo";
            this.cSaldo.ReadOnly = true;
            // 
            // cCliente
            // 
            this.cCliente.HeaderText = "Cliente";
            this.cCliente.Name = "cCliente";
            this.cCliente.ReadOnly = true;
            // 
            // cUltimoMov
            // 
            this.cUltimoMov.HeaderText = "Ultimo Movimiento";
            this.cUltimoMov.Name = "cUltimoMov";
            this.cUltimoMov.ReadOnly = true;
            // 
            // btnAgregarCta
            // 
            this.btnAgregarCta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarCta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarCta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregarCta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCta.Location = new System.Drawing.Point(26, 548);
            this.btnAgregarCta.Name = "btnAgregarCta";
            this.btnAgregarCta.Size = new System.Drawing.Size(104, 31);
            this.btnAgregarCta.TabIndex = 7;
            this.btnAgregarCta.Text = "Agregar";
            this.btnAgregarCta.UseVisualStyleBackColor = true;
            this.btnAgregarCta.Click += new System.EventHandler(this.btnAgregarCta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(150, 548);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 31);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(623, 548);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 31);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoCuenta.ForeColor = System.Drawing.Color.White;
            this.lblTipoCuenta.Location = new System.Drawing.Point(773, 220);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(76, 13);
            this.lblTipoCuenta.TabIndex = 7;
            this.lblTipoCuenta.Text = "Tipo Cuenta";
            // 
            // txtCBU
            // 
            this.txtCBU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(236)))));
            this.txtCBU.Location = new System.Drawing.Point(851, 266);
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Size = new System.Drawing.Size(217, 20);
            this.txtCBU.TabIndex = 11;
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(236)))));
            this.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Items.AddRange(new object[] {
            "Caja de Ahorro",
            "Cuenta Corriente",
            "Cuenta Sueldo"});
            this.cboTipoCuenta.Location = new System.Drawing.Point(851, 218);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(217, 21);
            this.cboTipoCuenta.TabIndex = 10;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(236)))));
            this.txtSaldo.Location = new System.Drawing.Point(851, 323);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(217, 20);
            this.txtSaldo.TabIndex = 13;
            this.txtSaldo.Text = ",00";
            // 
            // cboCliente
            // 
            this.cboCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(236)))));
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(851, 365);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(217, 21);
            this.cboCliente.TabIndex = 14;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(851, 411);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(217, 20);
            this.dtpFecha.TabIndex = 15;
            // 
            // lblCBU
            // 
            this.lblCBU.AutoSize = true;
            this.lblCBU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCBU.ForeColor = System.Drawing.Color.White;
            this.lblCBU.Location = new System.Drawing.Point(814, 269);
            this.lblCBU.Name = "lblCBU";
            this.lblCBU.Size = new System.Drawing.Size(32, 13);
            this.lblCBU.TabIndex = 13;
            this.lblCBU.Text = "CBU";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.ForeColor = System.Drawing.Color.White;
            this.lblSaldo.Location = new System.Drawing.Point(808, 326);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(39, 13);
            this.lblSaldo.TabIndex = 14;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(801, 367);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "Cliente";
            // 
            // UltimoMov
            // 
            this.UltimoMov.AutoSize = true;
            this.UltimoMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UltimoMov.ForeColor = System.Drawing.Color.White;
            this.UltimoMov.Location = new System.Drawing.Point(773, 405);
            this.UltimoMov.Name = "UltimoMov";
            this.UltimoMov.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UltimoMov.Size = new System.Drawing.Size(71, 26);
            this.UltimoMov.TabIndex = 16;
            this.UltimoMov.Text = "Ultimo \r\nMovimiento";
            this.UltimoMov.Click += new System.EventHandler(this.UltimoMov_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(797, 465);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(271, 31);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(23, 90);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(86, 16);
            this.lblBuscar.TabIndex = 18;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // cboBuscar
            // 
            this.cboBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(236)))));
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Tipo de Cuenta",
            "Cliente",
            "Fecha de Movimientos"});
            this.cboBuscar.Location = new System.Drawing.Point(114, 90);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(127, 21);
            this.cboBuscar.TabIndex = 0;
            this.cboBuscar.TextChanged += new System.EventHandler(this.cboBuscar_TextChanged);
            // 
            // cboBuscarTipoCuenta
            // 
            this.cboBuscarTipoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(236)))));
            this.cboBuscarTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuscarTipoCuenta.FormattingEnabled = true;
            this.cboBuscarTipoCuenta.Items.AddRange(new object[] {
            "Caja de Ahorro",
            "Cuenta Corriente",
            "Cuenta Sueldo"});
            this.cboBuscarTipoCuenta.Location = new System.Drawing.Point(272, 90);
            this.cboBuscarTipoCuenta.Name = "cboBuscarTipoCuenta";
            this.cboBuscarTipoCuenta.Size = new System.Drawing.Size(127, 21);
            this.cboBuscarTipoCuenta.TabIndex = 21;
            // 
            // cboBuscarCli
            // 
            this.cboBuscarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(224)))), ((int)(((byte)(236)))));
            this.cboBuscarCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuscarCli.FormattingEnabled = true;
            this.cboBuscarCli.Location = new System.Drawing.Point(272, 90);
            this.cboBuscarCli.Name = "cboBuscarCli";
            this.cboBuscarCli.Size = new System.Drawing.Size(127, 21);
            this.cboBuscarCli.TabIndex = 1;
            this.cboBuscarCli.Visible = false;
            this.cboBuscarCli.SelectedIndexChanged += new System.EventHandler(this.cboBuscarCli_SelectedIndexChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDesde.ForeColor = System.Drawing.Color.White;
            this.lblDesde.Location = new System.Drawing.Point(268, 80);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHasta.ForeColor = System.Drawing.Color.White;
            this.lblHasta.Location = new System.Drawing.Point(270, 107);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(40, 13);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(334, 74);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(217, 20);
            this.dtpDesde.TabIndex = 4;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(334, 101);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(217, 20);
            this.dtpHasta.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(579, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 40);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(993, 288);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 29);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // LimpiarFiltro
            // 
            this.LimpiarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimpiarFiltro.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarFiltro.Image")));
            this.LimpiarFiltro.Location = new System.Drawing.Point(718, 83);
            this.LimpiarFiltro.Name = "LimpiarFiltro";
            this.LimpiarFiltro.Size = new System.Drawing.Size(39, 37);
            this.LimpiarFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LimpiarFiltro.TabIndex = 29;
            this.LimpiarFiltro.TabStop = false;
            this.LimpiarFiltro.Click += new System.EventHandler(this.LimpiarFiltro_Click);
            // 
            // FormCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.LimpiarFiltro);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.cboBuscarCli);
            this.Controls.Add(this.cboBuscarTipoCuenta);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.UltimoMov);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCBU);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.txtCBU);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarCta);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCuentas";
            this.Text = "FormCuentas";
            this.Load += new System.EventHandler(this.FormCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimpiarFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCuentas;
        private DataGridView dgvCuentas;
        private Button btnAgregarCta;
        private Button btnEliminar;
        private Button btnCancelar;
        private Label lblTipoCuenta;
        private TextBox txtCBU;
        private ComboBox cboTipoCuenta;
        private TextBox txtSaldo;
        private ComboBox cboCliente;
        private DateTimePicker dtpFecha;
        private Label lblCBU;
        private Label lblSaldo;
        private Label lblCliente;
        private Label UltimoMov;
        private Button btnAgregar;
        private Label lblBuscar;
        private ComboBox cboBuscar;
        private ComboBox cboBuscarTipoCuenta;
        private ComboBox cboBuscarCli;
        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnBuscar;
        private Button btnGenerar;
        private PictureBox LimpiarFiltro;
        private DataGridViewTextBoxColumn cCodCuenta;
        private DataGridViewTextBoxColumn cTipoCuenta;
        private DataGridViewTextBoxColumn cCBU;
        private DataGridViewTextBoxColumn cSaldo;
        private DataGridViewTextBoxColumn cCliente;
        private DataGridViewTextBoxColumn cUltimoMov;
    }
}