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
    public partial class frmFacturaRentaVehiculo : Form
    {
        private int _IdReservacion;
        public frmFacturaRentaVehiculo()
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

        private void frmFacturaRentaVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.SP_FacturaRentaVehiculo' Puede moverla o quitarla según sea necesario.
            this.SP_FacturaRentaVehiculoTableAdapter.Fill(this.DataSet1.SP_FacturaRentaVehiculo,IdReservacion);

            this.reportViewer1.RefreshReport();
        }
    }
}
