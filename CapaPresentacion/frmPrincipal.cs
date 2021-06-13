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
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;

        public string Acceso="";
        private static frmPrincipal _Instancia;
        public static frmPrincipal GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmPrincipal();
            }
            return _Instancia;
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void boletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoletoAereo frm = frmBoletoAereo.GetInstancia();
            frm.Acceso = Acceso;
            frm.MdiParent = this;
            frm.Show();
        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientePersona frm = new frmClientePersona();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarConsultarReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservacion frm = Reservacion.GetInstancia();
            frm.Acceso = Acceso;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tourNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTourNacional frm = new frmTourNacional();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (Acceso.Equals("Invitado"))
            {
                informesToolStripMenuItem.Enabled = false;
                boletosToolStripMenuItem.Enabled = false;
                seguroDeViajesToolStripMenuItem.Enabled = false;
                HotelesToolStripMenuItem.Enabled = false;
                rentaVehículoToolStripMenuItem.Enabled = false;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmTourNacional frm = new frmTourNacional();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rentaVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentaVehiculo frm = frmRentaVehiculo.GetInstancia();
            frm.Acceso = Acceso;
            frm.MdiParent = this;
            frm.Show();
        }

        private void informeDeReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerarInformeDeIngresos frm = new frmGenerarInformeDeIngresos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmClientePersona frm = new frmClientePersona();
            frm.MdiParent = this;
            frm.Show();
        }

        private void seguroDeVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoteles frm = frmHoteles.GetInstancia();
            frm.Acceso = Acceso;
            frm.MdiParent = this;
            frm.Show();
        }

        private void seguroDeViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeguroViaje frm = frmSeguroViaje.GetInstancia();
            frm.Acceso = Acceso;
            frm.MdiParent = this;
            frm.Show();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaqueteNacional frm = new frmPaqueteNacional();
            frm.MdiParent = this;
            frm.Show();
        }

        private void administrarReservacionesPaquetesNacionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservacionPaquete frm = frmReservacionPaquete.GetInstancia();
            frm.Acceso = Acceso;
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
