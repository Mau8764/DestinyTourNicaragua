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
    public partial class frmFacturaHotel : Form
    {
        private int _IdReservacion;
        public frmFacturaHotel()
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

        private void frmFacturaHotel_Load(object sender, EventArgs e)
        {
            this.sP_FacturaHotelTableAdapter.Fill(this.dataSet1.SP_FacturaHotel,IdReservacion);
            this.reportViewer1.RefreshReport();
        }
    }
}
