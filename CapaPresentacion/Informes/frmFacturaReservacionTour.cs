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

   
    public partial class frmFacturaReservacionTour : Form
    {
        private int _IdReservacion;
        public frmFacturaReservacionTour()
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

        private void frmFacturaReservacionTour_Load(object sender, EventArgs e)
        {
            this.sP_FacturaReservacionTableAdapter.Fill(this.dataSet1.SP_FacturaReservacion, this.IdReservacion);

            this.reportViewer1.RefreshReport();
        }
    }
}
