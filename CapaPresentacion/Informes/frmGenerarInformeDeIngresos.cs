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
    public partial class frmGenerarInformeDeIngresos : Form
    {
        public frmGenerarInformeDeIngresos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInformeDeIngresos frm = new frmInformeDeIngresos();
            frm.FechaInicial = dtfechainicial.Value;
            frm.FechaFinal = dtfechafinal.Value;
            frm.ShowDialog();
        }

        private void frmGenerarInformeDeIngresos_Load(object sender, EventArgs e)
        {

        }
    }
}
