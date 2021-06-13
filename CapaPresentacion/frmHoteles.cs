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
    public partial class frmHoteles : Form
    {
        public string Acceso = "";
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private static frmHoteles _Instancia;
        public static frmHoteles GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmHoteles();
            }
            return _Instancia;
        }

        public void obtenerCliente(string cedulacliente, string nombrecliente,string edadcliente)
        {
            this.txtcedulacliente.Text = cedulacliente;
            this.txtnombrecliente.Text = nombrecliente;
            this.txtedad.Text = edadcliente;
        }
        public frmHoteles()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.dtfechaingreso, "Seleccione la fecha en que ingresará el cliente al hotel");
            this.ttMensaje.SetToolTip(this.dtfechasalida, "Seleccione la fecha en que saldrá el cliente del hotel");
            this.ttMensaje.SetToolTip(this.txtedad, "Ingrese la edad del cliente");
            this.ttMensaje.SetToolTip(this.txtnombrehotel, "Ingrese el nombre del hotel a reservar");
            this.ttMensaje.SetToolTip(this.txtcantidadpersonas, "Ingrese la cantidad de personas de la reservación");
            this.ttMensaje.SetToolTip(this.txttipohabitacion, "Ingrese el tipo de habitación");
            this.ttMensaje.SetToolTip(this.dtfechareservacion, "Ingrese la fecha en que se realiza la compra");
            this.ttMensaje.SetToolTip(this.cbtipopago, "Seleccione el tipo de pago de la venta");
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
            this.txtidhotel.Text = string.Empty;
            this.txtcedulacliente.Text = string.Empty;
            this.txtnombrecliente.Text = string.Empty;
            this.txtnombrehotel.Text = string.Empty;
            this.txtedad.Text = string.Empty;
            this.txtcantidadpersonas.Text = string.Empty;
            this.txttipohabitacion.Text = string.Empty;
            this.txtidreservacion.Text = string.Empty;
            this.txtidpago.Text = string.Empty;
            this.txtpago.Text = string.Empty;

        }

        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            //textbox
            this.txtedad.ReadOnly = !valor;
            this.txtcantidadpersonas.ReadOnly = !valor;
            this.txttipohabitacion.ReadOnly = !valor;
            this.txtpago.ReadOnly = !valor;
            this.txtnombrehotel.ReadOnly = !valor;

            //otros controles
            this.dtfechaingreso.Enabled = valor;
            this.dtfechasalida.Enabled = valor;
            this.dtfechareservacion.Enabled = valor;
            this.cbtipopago.Enabled = valor;

        }

        //metodo para hablilitar los botones del formulario
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnnuevo.Enabled = false;
                this.btnguardar.Enabled = true;
                this.btneditar.Enabled = false;
                this.btncancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnnuevo.Enabled = true;
                this.btnguardar.Enabled = false;
                this.btneditar.Enabled = true;
                this.btncancelar.Enabled = false;
            }
        }

        //Metodo para ocultar columnas
        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
            this.datalistado.Columns[2].Visible = false;
            this.datalistado.Columns[3].Visible = false;
            this.datalistado.Columns[5].Width = 130;
            this.datalistado.Columns[6].Width = 130;
            this.datalistado.Columns[15].Width = 130;
        }

        private void Mostrar()
        {
            this.datalistado.DataSource = LHoteles.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        private void txtcantidadpersonas_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHoteles_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void frmHoteles_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkanular.Checked == true)
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Realmente desea anular la venta del boleto", "Destiny Tour Nicaragua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        int idreservacion;
                        string Rpta = "";

                        foreach (DataGridViewRow row in datalistado.Rows)
                        {
                            if ((Convert.ToBoolean(row.Cells[0].Value)))
                            {
                                idreservacion = Convert.ToInt32(row.Cells[1].Value);
                                Rpta = LHoteles.Eliminar(idreservacion);
                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se anuló correctamente la reservación del hotel");
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
            chkanular.Checked = false;
        }

        private void chkanular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkanular.Checked)
            {
                this.datalistado.Columns[0].Visible = true;

            }
            else
            {
                this.datalistado.Columns[0].Visible = false;
            }
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistado.Columns["dataGridViewCheckBoxColumn1"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)datalistado.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";



                if (txtcedulacliente.Text == string.Empty || txtedad.Text == string.Empty || txtcantidadpersonas.Text == string.Empty
                    || txttipohabitacion.Text == string.Empty || txtpago.Text == string.Empty || txtnombrehotel.Text==string.Empty)
                {
                    MensajeError("Falta ingresar los datos requeridos");

                    erroricono.SetError(txtcedulacliente, "Presione el botón con el ícono de la lupa para buscar un cliente y realizar la renta");
                    erroricono.SetError(txtedad, "Ingrese la edad de la persona");
                    erroricono.SetError(txtcantidadpersonas, "Ingrese la cantidad de personas");
                    erroricono.SetError(txttipohabitacion, "Ingrese el tipo de habitación del hotel");
                    erroricono.SetError(txtpago, "Ingrese el nombre de la línea aérea");
                    erroricono.SetError(txtnombrehotel, "Ingrese el nombre del hotel a reservar");
                }
                else
                {
                    if (IsNuevo)
                    {
                        Rpta = LHoteles.Insertar(Convert.ToInt32(ObtenerMaxIdTipoServicio())+1,txtnombrehotel.Text.ToUpper().Trim(),dtfechaingreso.Value,Convert.ToInt32(txtedad.Text),
                            dtfechasalida.Value,Convert.ToInt32(txtcantidadpersonas.Text),dtfechareservacion.Value,txttipohabitacion.Text.ToUpper().Trim());
                        LReservacion.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()) + 1, dtfechareservacion.Value, Convert.ToDecimal(txtpago.Text), txtcedulacliente.Text);

                        //insercion en las demas tablas relacionadas a reservacion
                        LFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdFormaPago()) + 1, cbtipopago.Text.ToUpper().Trim());
                        LReservacionFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), Convert.ToInt32(ObtenerMaxIdFormaPago()));
                        LServicioDeReservacion.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), dtfechareservacion.Value, Convert.ToInt32(ObtenerMaxIdTipoServicio()));


                    }
                    else if (IsEditar)
                    {
                        Rpta = LHoteles.Editar(Convert.ToInt32(txtidhotel.Text), txtnombrehotel.Text.ToUpper().Trim(), dtfechaingreso.Value,Convert.ToInt32(txtedad.Text),dtfechasalida.Value,
                            Convert.ToInt32(txtcantidadpersonas.Text),dtfechareservacion.Value,txttipohabitacion.Text.ToUpper().Trim());
                        LReservacion.Editar(Convert.ToInt32(txtidreservacion.Text), dtfechareservacion.Value, Convert.ToDecimal(txtpago.Text), txtcedulacliente.Text);
                        LFormaPago.Editar(Convert.ToInt32(txtidpago.Text), cbtipopago.Text.ToUpper().Trim());


                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Reservación registrada con éxito");

                        }
                        else if (this.IsEditar)
                        {
                            this.MensajeOk("Se actualizó la reservación de manera correcta");

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

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtidhotel.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.txtcantidadpersonas.Focus();

            }
            else
            {
                this.MensajeError("Debe seleccionar primero el registro que desea modificar");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtidreservacion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Id_reservacion"].Value);
            this.txtidpago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Id_FormaPago"].Value);
            this.txtidhotel.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["IdServicioHotel"].Value);
            this.txtnombrecliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            this.txtcedulacliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cedula"].Value);
            this.txtedad.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Edad"].Value);
            this.dtfechareservacion.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha de Contratación"].Value);
            this.txtpago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Pago"].Value);
            this.cbtipopago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tipo Pago"].Value);
            this.txtnombrehotel.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre del Hotel"].Value);
            this.dtfechaingreso.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Ingreso"].Value);
            this.dtfechasalida.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Salida"].Value);
            this.txtcantidadpersonas.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cantidad de Personas"].Value);
            this.txttipohabitacion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tipo de Habitación"].Value);
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            frmVistaClientePersona form = new frmVistaClientePersona();
            form.Servicio = "Hotel";
            form.ShowDialog();
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            
            if (Acceso.Equals("Administrador"))
            {
                frmFacturaHotel frm = new frmFacturaHotel();
                frm.IdReservacion = Convert.ToInt32(this.datalistado.CurrentRow.Cells["Id_reservacion"].Value);
                frm.ShowDialog();
            }
            else
            {
                MensajeError("Usted no tiene permiso de Administrador");
            }
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

        //Metodos para buscar boleto
        private void BuscarCedula()
        {
            this.datalistado.DataSource = LHoteles.BuscarCedula(txtbuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.datalistado.DataSource = LHoteles.BuscarNombre(txtbuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarFecha()
        {
            this.datalistado.DataSource = LHoteles.BuscarFecha(dtbuscarfecha.Value);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Fecha"))
            {
                this.BuscarFecha();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

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
            this.txtidhotel.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["IdServicioHotel"].Value);
            this.txtnombrecliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            this.txtcedulacliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cedula"].Value);
            this.txtedad.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Edad"].Value);
            this.dtfechareservacion.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha de Contratación"].Value);
            this.txtpago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Pago"].Value);
            this.cbtipopago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tipo Pago"].Value);
            this.txtnombrehotel.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre del Hotel"].Value);
            this.dtfechaingreso.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Ingreso"].Value);
            this.dtfechasalida.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Salida"].Value);
            this.txtcantidadpersonas.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cantidad de Personas"].Value);
            this.txttipohabitacion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tipo de Habitación"].Value);
        }
    }
}
