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
    public partial class frmFacturaSeguroViaje : Form
    {

        private int _IdReservacion;
        public frmFacturaSeguroViaje()
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

        private void frmFacturaSeguroViaje_Load(object sender, EventArgs e)
        {
            this.sP_FacturaSeguroViajesTableAdapter.Fill(this.dataSet1.SP_FacturaSeguroViajes, IdReservacion);
            this.reportViewer1.RefreshReport();
        }
    }
}
