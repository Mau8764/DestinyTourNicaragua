namespace CapaPresentacion
{
    partial class frmGenerarInformeDeIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarInformeDeIngresos));
            this.dtfechainicial = new System.Windows.Forms.DateTimePicker();
            this.dtfechafinal = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtfechainicial
            // 
            this.dtfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechainicial.Location = new System.Drawing.Point(161, 31);
            this.dtfechainicial.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtfechainicial.Name = "dtfechainicial";
            this.dtfechainicial.Size = new System.Drawing.Size(96, 20);
            this.dtfechainicial.TabIndex = 0;
            // 
            // dtfechafinal
            // 
            this.dtfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechafinal.Location = new System.Drawing.Point(263, 31);
            this.dtfechafinal.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtfechafinal.Name = "dtfechafinal";
            this.dtfechafinal.Size = new System.Drawing.Size(96, 20);
            this.dtfechafinal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.GENERAR;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.generar1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(228, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGenerarInformeDeIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(392, 136);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtfechafinal);
            this.Controls.Add(this.dtfechainicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGenerarInformeDeIngresos";
            this.Text = "Generar Informe";
            this.Load += new System.EventHandler(this.frmGenerarInformeDeIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtfechainicial;
        private System.Windows.Forms.DateTimePicker dtfechafinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}