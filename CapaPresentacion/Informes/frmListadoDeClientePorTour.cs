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
    public partial class ListadoDeClientesPorTour : Form
    {
        private int _IdTour;
        public ListadoDeClientesPorTour()
        {
            InitializeComponent();
        }

        public int IdTour
        {
            get
            {
                return _IdTour;
            }

            set
            {
                _IdTour = value;
            }
        }

        private void ListadoDeClientesPorTour_Load(object sender, EventArgs e)
        {
            this.sP_ListadoDeClientesPorTourTableAdapter.Fill(this.dataSet1.SP_ListadoDeClientesPorTour, this.IdTour);
            this.reportViewer1.RefreshReport();
        }

        private void sPListadoDeClientesPorTourBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
