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
    public partial class frmBoletoAereo : Form
    {
        public string Acceso = "";
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private static frmBoletoAereo _Instancia;
        public static frmBoletoAereo GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmBoletoAereo();
            }
            return _Instancia;
        }
        public void obtenerCliente(string cedulacliente, string nombrecliente)
        {
            this.txtcedulacliente.Text = cedulacliente;
            this.txtnombrecliente.Text = nombrecliente;
        }
        public frmBoletoAereo()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtdestino, "Ingrese el destino del boleto a vender");
            this.ttMensaje.SetToolTip(this.btnbuscarcliente, "Presione para seleccionar el cliente que realizará la compra");
            this.ttMensaje.SetToolTip(this.txttarifa, "Ingrese la tárifa del boleto a vender");
            this.ttMensaje.SetToolTip(this.dtfechaida, "Seleccione la fecha de ida del boleto");
            this.ttMensaje.SetToolTip(this.dtfecharegreso, "Seleccione la fecha de regreso");
            this.ttMensaje.SetToolTip(this.txtlineaaerea, "Ingrese la línea aérea");
            this.ttMensaje.SetToolTip(this.txtcabinaavion, "Ingrese la cabina de avión del boleto");
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
            this.txtidboleto.Text = string.Empty;
            this.txtcedulacliente.Text = string.Empty;
            this.txtnombrecliente.Text = string.Empty;
            this.txtdestino.Text = string.Empty;
            this.txttarifa.Text = string.Empty;
            this.txtlineaaerea.Text = string.Empty;
            this.txtcabinaavion.Text = string.Empty;
            this.txtidreservacion.Text = string.Empty;
            this.txtidpago.Text = string.Empty;
            this.txtpago.Text = string.Empty;

        }

        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            //textbox
            this.txtdestino.ReadOnly = !valor;
            this.txttarifa.ReadOnly = !valor;
            this.txtlineaaerea.ReadOnly = !valor;
            this.txtcabinaavion.ReadOnly = !valor;
            this.txtpago.ReadOnly = !valor;

            //otros controles
            this.dtfechaida.Enabled = valor;
            this.dtfecharegreso.Enabled = valor;
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
            this.datalistado.Columns[4].Width = 130;
            this.datalistado.Columns[5].Width = 130;
            this.datalistado.Columns[9].Width = 130;
            this.datalistado.Columns[13].Width = 110;
            this.datalistado.Columns[6].Width = 130;
            this.datalistado.Columns[11].Width = 130;
        }
        private void Mostrar()
        {
            this.datalistado.DataSource = LBoletosAereos.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void frmBoletoAereo_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void frmBoletoAereo_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btneliminar_Click(object sender, EventArgs e)
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
                                Rpta = LBoletosAereos.Eliminar(idreservacion);
                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se anuló correctamente la venta del boleto");
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

        private void chkeliminar_CheckedChanged(object sender, EventArgs e)
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



                if (txtcedulacliente.Text == string.Empty || txtdestino.Text == string.Empty || txttarifa.Text == string.Empty
                    || txtlineaaerea.Text == string.Empty || txtcabinaavion.Text == string.Empty || txtpago.Text == string.Empty)
                {
                    MensajeError("Falta ingresar los datos requeridos");

                    erroricono.SetError(txtcedulacliente, "Presione el botón con el ícono de la lupa para buscar un cliente y realizar la renta");
                    erroricono.SetError(txtdestino, "Ingrese el destino del boleto");
                    erroricono.SetError(txttarifa, "Ingrese el precio del boleto");
                    erroricono.SetError(txtlineaaerea, "Ingrese el nombre de la línea aérea");
                    erroricono.SetError(txtcabinaavion, "Ingrese la cabina del avión");
                    erroricono.SetError(txtpago, "Ingrese el nombre de la línea aérea");

                }
                else
                {
                    if (IsNuevo)
                    {
                        Rpta = LBoletosAereos.Insertar(Convert.ToInt32(ObtenerMaxIdTipoServicio())+1,txtdestino.Text.ToUpper().Trim(),dtfechaida.Value,Convert.ToDecimal(txttarifa.Text),
                            dtfecharegreso.Value,txtlineaaerea.Text.ToUpper().Trim(), txtcabinaavion.Text.ToUpper().Trim());
                        LReservacion.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion())+1,dtfechareservacion.Value,Convert.ToDecimal(txtpago.Text),txtcedulacliente.Text);

                        //insercion en las demas tablas relacionadas a reservacion
                        LFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdFormaPago()) + 1, cbtipopago.Text.ToUpper().Trim());
                        LReservacionFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), Convert.ToInt32(ObtenerMaxIdFormaPago()));
                        LServicioDeReservacion.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), dtfechareservacion.Value, Convert.ToInt32(ObtenerMaxIdTipoServicio()));


                    }
                    else if (IsEditar)
                    {
                        Rpta = LBoletosAereos.Editar(Convert.ToInt32(txtidboleto.Text),txtdestino.Text.ToUpper().Trim(), dtfechaida.Value,Convert.ToDecimal(txttarifa.Text),dtfecharegreso.Value,txtlineaaerea.Text.ToUpper().Trim(), txtcabinaavion.Text.ToUpper().Trim());
                        LReservacion.Editar(Convert.ToInt32(txtidreservacion.Text), dtfechareservacion.Value, Convert.ToDecimal(txtpago.Text), txtcedulacliente.Text);
                        LFormaPago.Editar(Convert.ToInt32(txtidpago.Text), cbtipopago.Text.ToUpper().Trim());


                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Venta registrada con éxito");

                        }
                        else if (this.IsEditar)
                        {
                            this.MensajeOk("Se actualizó la venta de manera correcta");

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
            if (!this.txtidboleto.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.txtdestino.Focus();

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
            this.txtidboleto.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["IdBoleto"].Value);
            this.txtnombrecliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            this.txtcedulacliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cedula"].Value);
            this.dtfechareservacion.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Reservación"].Value);
            this.txtpago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Pago"].Value);
            this.cbtipopago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tipo Pago"].Value);
            this.txtdestino.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Destino"].Value);
            this.dtfechaida.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Ida"].Value);
            this.dtfecharegreso.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Regreso"].Value);
            this.txttarifa.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tarifa"].Value);
            this.txtlineaaerea.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Línea Aérea"].Value);
            this.txtcabinaavion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cabina Avión"].Value);
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        { 

            frmVistaClientePersona form = new frmVistaClientePersona();
            form.Servicio = "Boleto";
            form.ShowDialog();
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            if (Acceso.Equals("Administrador"))
            {
                frmFacturaBoleto frm = new frmFacturaBoleto();
                frm.IdReservacion = Convert.ToInt32(this.datalistado.CurrentRow.Cells["Id_reservacion"].Value);
                frm.ShowDialog();
            }
            else
            {
                MensajeError("Usted no tiene permiso de Administrador");
            }

        }

        //Metodos para buscar boleto
        private void BuscarCedula()
        {
            this.datalistado.DataSource = LBoletosAereos.BuscarCedula(txtbuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.datalistado.DataSource = LBoletosAereos.BuscarNombre(txtbuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarFecha()
        {
            this.datalistado.DataSource = LBoletosAereos.BuscarFecha(dtbuscarfecha.Value);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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

        private void dtbuscarfecha_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Fecha"))
            {
                this.BuscarFecha();
            }
            
        }
    }
}
