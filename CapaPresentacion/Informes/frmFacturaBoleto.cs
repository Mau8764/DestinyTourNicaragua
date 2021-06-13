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
    public partial class frmFacturaBoleto : Form
    {
        private int _IdReservacion;
        public frmFacturaBoleto()
        {
            InitializeComponent();
        }

        public int IdReservacion
        {
            get
            {
                return _IdReservacion;
            }

            set
            {
                _IdReservacion = value;
            }
        }

        private void frmFacturaBoleto_Load(object sender, EventArgs e)
        {
            this.sP_FacturaBoletoTableAdapter.Fill(this.dataSet1.SP_FacturaBoleto,IdReservacion);
            this.reportViewer1.RefreshReport();
        }
    }
}
