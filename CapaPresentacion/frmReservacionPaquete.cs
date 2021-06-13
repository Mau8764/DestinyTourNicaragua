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
    public partial class frmReservacionPaquete : Form
    {
        public string Acceso = "";
        //bool para reservaciones
        private bool IsNuevo = false;
        private bool IsEditar = false;


        private static frmReservacionPaquete _Instancia;


        public static frmReservacionPaquete GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmReservacionPaquete();
            }
            return _Instancia;
        }

        public void obtenerpaquete(string idpaquete, string nombrepaquete, DateTime fechapaquete,string precio)
        {
            this.txtidpaquetenacional.Text = idpaquete;
            this.txtnombrepaquete.Text = nombrepaquete;
            this.dtfechapaquete.Value = fechapaquete;
            this.txtprecio.Text = precio;
        }
        public void obtenerCliente(string cedulacliente, string nombrecliente)
        {
            this.txtcedulaclientereservacion.Text = cedulacliente;
            this.txtnombreclientereservacion.Text = nombrecliente;
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
        public frmReservacionPaquete()
        {
            InitializeComponent();
            //Textbox de la pestaña reservacion
            this.ttMensaje.SetToolTip(this.btnbuscarpaquete, "Presione para buscar el paquete para realizar la reservación");
            this.ttMensaje.SetToolTip(this.txtpagoreservacion, "Ingrese la cantidad que cliente pagó");
            this.ttMensaje.SetToolTip(this.btnbuscarcliente, "Haga clic para buscar un cliente");
            this.ttMensaje.SetToolTip(this.txtpendiente, "Ingrese el pago pendiente del cliente");

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
            this.txtidreservacion.Text = string.Empty;
            this.txtidformapago.Text = string.Empty;
            this.txtnombreclientereservacion.Text = string.Empty;
            this.txtcedulaclientereservacion.Text = string.Empty;
            this.txtpagoreservacion.Text = string.Empty;
            this.txtpendiente.Text = string.Empty;
          

        }
        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            //textbox
            this.txtpagoreservacion.ReadOnly = !valor;
            this.txtpendiente.ReadOnly = !valor;
            

            //otros controles
            this.cbtipopagoreservacion.Enabled = valor;
            this.dtfechareservacion.Enabled = valor;
            

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
            this.datalistado.Columns[7].Width = 130;
            this.datalistado.Columns[9].Width = 130;
            
        }

        private void Mostrar()
        {
            this.datalistado.DataSource = LReservacion.MostrarReservacionesPaqueteNacional();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        private void frmReservacionPaquete_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void frmReservacionPaquete_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;

        }

        private void btneliminarreservacion_Click(object sender, EventArgs e)
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
                                Rpta = LPaqueteNacional.Eliminar(idreservacion);
                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se anuló correctamente la reservación del Paquete Nacional");
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

        private void datalistadoreservacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";



                if (txtcedulaclientereservacion.Text == string.Empty || txtpagoreservacion.Text == string.Empty
                    || txtpendiente.Text == string.Empty || txtidpaquetenacional.Text == string.Empty )
                {
                    MensajeError("Falta ingresar los datos requeridos");

                    erroricono.SetError(btnbuscarcliente, "Presione el botón con el ícono de la lupa para buscar un cliente y realizar la reservación");
                    erroricono.SetError(txtpagoreservacion, "Ingrese el pago del cliente");
                    erroricono.SetError(txtpendiente, "Ingrese el pago pendiente");
                    erroricono.SetError(btnbuscarpaquete, "Presione el botón de la lupa para buscar un Paquete Nacional y realizar la reservación");
                    
                }
                else
                {
                    if (IsNuevo)
                    {
                        Rpta = LReservacion.InsertarPendiente(Convert.ToInt32(ObtenerMaxIdReservacion()) + 1, dtfechareservacion.Value, Convert.ToDecimal(txtpagoreservacion.Text),
                            Convert.ToDecimal(txtpendiente.Text), Convert.ToString(txtcedulaclientereservacion.Text));
                        LServicioDeReservacion.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), dtfechareservacion.Value, Convert.ToInt32(this.txtidpaquetenacional.Text));
                        //insercion en las demas tablas relacionadas a reservacion
                        LFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdFormaPago()) + 1, cbtipopagoreservacion.Text);
                        LReservacionFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), Convert.ToInt32(ObtenerMaxIdFormaPago()));


                    }
                    else if (IsEditar)
                    {
                        Rpta = LReservacion.EditarPendiente(Convert.ToInt32(txtidreservacion.Text), dtfechareservacion.Value, Convert.ToDecimal(txtpagoreservacion.Text),
                            Convert.ToDecimal((txtpendiente.Text)),
                           Convert.ToString(txtcedulaclientereservacion.Text));
                        LFormaPago.Editar(Convert.ToInt32(txtidformapago.Text), cbtipopagoreservacion.Text);


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
            if (!this.txtidpaquetenacional.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.txtpagoreservacion.Focus();

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

        private void datalistadoreservacion_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            frmVistaClientePersona form = new frmVistaClientePersona();
            form.Servicio = "ReservacionPaquete";
            form.ShowDialog();
        }

        private void btnbuscarpaquete_Click(object sender, EventArgs e)
        {
            frmVistaPaqueteNacional form = new frmVistaPaqueteNacional();
            form.ShowDialog();
        }

        private void btnfacturareservacion_Click(object sender, EventArgs e)
        {
         
            if (Acceso.Equals("Administrador"))
            {
                frmFacturaReservacionPaquete frm = new frmFacturaReservacionPaquete();
                frm.IdReservacion = Convert.ToInt32(this.datalistado.CurrentRow.Cells["Id_reservacion"].Value);
                frm.ShowDialog();
            }
            else
            {
                MensajeError("Usted no tiene permiso de Administrador");
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

        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtidreservacion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Id_reservacion"].Value);
            this.txtidformapago.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Id_FormaPago"].Value);
            this.txtidpaquetenacional.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["IdPaqueteNacional"].Value);
            this.txtnombrepaquete.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Paquete"].Value);
            this.dtfechapaquete.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha del Paquete"].Value);
            this.txtcedulaclientereservacion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cedula"].Value);
            this.txtnombreclientereservacion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            this.txtpagoreservacion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Pago"].Value);
            this.txtpendiente.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Pendiente"].Value);
            this.cbtipopagoreservacion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tipo Pago"].Value);
            this.dtfechareservacion.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha Reservacion"].Value);
        }
    }
}
