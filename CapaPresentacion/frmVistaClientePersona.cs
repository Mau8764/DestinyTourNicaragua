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
    public partial class frmVistaClientePersona : Form
    {

        private string _Servicio;
        private string par1, par2, edad;
        public string Servicio
        {
            get
            {
                return _Servicio;
            }

            set
            {
                _Servicio = value;
            }
        }

        public frmVistaClientePersona()
        {
            InitializeComponent();
        }

        private void frmVistaClientePersona_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;

        }

        //Metodo para mostrar todos los servicios
        private void Mostrar()
        {
            this.datalistado.DataSource = LClientePersona.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        //Metodo para Buscar por cedula
        private void BuscarCedula()
        {
            this.datalistado.DataSource = LClientePersona.BuscarCedula(txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.datalistado.DataSource = LClientePersona.BuscarNombre(txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
            }
            else if (cbbuscar.Text.Equals("Cedula"))
            {
                this.BuscarCedula();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
            }
            else
            {
                this.BuscarCedula();
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            
                
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistado_DoubleClick_1(object sender, EventArgs e)
        {
            par1 = Convert.ToString(this.datalistado.CurrentRow.Cells["Cedula"].Value);
            par2 = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            edad = Convert.ToString(this.datalistado.CurrentRow.Cells["Edad"].Value);
            if (Servicio.Equals("ReservacionTour"))
            {
                Reservacion form = Reservacion.GetInstancia();
                form.obtenerCliente(par1, par2);
                this.Hide();
            }
           else if (Servicio.Equals("RentaVehiculo"))
            {
                frmRentaVehiculo frmrenta = frmRentaVehiculo.GetInstancia();
                frmrenta.obtenerCliente(par1, par2);
                this.Hide();
            }
            else if (Servicio.Equals("Boleto"))
            {
                frmBoletoAereo frmboleto = frmBoletoAereo.GetInstancia();
                frmboleto.obtenerCliente(par1, par2);
                this.Hide();
            }
            else if (Servicio.Equals("Hotel"))
            {
                frmHoteles frmhoteles = frmHoteles.GetInstancia();
                frmhoteles.obtenerCliente(par1, par2, edad);
                this.Hide();
            }
            else if (Servicio.Equals("SeguroViaje"))
            {
                frmSeguroViaje frmseguro = frmSeguroViaje.GetInstancia();
                frmseguro.obtenerCliente(par1, par2);
                this.Hide();
            }
            else if (Servicio.Equals("ReservacionPaquete"))
            {
                frmReservacionPaquete frmReservacion = frmReservacionPaquete.GetInstancia();
                frmReservacion.obtenerCliente(par1, par2);
                this.Hide();
            }               
        }
    }
}
