using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
namespace CapaPresentacion
{
    public partial class frmVistaPaqueteNacional : Form
    {
        public frmVistaPaqueteNacional()
        {
            InitializeComponent();
        }

        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
            this.datalistado.Columns[4].Width = 130;
            this.datalistado.Columns[7].Width = 130;
            this.datalistado.Columns[8].Width = 130;

        }
        private void Mostrar()
        {
            this.datalistado.DataSource = LPaqueteNacional.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void frmVistaPaqueteNacional_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistado_DoubleClick_1(object sender, EventArgs e)
        {
            frmReservacionPaquete form = frmReservacionPaquete.GetInstancia();
            string par1, par2, par3;
            DateTime fecha;
            par1 = Convert.ToString(this.datalistado.CurrentRow.Cells["IdPaqueteNacional"].Value);
            par2 = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            fecha = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha"].Value);
            par3 = Convert.ToString(this.datalistado.CurrentRow.Cells["Precio"].Value);

            form.obtenerpaquete(par1, par2, fecha, par3);
            this.Hide();
        }
    }
}
