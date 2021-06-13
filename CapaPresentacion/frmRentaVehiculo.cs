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
using System.Data.SqlClient;
namespace CapaPresentacion
{
    public partial class frmRentaVehiculo : Form
    {
        public string Acceso = "";
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private static frmRentaVehiculo _Instancia;
        public static frmRentaVehiculo GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmRentaVehiculo();
            }
            return _Instancia;
        }

        public void obtenerCliente(string cedulacliente, string nombrecliente)
        {
            this.txtcedulacliente.Text = cedulacliente;
            this.txtnombrecliente.Text = nombrecliente;
        }
        public frmRentaVehiculo()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.cbtipovehiculo, "Seleccione el tipo de vechículo a reservar");
            this.ttMensaje.SetToolTip(this.btnbuscarcliente, "Presione para seleccionar el cliente que realizará la renta");
            this.ttMensaje.SetToolTip(this.dtfecharenta, "Ingrese la fecha en que se realizará la renta");
            this.ttMensaje.SetToolTip(this.dtfechadevolucion, "Seleccione la fecha de devolución del vehículo");
            this.ttMensaje.SetToolTip(this.dtfechareservacion, "Seleccione la fecha en que se realiza la reservación");
            this.ttMensaje.SetToolTip(this.txtpago, "Ingrese la cantidad pagada por el cliente");
            this.ttMensaje.SetToolTip(this.cbtipopago, "Seleccione el tipo del pago");
        }

        //Mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Destiny Tour Nicaragua", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Destiny Tour Nicaragua", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo para limpiar los controles del formulario
        private void Limpiar()
        {
            this.txtidrenta.Text = string.Empty;
            this.txtcantidaddias.Text = string.Empty;
            this.txtcedulacliente.Text = string.Empty;
            this.txtidreservacion.Text = string.Empty;
            this.txtnombrecliente.Text = string.Empty;
            this.txtpago.Text = string.Empty;

        }


        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtcantidaddias.ReadOnly = !valor;
            this.txtpago.ReadOnly = !valor;
            this.cbtipovehiculo.Enabled = valor;
            this.dtfecharenta.Enabled = valor;
            this.dtfechadevolucion.Enabled = valor;
            this.dtfechareservacion.Enabled = valor;
            this.cbtipopago.Enabled = valor;
            this.btnbuscarcliente.Enabled = valor;

        }

        //metodo para hablilitar los botones del formulario
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        //Metodo para ocultar columnas
        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
            this.datalistado.Columns[2].Visible = false;
            this.datalistado.Columns[3].Visible = false;
            this.datalistado.Columns[4].Width = 130;
            this.datalistado.Columns[5].Width = 130;

        }
        private void Mostrar()
        {
            this.datalistado.DataSource = LRentaVehiculo.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        private void frmRentaVehiculo_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void frmRentaVehiculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btneliminarreservacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkeliminar.Checked == true)
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Realmente desea anular la renta", "Destiny Tour Nicaragua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        int idreservacion;
                        string Rpta = "";

                        foreach (DataGridViewRow row in datalistado.Rows)
                        {
                            if ((Convert.ToBoolean(row.Cells[0].Value)))
                            {
                                idreservacion = Convert.ToInt32(row.Cells[1].Value);
                                Rpta = LRentaVehiculo.Eliminar(idreservacion);
                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se anuló correctamente la renta del vehículo");
                                }
                                else
                                {
                                    this.MensajeError(Rpta);
                                }
                            }
                        }
                        this.Mostrar();

                    }
                }
                else
                {
                    this.MensajeError("Debe seleccionar una fila para poder eliminarla");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            chkeliminar.Checked = false;
        }

        private void chkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkeliminar.Checked)
            {
                this.datalistado.Columns[0].Visible = true;

            }
            else
            {
                this.datalistado.Columns[0].Visible = false;
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";



                if (txtcedulacliente.Text == string.Empty || txtcantidaddias.Text == string.Empty || txtpago.Text == string.Empty)
                {
                    MensajeError("Falta ingresar los datos requeridos");

                    erroricono.SetError(txtcedulacliente, "Presione el botón con el ícono de la lupa para buscar un cliente y realizar la renta");
                    erroricono.SetError(txtcantidaddias, "Ingrese la cantidad de días");
                    erroricono.SetError(txtpago, "Ingrese la cantidad a pagar");

                }
                else
                {
                    if (IsNuevo)
                    {
                        Rpta = LRentaVehiculo.Insertar(Convert.ToInt32(ObtenerMaxIdTipoServicio()) + 1, Convert.ToInt32(txtcantidaddias.Text), cbtipovehiculo.Text, dtfecharenta.Value, dtfechadevolucion.Value, txtplaca.Text);
                        LReservacion.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion())+1,dtfechareservacion.Value,Convert.ToDecimal(txtpago.Text),txtcedulacliente.Text);
                       
                        
                        //insercion en las demas tablas relacionadas a reservacion
                        LFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdFormaPago()) + 1, cbtipopago.Text.ToUpper().Trim());
                        LReservacionFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), Convert.ToInt32(ObtenerMaxIdFormaPago()));
                        LServicioDeReservacion.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), dtfechareservacion.Value,Convert.ToInt32( ObtenerMaxIdTipoServicio()));


                    }
                    else if (IsEditar)
                    {
                        Rpta = LRentaVehiculo.Editar(Convert.ToInt32(txtidrenta.Text), Convert.ToInt32(txtcantidaddias.Text), cbtipovehiculo.Text, dtfecharenta.Value, dtfechadevolucion.Value, txtplaca.Text);
                        LReservacion.Editar(Convert.ToInt32(txtidreservacion.Text),dtfechareservacion.Value,Convert.ToDecimal(txtpago.Text),txtcedulacliente.Text);
                        LFormaPago.Editar(Convert.ToInt32(txtidpago.Text), cbtipopago.Text);


                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Renta registrada con éxito");

                        }
                        else if (this.IsEditar)
                        {
                            this.MensajeOk("Se actualizó la renta de manera correcta");

                        }
                    }
                    else
                    {
                        this.MensajeError(Rpta);

                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private static string ObtenerMaxIdTipoServicio()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=(local); Initial Catalog=Destiny; Integrated Security=true"))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select MAX(Id_servicio) From Tipo_servicio", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // txtidreservacion.Text = Convert.ToString(dr[""]);

                }

                return Convert.ToString(dr[""]);
            }

        }
        private static string ObtenerMaxIdReservacion()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=(local); Initial Catalog=Destiny; Integrated Security=true"))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select MAX(Id_Reservacion) From Reservacion", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // txtidreservacion.Text = Convert.ToString(dr[""]);

                }

                return Convert.ToString(dr[""]);
            }

        }
        private static string ObtenerMaxIdFormaPago()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=(local); Initial Catalog=Destiny; Integrated Security=true"))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select MAX(Id_FormaPago) From Forma_Pago", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // txtidreservacion.Text = Convert.ToString(dr[""]);

                }

                return Convert.ToString(dr[""]);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtidrenta.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.txtcantidaddias.Focus();

            }
            else
            {
                this.MensajeError("Debe seleccionar primero el registro que desea modificar");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            frmVistaClientePersona form = new frmVistaClientePersona();
            form.Servicio = "RentaVehiculo";
            form.ShowDialog();
        }

        private void btnfacturareservacion_Click(object sender, EventArgs e)
        {
            
            if (Acceso.Equals("Administrador"))
            {
                frmFacturaRentaVehiculo frm = new frmFacturaRentaVehiculo();
            frm.IdReservacion = Convert.ToInt32(this.datalistado.CurrentRow.Cells["Id_reservacion"].Value);
            frm.ShowDialog();
            }
            else
            {
                MensajeError("Usted no tiene permiso de Administrador");
            }
        }

        //Metodos para buscar 
        private void BuscarCedula()
        {
            this.datalistado.DataSource = LRentaVehiculo.BuscarCedula(txtbuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.datalistado.DataSource = LRentaVehiculo.BuscarNombre(txtbuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarFecha()
        {
            this.datalistado.DataSource = LRentaVehiculo.BuscarFecha(dtbuscarfecha.Value);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        private void cbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Nombre"))
            {
                this.txtbuscar.Visible = true;
                this.dtbuscarfecha.Visible = false;
            }
            else if (cbbuscar.Text.Equals("Cedula"))
            {
                this.txtbuscar.Visible = true;
                this.dtbuscarfecha.Visible = false;
            }
            else if (cbbuscar.Text.Equals("Fecha"))
            {
                this.txtbuscar.Visible = false;
                this.dtbuscarfecha.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFecha();

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
            }
            else if (cbbuscar.Text.Equals("Cedula"))
            {
                this.BuscarCedula();
            }
            else if (txtbuscar.Text == string.Empty)
            {
                Mostrar();
            }
        }

        private void datalistado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistado.Columns["dataGridViewCheckBoxColumn1"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)datalistado.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void datalistado_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtidreservacion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Id_reservacion"].Value);
            this.txtidpago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Id_FormaPago"].Value);
            this.txtidrenta.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["IdRentaVehiculo"].Value);
            this.txtnombrecliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            this.txtcedulacliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cedula"].Value);
            this.dtfechareservacion.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Reservación"].Value);
            this.txtpago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Pago"].Value);
            this.cbtipopago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tipo Pago"].Value);
            this.txtcantidaddias.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cantidad Días"].Value);
            this.cbtipovehiculo.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tipo Vehículo"].Value);
            this.dtfecharenta.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Renta"].Value);
            this.dtfechadevolucion.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Devolución"].Value);
            this.txtplaca.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Placa"].Value);


        }
    }
}
