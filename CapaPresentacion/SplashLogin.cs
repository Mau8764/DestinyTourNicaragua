using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class SplashLogin : Form
    {
        
        private string _NombreUsuario;
        private string _Acceso;
        public SplashLogin()
        {
            InitializeComponent();
        }

        

        public string NombreUsuario
        {
            get
            {
                return _NombreUsuario;
            }

            set
            {
                _NombreUsuario = value;
            }
        }

        public string Acceso
        {
            get
            {
                return _Acceso;
            }

            set
            {
                _Acceso = value;
            }
        }

        private void SplashLogin_Load(object sender, EventArgs e)
        {
            progressbar.Visible = true;
            pictureBox2.Enabled = false;
            lblnombreusuario.Text = NombreUsuario;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbar.Value += 1;
            if (progressbar.Value == 104)
            {
                timer1.Stop();
                frmPrincipal frm = new frmPrincipal();
                frm.Acceso = Acceso;
                this.Hide();
                frm.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
