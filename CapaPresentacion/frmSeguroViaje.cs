﻿using System;
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
    public partial class frmSeguroViaje : Form
    {
        public string Acceso = "";
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private static frmSeguroViaje _Instancia;
        public static frmSeguroViaje GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmSeguroViaje();
            }
            return _Instancia;
        }

        public void obtenerCliente(string cedulacliente, string nombrecliente)
        {
            this.txtcedulacliente.Text = cedulacliente;
            this.txtnombrecliente.Text = nombrecliente;
        }

        public frmSeguroViaje()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtpasaporte, "Ingrese el destino del boleto a vender");
            this.ttMensaje.SetToolTip(this.btnbuscarcliente, "Presione para seleccionar el cliente que realizará la compra");
            this.ttMensaje.SetToolTip(this.txtdestino, "Ingrese el destino del boleto aéreo");
            this.ttMensaje.SetToolTip(this.dtfechaida, "Seleccione la fecha de ida del boleto");
            this.ttMensaje.SetToolTip(this.dtfecharegreso, "Seleccione la fecha de regreso");
            this.ttMensaje.SetToolTip(this.txtcontactoemergencia, "Ingrese el contacto de emergencia");
            this.ttMensaje.SetToolTip(this.txttelefonoemergencia, "Ingrese el telefono de emergencia");
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
            this.txtidseguro.Text = string.Empty;
            this.txtcedulacliente.Text = string.Empty;
            this.txtnombrecliente.Text = string.Empty;
            this.txtdestino.Text = string.Empty;
            this.txtpasaporte.Text = string.Empty;
            this.txtcontactoemergencia.Text = string.Empty;
            this.txttelefonoemergencia.Text = string.Empty;
            this.txtidreservacion.Text = string.Empty;
            this.txtidpago.Text = string.Empty;
            this.txtpago.Text = string.Empty;

        }

        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            //textbox
            this.txtdestino.ReadOnly = !valor;
            this.txtpasaporte.ReadOnly = !valor;
            this.txtcontactoemergencia.ReadOnly = !valor;
            this.txttelefonoemergencia.ReadOnly = !valor;
            this.txtpago.ReadOnly = !valor;

            //otros controles
            this.dtfechaida.Enabled = valor;
            this.dtfecharegreso.Enabled = valor;
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
            this.datalistado.DataSource = LSeguroViaje.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        private void frmSeguroViaje_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void frmSeguroViaje_FormClosing(object sender, FormClosingEventArgs e)
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
                    opcion = MessageBox.Show("Realmente desea anular el seguro de viaje", "Destiny Tour Nicaragua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        int idreservacion;
                        string Rpta = "";

                        foreach (DataGridViewRow row in datalistado.Rows)
                        {
                            if ((Convert.ToBoolean(row.Cells[0].Value)))
                            {
                                idreservacion = Convert.ToInt32(row.Cells[1].Value);
                                Rpta = LSeguroViaje.Eliminar(idreservacion);
                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se anuló correctamente el seguro de viaje");
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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



                if (txtcedulacliente.Text == string.Empty || txtdestino.Text == string.Empty || txtpasaporte.Text == string.Empty
                    || txtcontactoemergencia.Text == string.Empty || txttelefonoemergencia.Text == string.Empty || txtpago.Text == string.Empty)
                {
                    MensajeError("Falta ingresar los datos requeridos");

                    erroricono.SetError(txtcedulacliente, "Presione el botón con el ícono de la lupa para buscar un cliente y realizar la renta");
                    erroricono.SetError(txtdestino, "Ingrese el destino del boleto");
                    erroricono.SetError(txtpasaporte, "Ingrese el número de pasaporte");
                    erroricono.SetError(txtcontactoemergencia, "Ingrese el contacto de emergencia");
                    erroricono.SetError(txttelefonoemergencia, "Ingrese el teléfono ante cualquier emergencia");
                    erroricono.SetError(txtpago, "Ingrese el nombre de la línea aérea");

                }
                else
                {
                    if (IsNuevo)
                    {
                        Rpta = LSeguroViaje.Insertar(Convert.ToInt32(ObtenerMaxIdTipoServicio()) + 1, txtpasaporte.Text.ToUpper().Trim(), txtdestino.Text.ToUpper().Trim(), dtfechaida.Value,
                            dtfecharegreso.Value, txtcontactoemergencia.Text.ToUpper().Trim(), txttelefonoemergencia.Text.ToUpper().Trim());
                        LReservacion.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()) + 1, dtfechareservacion.Value, Convert.ToDecimal(txtpago.Text), txtcedulacliente.Text);

                        //insercion en las demas tablas relacionadas a reservacion
                        LFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdFormaPago()) + 1, cbtipopago.Text.ToUpper().Trim());
                        LReservacionFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), Convert.ToInt32(ObtenerMaxIdFormaPago()));
                        LServicioDeReservacion.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), dtfechareservacion.Value, Convert.ToInt32(ObtenerMaxIdTipoServicio()));


                    }
                    else if (IsEditar)
                    {
                        Rpta = LSeguroViaje.Editar(Convert.ToInt32(txtidseguro.Text), txtpasaporte.Text.ToUpper().Trim(), txtdestino.Text.ToUpper().Trim(),
                            dtfechaida.Value, dtfecharegreso.Value, txtcontactoemergencia.Text.ToUpper().Trim(), txttelefonoemergencia.Text.ToUpper().Trim());
                        LReservacion.Editar(Convert.ToInt32(txtidreservacion.Text), dtfechareservacion.Value, Convert.ToDecimal(txtpago.Text), txtcedulacliente.Text);
                        LFormaPago.Editar(Convert.ToInt32(txtidpago.Text), cbtipopago.Text.ToUpper().Trim());


                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Venta de seguro registrada con éxito");

                        }
                        else if (this.IsEditar)
                        {
                            this.MensajeOk("Se actualizó la venta del seguro de manera correcta");

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
            if (!this.txtidseguro.Text.Equals(""))
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
    
            
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            frmVistaClientePersona form = new frmVistaClientePersona();
            form.Servicio = "SeguroViaje";
            form.ShowDialog();
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            
            if (Acceso.Equals("Administrador"))
            {
            frmFacturaSeguroViaje frm = new frmFacturaSeguroViaje();
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
            this.datalistado.DataSource = LSeguroViaje.BuscarCedula(txtbuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.datalistado.DataSource = LSeguroViaje.BuscarNombre(txtbuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarPasaporte()
        {
            this.datalistado.DataSource = LSeguroViaje.BuscarPasaporte(txtbuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }
        private void BuscarFecha()
        {
            this.datalistado.DataSource = LSeguroViaje.BuscarFecha(dtbuscarfecha.Value);
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
            else if (cbbuscar.Text.Equals("Pasaporte"))
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
            else if (cbbuscar.Text.Equals("Pasaporte"))
            {
                this.BuscarPasaporte();
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
            this.txtidseguro.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["IdSeguroViaje"].Value);
            this.txtnombrecliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            this.txtcedulacliente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cedula"].Value);
            this.txtpasaporte.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Pasaporte"].Value);
            this.dtfechareservacion.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha de Compra"].Value);
            this.txtpago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Pago"].Value);
            this.cbtipopago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tipo Pago"].Value);
            this.txtdestino.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Destino"].Value);
            this.dtfechaida.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha de Ida"].Value);
            this.dtfecharegreso.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha de Regreso"].Value);
            this.txtcontactoemergencia.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Contacto de Emergencia"].Value);
            this.txttelefonoemergencia.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Teléfono de Emergencia"].Value);
        }
    }
}
