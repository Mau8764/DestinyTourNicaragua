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
    public partial class frmVistaTourNacional : Form
    {
        string par1, par2, par3;
        DateTime fecha;
        public string Consulta="";
        public frmVistaTourNacional()
        {
            InitializeComponent();
        }

        private void frmVistaTourNacional_Load(object sender, EventArgs e)
        {
            Mostrar();
        }



        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;

        }

        //Metodo para mostrar todos los tour
        private void Mostrar()
        {
            this.datalistado.DataSource = LTourNacional.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        //Metodos para Buscar 
        private void BuscarTour_Nombre()
        {
            this.datalistado.DataSource = LTourNacional.BuscarTour_Nombre(txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarTour_Fecha()
        {
            this.datalistado.DataSource = LTourNacional.BuscarTour_Fecha(dtbuscarfecha.Value);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Nombre"))
            {
                this.BuscarTour_Nombre();
            }
            else if (cbbuscar.Text.Equals("Fecha"))
            {
                this.BuscarTour_Fecha();
            }
            if (txtBuscar.Text == string.Empty)
            {
                Mostrar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Nombre"))
            {
                this.BuscarTour_Nombre();
            }
            else if (cbbuscar.Text.Equals("Fecha"))
            {
                this.BuscarTour_Fecha();
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void cbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Nombre"))
            {
                this.txtBuscar.Visible = true;
                this.dtbuscarfecha.Visible = false;
            }
            else if (cbbuscar.Text.Equals("Fecha"))
            {
                this.txtBuscar.Visible = false;
                this.dtbuscarfecha.Visible = true;
            }
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Nombre"))
            {
                this.BuscarTour_Nombre();
            }
            else if (cbbuscar.Text.Equals("Fecha"))
            {
                this.BuscarTour_Fecha();
            }

            if (txtBuscar.Text == string.Empty)
            {
                Mostrar();
            }
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistado_DoubleClick_1(object sender, EventArgs e)
        {
            Reservacion form = Reservacion.GetInstancia();
            if (Consulta.Equals("Reservacion"))
            {
                par1 = Convert.ToString(this.datalistado.CurrentRow.Cells["IdTour"].Value);
                par2 = Convert.ToString(this.datalistado.CurrentRow.Cells["NombreTour"].Value);
                par3 = Convert.ToString(this.datalistado.CurrentRow.Cells["Fecha_Tour"].Value);
                form.obtenerTour(par1, par2, par3);
                this.Hide();
            }
            else if (Consulta.Equals("MostrarPorTour"))
            {
                par2 = Convert.ToString(this.datalistado.CurrentRow.Cells["NombreTour"].Value);
                fecha = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha_Tour"].Value);
                form.ReservacionPorTour(par2, fecha);
                this.Hide();
            }

        }
    }
}
