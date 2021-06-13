namespace CapaPresentacion
{
    partial class frmRentaVehiculo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentaVehiculo));
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.chkeliminar = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.dtbuscarfecha = new System.Windows.Forms.DateTimePicker();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidpago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbtipopago = new System.Windows.Forms.ComboBox();
            this.dtfechareservacion = new System.Windows.Forms.DateTimePicker();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.txtidreservacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtfechadevolucion = new System.Windows.Forms.DateTimePicker();
            this.btnfacturareservacion = new System.Windows.Forms.Button();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.btneliminarreservacion = new System.Windows.Forms.Button();
            this.lbltotalreservaciones = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cbtipovehiculo = new System.Windows.Forms.ComboBox();
            this.txtcantidaddias = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtfecharenta = new System.Windows.Forms.DateTimePicker();
            this.txtcedulacliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtidrenta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtnombrecliente.Location = new System.Drawing.Point(147, 101);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.ReadOnly = true;
            this.txtnombrecliente.Size = new System.Drawing.Size(212, 22);
            this.txtnombrecliente.TabIndex = 68;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 104);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 16);
            this.label24.TabIndex = 67;
            this.label24.Text = "Nombre Cliente:";
            // 
            // chkeliminar
            // 
            this.chkeliminar.AutoSize = true;
            this.chkeliminar.Location = new System.Drawing.Point(6, 283);
            this.chkeliminar.Name = "chkeliminar";
            this.chkeliminar.Size = new System.Drawing.Size(71, 20);
            this.chkeliminar.TabIndex = 69;
            this.chkeliminar.Text = "Anular";
            this.chkeliminar.UseVisualStyleBackColor = true;
            this.chkeliminar.CheckedChanged += new System.EventHandler(this.chkeliminar_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1205, 585);
            this.tabControl1.TabIndex = 47;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.datalistado);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1197, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Renta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cbbuscar);
            this.groupBox2.Controls.Add(this.dtbuscarfecha);
            this.groupBox2.Controls.Add(this.txtplaca);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.dtfechadevolucion);
            this.groupBox2.Controls.Add(this.btnfacturareservacion);
            this.groupBox2.Controls.Add(this.btnbuscarcliente);
            this.groupBox2.Controls.Add(this.chkeliminar);
            this.groupBox2.Controls.Add(this.txtnombrecliente);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.btneliminarreservacion);
            this.groupBox2.Controls.Add(this.lbltotalreservaciones);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cbtipovehiculo);
            this.groupBox2.Controls.Add(this.txtcantidaddias);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.dtfecharenta);
            this.groupBox2.Controls.Add(this.txtcedulacliente);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.txtidrenta);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1183, 311);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::CapaPresentacion.Properties.Resources.icontexto_search_01_icon_icons_com_76897;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(471, 274);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 37);
            this.btnBuscar.TabIndex = 97;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.renta_vehiculos;
            this.pictureBox1.Location = new System.Drawing.Point(1034, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 141);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "Cedula",
            "Fecha",
            "Nombre"});
            this.cbbuscar.Location = new System.Drawing.Point(248, 282);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(94, 24);
            this.cbbuscar.TabIndex = 96;
            this.cbbuscar.Text = "Nombre";
            this.cbbuscar.SelectedIndexChanged += new System.EventHandler(this.cbbuscar_SelectedIndexChanged);
            // 
            // dtbuscarfecha
            // 
            this.dtbuscarfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbuscarfecha.Location = new System.Drawing.Point(348, 282);
            this.dtbuscarfecha.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtbuscarfecha.Name = "dtbuscarfecha";
            this.dtbuscarfecha.Size = new System.Drawing.Size(117, 22);
            this.dtbuscarfecha.TabIndex = 94;
            this.dtbuscarfecha.Visible = false;
            // 
            // txtplaca
            // 
            this.txtplaca.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtplaca.Location = new System.Drawing.Point(388, 138);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(100, 22);
            this.txtplaca.TabIndex = 86;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtbuscar.Location = new System.Drawing.Point(348, 282);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(117, 22);
            this.txtbuscar.TabIndex = 95;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 85;
            this.label13.Text = "Placa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidpago);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbtipopago);
            this.groupBox1.Controls.Add(this.dtfechareservacion);
            this.groupBox1.Controls.Add(this.txtpago);
            this.groupBox1.Controls.Add(this.txtidreservacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(494, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 179);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservación";
            // 
            // txtidpago
            // 
            this.txtidpago.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtidpago.Location = new System.Drawing.Point(331, 17);
            this.txtidpago.Name = "txtidpago";
            this.txtidpago.ReadOnly = true;
            this.txtidpago.Size = new System.Drawing.Size(43, 22);
            this.txtidpago.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 82;
            this.label11.Text = "Id Pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 81;
            this.label10.Text = "Tipo Pago:";
            // 
            // cbtipopago
            // 
            this.cbtipopago.FormattingEnabled = true;
            this.cbtipopago.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo",
            "Depósito"});
            this.cbtipopago.Location = new System.Drawing.Point(165, 138);
            this.cbtipopago.Name = "cbtipopago";
            this.cbtipopago.Size = new System.Drawing.Size(100, 24);
            this.cbtipopago.TabIndex = 80;
            this.cbtipopago.Text = "Depósito";
            // 
            // dtfechareservacion
            // 
            this.dtfechareservacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechareservacion.Location = new System.Drawing.Point(165, 57);
            this.dtfechareservacion.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtfechareservacion.Name = "dtfechareservacion";
            this.dtfechareservacion.Size = new System.Drawing.Size(117, 22);
            this.dtfechareservacion.TabIndex = 77;
            // 
            // txtpago
            // 
            this.txtpago.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtpago.Location = new System.Drawing.Point(165, 96);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(100, 22);
            this.txtpago.TabIndex = 79;
            // 
            // txtidreservacion
            // 
            this.txtidreservacion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtidreservacion.Location = new System.Drawing.Point(165, 17);
            this.txtidreservacion.Name = "txtidreservacion";
            this.txtidreservacion.ReadOnly = true;
            this.txtidreservacion.Size = new System.Drawing.Size(43, 22);
            this.txtidreservacion.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Id Reservación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Fecha Reservación:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(695, 284);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 16);
            this.lblTotal.TabIndex = 84;
            this.lblTotal.Text = "label3";
            // 
            // dtfechadevolucion
            // 
            this.dtfechadevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechadevolucion.Location = new System.Drawing.Point(157, 246);
            this.dtfechadevolucion.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtfechadevolucion.Name = "dtfechadevolucion";
            this.dtfechadevolucion.Size = new System.Drawing.Size(117, 22);
            this.dtfechadevolucion.TabIndex = 73;
            // 
            // btnfacturareservacion
            // 
            this.btnfacturareservacion.BackgroundImage = global::CapaPresentacion.Properties.Resources.printer_green_10875;
            this.btnfacturareservacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfacturareservacion.Location = new System.Drawing.Point(1123, 267);
            this.btnfacturareservacion.Name = "btnfacturareservacion";
            this.btnfacturareservacion.Size = new System.Drawing.Size(54, 38);
            this.btnfacturareservacion.TabIndex = 71;
            this.btnfacturareservacion.UseVisualStyleBackColor = true;
            this.btnfacturareservacion.Click += new System.EventHandler(this.btnfacturareservacion_Click);
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.BackgroundImage = global::CapaPresentacion.Properties.Resources.icontexto_search_01_icon_icons_com_76897;
            this.btnbuscarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarcliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnbuscarcliente.Location = new System.Drawing.Point(371, 61);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(34, 29);
            this.btnbuscarcliente.TabIndex = 66;
            this.btnbuscarcliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // btneliminarreservacion
            // 
            this.btneliminarreservacion.BackgroundImage = global::CapaPresentacion.Properties.Resources.Eliminar;
            this.btneliminarreservacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminarreservacion.Location = new System.Drawing.Point(114, 274);
            this.btneliminarreservacion.Name = "btneliminarreservacion";
            this.btneliminarreservacion.Size = new System.Drawing.Size(43, 37);
            this.btneliminarreservacion.TabIndex = 59;
            this.btneliminarreservacion.UseVisualStyleBackColor = true;
            this.btneliminarreservacion.Click += new System.EventHandler(this.btneliminarreservacion_Click);
            // 
            // lbltotalreservaciones
            // 
            this.lbltotalreservaciones.AutoSize = true;
            this.lbltotalreservaciones.Location = new System.Drawing.Point(720, 262);
            this.lbltotalreservaciones.Name = "lbltotalreservaciones";
            this.lbltotalreservaciones.Size = new System.Drawing.Size(0, 16);
            this.lbltotalreservaciones.TabIndex = 64;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::CapaPresentacion.Properties.Resources.add_icon_icons_com_74429;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNuevo.Location = new System.Drawing.Point(586, 202);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 42);
            this.btnNuevo.TabIndex = 63;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 16);
            this.label20.TabIndex = 60;
            this.label20.Text = "Tipo Vehículo";
            // 
            // cbtipovehiculo
            // 
            this.cbtipovehiculo.FormattingEnabled = true;
            this.cbtipovehiculo.Items.AddRange(new object[] {
            "Sedan",
            "Camioneta",
            "Microbús",
            "Otro..."});
            this.cbtipovehiculo.Location = new System.Drawing.Point(147, 175);
            this.cbtipovehiculo.Name = "cbtipovehiculo";
            this.cbtipovehiculo.Size = new System.Drawing.Size(100, 24);
            this.cbtipovehiculo.TabIndex = 55;
            this.cbtipovehiculo.Text = "Sedan";
            // 
            // txtcantidaddias
            // 
            this.txtcantidaddias.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtcantidaddias.Location = new System.Drawing.Point(147, 138);
            this.txtcantidaddias.Name = "txtcantidaddias";
            this.txtcantidaddias.Size = new System.Drawing.Size(100, 22);
            this.txtcantidaddias.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Cantidad de días";
            // 
            // dtfecharenta
            // 
            this.dtfecharenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecharenta.Location = new System.Drawing.Point(147, 209);
            this.dtfecharenta.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtfecharenta.Name = "dtfecharenta";
            this.dtfecharenta.Size = new System.Drawing.Size(117, 22);
            this.dtfecharenta.TabIndex = 57;
            // 
            // txtcedulacliente
            // 
            this.txtcedulacliente.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtcedulacliente.Location = new System.Drawing.Point(147, 64);
            this.txtcedulacliente.Name = "txtcedulacliente";
            this.txtcedulacliente.ReadOnly = true;
            this.txtcedulacliente.Size = new System.Drawing.Size(212, 22);
            this.txtcedulacliente.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "Fecha Devolución";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Cedula Cliente:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Fecha Renta:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::CapaPresentacion.Properties.Resources.guardar1;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGuardar.Location = new System.Drawing.Point(653, 202);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 41);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 16);
            this.label18.TabIndex = 29;
            this.label18.Text = "Id Renta";
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::CapaPresentacion.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(725, 202);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 42);
            this.btnEditar.TabIndex = 49;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::CapaPresentacion.Properties.Resources.Cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCancelar.Location = new System.Drawing.Point(802, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 41);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtidrenta
            // 
            this.txtidrenta.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtidrenta.Location = new System.Drawing.Point(147, 22);
            this.txtidrenta.Name = "txtidrenta";
            this.txtidrenta.ReadOnly = true;
            this.txtidrenta.Size = new System.Drawing.Size(43, 22);
            this.txtidrenta.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(567, 43);
            this.label12.TabIndex = 54;
            this.label12.Text = "Renta Vehículos Destiny Tour Nicaragua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 50;
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 49;
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.AllowUserToDeleteRows = false;
            this.datalistado.AllowUserToOrderColumns = true;
            this.datalistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datalistado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datalistado.BackgroundColor = System.Drawing.Color.White;
            this.datalistado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.datalistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.datalistado.EnableHeadersVisualStyles = false;
            this.datalistado.Location = new System.Drawing.Point(6, 323);
            this.datalistado.MultiSelect = false;
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            this.datalistado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datalistado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(1185, 224);
            this.datalistado.TabIndex = 98;
            this.datalistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistado_CellContentClick_1);
            this.datalistado.DoubleClick += new System.EventHandler(this.datalistado_DoubleClick_1);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Anular";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 42;
            // 
            // frmRentaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1229, 645);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRentaVehiculo";
            this.Text = "Renta Vehículo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRentaVehiculo_FormClosing);
            this.Load += new System.EventHandler(this.frmRentaVehiculo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfacturareservacion;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox chkeliminar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtfechadevolucion;
        private System.Windows.Forms.Button btneliminarreservacion;
        private System.Windows.Forms.Label lbltotalreservaciones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbtipovehiculo;
        private System.Windows.Forms.TextBox txtcantidaddias;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtfecharenta;
        private System.Windows.Forms.TextBox txtcedulacliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtidrenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidreservacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtfechareservacion;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbtipopago;
        private System.Windows.Forms.TextBox txtidpago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.DateTimePicker dtbuscarfecha;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}