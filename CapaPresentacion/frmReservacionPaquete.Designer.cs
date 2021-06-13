namespace CapaPresentacion
{
    partial class frmReservacionPaquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservacionPaquete));
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.chkanular = new System.Windows.Forms.CheckBox();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.dtbuscarfecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtpendiente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnfacturareservacion = new System.Windows.Forms.Button();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.txtnombreclientereservacion = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtidformapago = new System.Windows.Forms.TextBox();
            this.btneliminarreservacion = new System.Windows.Forms.Button();
            this.lbltotalreservaciones = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtfechapaquete = new System.Windows.Forms.DateTimePicker();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscarpaquete = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txtnombrepaquete = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtidpaquetenacional = new System.Windows.Forms.TextBox();
            this.cbtipopagoreservacion = new System.Windows.Forms.ComboBox();
            this.txtpagoreservacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtfechareservacion = new System.Windows.Forms.DateTimePicker();
            this.txtcedulaclientereservacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtidreservacion = new System.Windows.Forms.TextBox();
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
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtbuscar.Location = new System.Drawing.Point(318, 263);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(117, 22);
            this.txtbuscar.TabIndex = 99;
            // 
            // chkanular
            // 
            this.chkanular.AutoSize = true;
            this.chkanular.Location = new System.Drawing.Point(19, 267);
            this.chkanular.Name = "chkanular";
            this.chkanular.Size = new System.Drawing.Size(71, 20);
            this.chkanular.TabIndex = 69;
            this.chkanular.Text = "Anular";
            this.chkanular.UseVisualStyleBackColor = true;
            this.chkanular.CheckedChanged += new System.EventHandler(this.chkanular_CheckedChanged);
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "Cedula",
            "Fecha",
            "Nombre"});
            this.cbbuscar.Location = new System.Drawing.Point(218, 263);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(94, 24);
            this.cbbuscar.TabIndex = 100;
            this.cbbuscar.Text = "Nombre";
            // 
            // dtbuscarfecha
            // 
            this.dtbuscarfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbuscarfecha.Location = new System.Drawing.Point(318, 263);
            this.dtbuscarfecha.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtbuscarfecha.Name = "dtbuscarfecha";
            this.dtbuscarfecha.Size = new System.Drawing.Size(117, 22);
            this.dtbuscarfecha.TabIndex = 98;
            this.dtbuscarfecha.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::CapaPresentacion.Properties.Resources.icontexto_search_01_icon_icons_com_76897;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(441, 247);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 38);
            this.btnBuscar.TabIndex = 101;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1122, 563);
            this.tabControl1.TabIndex = 47;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.datalistado);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1114, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.txtpendiente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.cbbuscar);
            this.groupBox2.Controls.Add(this.dtbuscarfecha);
            this.groupBox2.Controls.Add(this.btnfacturareservacion);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.btnbuscarcliente);
            this.groupBox2.Controls.Add(this.chkanular);
            this.groupBox2.Controls.Add(this.txtnombreclientereservacion);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtidformapago);
            this.groupBox2.Controls.Add(this.btneliminarreservacion);
            this.groupBox2.Controls.Add(this.lbltotalreservaciones);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cbtipopagoreservacion);
            this.groupBox2.Controls.Add(this.txtpagoreservacion);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.dtfechareservacion);
            this.groupBox2.Controls.Add(this.txtcedulaclientereservacion);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btneditar);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.txtidreservacion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 287);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservaciones";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(675, 258);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 16);
            this.lblTotal.TabIndex = 104;
            this.lblTotal.Text = "label3";
            // 
            // txtpendiente
            // 
            this.txtpendiente.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtpendiente.Location = new System.Drawing.Point(312, 138);
            this.txtpendiente.Name = "txtpendiente";
            this.txtpendiente.Size = new System.Drawing.Size(52, 22);
            this.txtpendiente.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "Pendiente:";
            // 
            // btnfacturareservacion
            // 
            this.btnfacturareservacion.BackgroundImage = global::CapaPresentacion.Properties.Resources.printer_green_10875;
            this.btnfacturareservacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfacturareservacion.Location = new System.Drawing.Point(826, 247);
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
            // txtnombreclientereservacion
            // 
            this.txtnombreclientereservacion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtnombreclientereservacion.Location = new System.Drawing.Point(147, 101);
            this.txtnombreclientereservacion.Name = "txtnombreclientereservacion";
            this.txtnombreclientereservacion.Size = new System.Drawing.Size(212, 22);
            this.txtnombreclientereservacion.TabIndex = 68;
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(240, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 16);
            this.label19.TabIndex = 65;
            this.label19.Text = "Id Pago";
            // 
            // txtidformapago
            // 
            this.txtidformapago.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtidformapago.Location = new System.Drawing.Point(308, 21);
            this.txtidformapago.Name = "txtidformapago";
            this.txtidformapago.ReadOnly = true;
            this.txtidformapago.Size = new System.Drawing.Size(43, 22);
            this.txtidformapago.TabIndex = 66;
            // 
            // btneliminarreservacion
            // 
            this.btneliminarreservacion.BackgroundImage = global::CapaPresentacion.Properties.Resources.Eliminar;
            this.btneliminarreservacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminarreservacion.Location = new System.Drawing.Point(113, 247);
            this.btneliminarreservacion.Name = "btneliminarreservacion";
            this.btneliminarreservacion.Size = new System.Drawing.Size(54, 38);
            this.btneliminarreservacion.TabIndex = 59;
            this.btneliminarreservacion.UseVisualStyleBackColor = true;
            this.btneliminarreservacion.Click += new System.EventHandler(this.btneliminarreservacion_Click);
            // 
            // lbltotalreservaciones
            // 
            this.lbltotalreservaciones.AutoSize = true;
            this.lbltotalreservaciones.Location = new System.Drawing.Point(623, 263);
            this.lbltotalreservaciones.Name = "lbltotalreservaciones";
            this.lbltotalreservaciones.Size = new System.Drawing.Size(0, 16);
            this.lbltotalreservaciones.TabIndex = 64;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = global::CapaPresentacion.Properties.Resources.add_icon_icons_com_74429;
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnnuevo.Location = new System.Drawing.Point(504, 201);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(49, 36);
            this.btnnuevo.TabIndex = 63;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 16);
            this.label20.TabIndex = 60;
            this.label20.Text = "Tipo Pago:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtfechapaquete);
            this.groupBox4.Controls.Add(this.txtprecio);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnbuscarpaquete);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtnombrepaquete);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtidpaquetenacional);
            this.groupBox4.Location = new System.Drawing.Point(428, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 173);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paquete Nacional";
            // 
            // dtfechapaquete
            // 
            this.dtfechapaquete.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechapaquete.Location = new System.Drawing.Point(83, 88);
            this.dtfechapaquete.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtfechapaquete.Name = "dtfechapaquete";
            this.dtfechapaquete.Size = new System.Drawing.Size(117, 22);
            this.dtfechapaquete.TabIndex = 104;
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtprecio.Location = new System.Drawing.Point(83, 116);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(76, 22);
            this.txtprecio.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Precio:";
            // 
            // btnbuscarpaquete
            // 
            this.btnbuscarpaquete.BackgroundImage = global::CapaPresentacion.Properties.Resources.icontexto_search_01_icon_icons_com_76897;
            this.btnbuscarpaquete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscarpaquete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnbuscarpaquete.Location = new System.Drawing.Point(109, 24);
            this.btnbuscarpaquete.Name = "btnbuscarpaquete";
            this.btnbuscarpaquete.Size = new System.Drawing.Size(34, 29);
            this.btnbuscarpaquete.TabIndex = 63;
            this.btnbuscarpaquete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnbuscarpaquete.UseVisualStyleBackColor = true;
            this.btnbuscarpaquete.Click += new System.EventHandler(this.btnbuscarpaquete_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 16);
            this.label23.TabIndex = 64;
            this.label23.Text = "Fecha:";
            // 
            // txtnombrepaquete
            // 
            this.txtnombrepaquete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtnombrepaquete.Location = new System.Drawing.Point(83, 59);
            this.txtnombrepaquete.Name = "txtnombrepaquete";
            this.txtnombrepaquete.ReadOnly = true;
            this.txtnombrepaquete.Size = new System.Drawing.Size(311, 22);
            this.txtnombrepaquete.TabIndex = 63;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 16);
            this.label21.TabIndex = 58;
            this.label21.Text = "ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 16);
            this.label22.TabIndex = 60;
            this.label22.Text = "Nombre:";
            // 
            // txtidpaquetenacional
            // 
            this.txtidpaquetenacional.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtidpaquetenacional.Location = new System.Drawing.Point(35, 27);
            this.txtidpaquetenacional.Name = "txtidpaquetenacional";
            this.txtidpaquetenacional.Size = new System.Drawing.Size(68, 22);
            this.txtidpaquetenacional.TabIndex = 59;
            // 
            // cbtipopagoreservacion
            // 
            this.cbtipopagoreservacion.FormattingEnabled = true;
            this.cbtipopagoreservacion.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo",
            "Depósito"});
            this.cbtipopagoreservacion.Location = new System.Drawing.Point(147, 175);
            this.cbtipopagoreservacion.Name = "cbtipopagoreservacion";
            this.cbtipopagoreservacion.Size = new System.Drawing.Size(100, 24);
            this.cbtipopagoreservacion.TabIndex = 55;
            this.cbtipopagoreservacion.Text = "Depósito";
            // 
            // txtpagoreservacion
            // 
            this.txtpagoreservacion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtpagoreservacion.Location = new System.Drawing.Point(147, 138);
            this.txtpagoreservacion.Name = "txtpagoreservacion";
            this.txtpagoreservacion.Size = new System.Drawing.Size(52, 22);
            this.txtpagoreservacion.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Pago:";
            // 
            // dtfechareservacion
            // 
            this.dtfechareservacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechareservacion.Location = new System.Drawing.Point(147, 209);
            this.dtfechareservacion.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtfechareservacion.Name = "dtfechareservacion";
            this.dtfechareservacion.Size = new System.Drawing.Size(117, 22);
            this.dtfechareservacion.TabIndex = 57;
            // 
            // txtcedulaclientereservacion
            // 
            this.txtcedulaclientereservacion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtcedulaclientereservacion.Location = new System.Drawing.Point(147, 64);
            this.txtcedulaclientereservacion.Name = "txtcedulaclientereservacion";
            this.txtcedulaclientereservacion.Size = new System.Drawing.Size(212, 22);
            this.txtcedulaclientereservacion.TabIndex = 54;
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
            this.label17.Size = new System.Drawing.Size(55, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Fecha:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = global::CapaPresentacion.Properties.Resources.guardar1;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnguardar.Location = new System.Drawing.Point(574, 201);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(54, 36);
            this.btnguardar.TabIndex = 48;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 16);
            this.label18.TabIndex = 29;
            this.label18.Text = "Id Reservación:";
            // 
            // btneditar
            // 
            this.btneditar.BackgroundImage = global::CapaPresentacion.Properties.Resources.editar;
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.Location = new System.Drawing.Point(649, 201);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(55, 36);
            this.btneditar.TabIndex = 49;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = global::CapaPresentacion.Properties.Resources.Cancelar;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btncancelar.Location = new System.Drawing.Point(728, 201);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(51, 36);
            this.btncancelar.TabIndex = 50;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtidreservacion
            // 
            this.txtidreservacion.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtidreservacion.Location = new System.Drawing.Point(147, 22);
            this.txtidreservacion.Name = "txtidreservacion";
            this.txtidreservacion.ReadOnly = true;
            this.txtidreservacion.Size = new System.Drawing.Size(43, 22);
            this.txtidreservacion.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(0, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(778, 43);
            this.label12.TabIndex = 54;
            this.label12.Text = "Reservaciones Paquete Nacional Destiny Tour Nicaragua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
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
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
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
            this.datalistado.Location = new System.Drawing.Point(8, 307);
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
            this.datalistado.Size = new System.Drawing.Size(1103, 224);
            this.datalistado.TabIndex = 105;
            this.datalistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistado_CellContentClick);
            this.datalistado.DoubleClick += new System.EventHandler(this.datalistado_DoubleClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Anular";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 42;
            // 
            // frmReservacionPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1134, 624);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservacionPaquete";
            this.Text = "Reservacion Paquete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReservacionPaquete_FormClosing);
            this.Load += new System.EventHandler(this.frmReservacionPaquete_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfacturareservacion;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.CheckBox chkanular;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.DateTimePicker dtbuscarfecha;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnombreclientereservacion;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtidformapago;
        private System.Windows.Forms.Button btneliminarreservacion;
        private System.Windows.Forms.Label lbltotalreservaciones;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnbuscarpaquete;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtnombrepaquete;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtidpaquetenacional;
        private System.Windows.Forms.ComboBox cbtipopagoreservacion;
        private System.Windows.Forms.TextBox txtpagoreservacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtfechareservacion;
        private System.Windows.Forms.TextBox txtcedulaclientereservacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtidreservacion;
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
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpendiente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtfechapaquete;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}