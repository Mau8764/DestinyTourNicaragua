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
    public partial class frmInformeDeIngresos : Form
    {
        private DateTime _FechaInicial;
        private DateTime _FechaFinal;

        public DateTime FechaInicial
        {
            get
            {
                return _FechaInicial;
            }

            set
            {
                _FechaInicial = value;
            }
        }

        public DateTime FechaFinal
        {
            get
            {
                return _FechaFinal;
            }

            set
            {
                _FechaFinal = value;
            }
        }

        public frmInformeDeIngresos()
        {
            InitializeComponent();
        }

        private void frmInformeDeIngresos_Load(object sender, EventArgs e)
        {
            this.sP_InformeDeIngresosPorFechasTableAdapter.Fill(this.dataSet1.SP_InformeDeIngresosPorFechas,FechaInicial,FechaFinal);
            this.reportViewer1.RefreshReport();
        }
    }
}
