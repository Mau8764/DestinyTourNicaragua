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
    public partial class frmLogin : Form
    {

        string NombreUsuario;
        string Acceso;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text=="Usuario")
            {
                txtusuario.Text = "";
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text=="")
            {
                txtusuario.Text = "Usuario";
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text=="Contraseña")
            {
                txtpassword.Text = "";
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Constraseña";
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngreesar_Click(object sender, EventArgs e)
        {
            DataTable Datos = CapaLogica.LLogin.Login(txtusuario.Text,txtpassword.Text);
            //evaluar si exite
            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("Acceso Denegado","Destiny Tour Nicaragua",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                
                SplashLogin splash = new SplashLogin();
                splash.NombreUsuario= Datos.Rows[0][2].ToString();
                splash.Acceso= Datos.Rows[0][3].ToString();
                splash.Show();             
                this.Hide();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
