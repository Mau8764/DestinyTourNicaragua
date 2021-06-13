namespace CapaPresentacion
{
    partial class SplashLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashLogin));
            this.label12 = new System.Windows.Forms.Label();
            this.lblnombreusuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(12, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 43);
            this.label12.TabIndex = 63;
            this.label12.Text = "Bienvenido:";
            // 
            // lblnombreusuario
            // 
            this.lblnombreusuario.AutoSize = true;
            this.lblnombreusuario.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreusuario.ForeColor = System.Drawing.Color.Green;
            this.lblnombreusuario.Location = new System.Drawing.Point(12, 119);
            this.lblnombreusuario.Name = "lblnombreusuario";
            this.lblnombreusuario.Size = new System.Drawing.Size(123, 43);
            this.lblnombreusuario.TabIndex = 64;
            this.lblnombreusuario.Text = "Nombre";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.ss1;
            this.pictureBox2.Location = new System.Drawing.Point(349, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // progressbar
            // 
            this.progressbar.animated = true;
            this.progressbar.animationIterval = 1;
            this.progressbar.animationSpeed = 1;
            this.progressbar.BackColor = System.Drawing.Color.Transparent;
            this.progressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressbar.BackgroundImage")));
            this.progressbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.progressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(188)))), ((int)(((byte)(48)))));
            this.progressbar.LabelVisible = false;
            this.progressbar.LineProgressThickness = 7;
            this.progressbar.LineThickness = 6;
            this.progressbar.Location = new System.Drawing.Point(310, -1);
            this.progressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressbar.MaxValue = 104;
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressBackColor = System.Drawing.Color.Transparent;
            this.progressbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(188)))), ((int)(((byte)(48)))));
            this.progressbar.Size = new System.Drawing.Size(236, 236);
            this.progressbar.TabIndex = 0;
            this.progressbar.Value = 0;
            // 
            // SplashLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 234);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblnombreusuario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.progressbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashLogin";
            this.Load += new System.EventHandler(this.SplashLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar progressbar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblnombreusuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}