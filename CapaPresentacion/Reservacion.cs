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
    public partial class Reservacion : Form
    {

        public string Acceso = "";
        //bool para reservaciones
        private bool IsNuevoReservacion = false;
        private bool IsEditarReservacion = false;

        private bool IsNuevoAcompañante = false;
        private bool IsEditarAcompañante = false;

        private static Reservacion _Instancia;
        
        public static Reservacion GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Reservacion();
            }
            return _Instancia;
        }

        public void obtenerTour(string idtour,string nombretour,string fechatour)
        {
            this.txtidtour.Text = idtour;
            this.txtnombretour.Text = nombretour;
            this.txtfechatour.Text = fechatour;
        }
        public void obtenerCliente(string cedulacliente,string nombrecliente)
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
        private static string ObtenerMaxIdAcompañante()
        {
            using (SqlConnection cn = new SqlConnection("Data Source=(local); Initial Catalog=Destiny; Integrated Security=true"))
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select MAX(id_acompañante) From Acompañante", cn);
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

        public Reservacion()
        {
            InitializeComponent();
       


            //Textbox de la pestaña reservacion
            this.ttMensaje.SetToolTip(this.btnbuscartour, "Presione para buscar el tour para realizar la reservación");
            this.ttMensaje.SetToolTip(this.txtpagoreservacion, "Ingrese la cantidad que cliente pagó");
            this.ttMensaje.SetToolTip(this.btnbuscarcliente,"Haga clic para buscar un cliente");
            this.ttMensaje.SetToolTip(this.btnbuscartour, "Haga clic para buscar el tour a reservar");
            this.ttMensaje.SetToolTip(this.btnpestañaacompañante,"Haga clic para agregar acompañantes");
            this.ttMensaje.SetToolTip(this.txtpendiente, "Ingrese el pago Pendiente");
        }

        private void Reservacion_Load(object sender, EventArgs e)
        {
           
            this.MostrarReservacion();
            this.HabilitarReservacion(false);
            this.MostrarAcompañante();
          
                }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            
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
       
        private void LimpiarReservacion()
        {
            this.txtidreservacion.Text = string.Empty;
            this.txtpagoreservacion.Text = string.Empty;
            this.txtidtour.Text = string.Empty;
            this.txtnombretour.Text = string.Empty;
            this.txtfechatour.Text = string.Empty;
            this.txtpendiente.Text = string.Empty;
        }
        //metodo para limpiar los controles de acompañante

        private void LimpiarAcompañante()
        {
            this.txtcedulaacompañante.Text = string.Empty;
            this.txtnombreacompañante.Text = string.Empty;
            this.txtidacompañante.Text = string.Empty;
           
        }
        //Metodo para habilitar los controles del formulario

        private void HabilitarReservacion(bool valor)
        {
            this.txtcedulaclientereservacion.ReadOnly = !valor;
            this.txtpagoreservacion.ReadOnly = !valor;
            this.cbtipopagoreservacion.Enabled = valor;
            this.dtfechareservacion.Enabled = valor;
            this.btnbuscarcliente.Enabled = valor;
            this.btnbuscartour.Enabled = valor;
        }

        private void HabilitarAcompañante(bool valor)
        {
            this.txtcedulaacompañante.ReadOnly = !valor;
            this.txtnombreacompañante.ReadOnly = !valor;
          
        }

        //metodo para hablilitar los botones del formulario


        private void BotonesReservacion()
        {
            if (this.IsNuevoReservacion || this.IsEditarReservacion)
            {
                this.HabilitarReservacion(true);
                this.btnnuevoreservacion.Enabled = false;
                this.btnguardarreservacion.Enabled = true;
                this.btneditarreservacion.Enabled = false;
                this.btncancelarreservacion.Enabled = true;
            }
            else
            {
                this.HabilitarReservacion(false);
                this.btnnuevoreservacion.Enabled = true;
                this.btnguardarreservacion.Enabled = false;
                this.btneditarreservacion.Enabled = true;
                this.btncancelarreservacion.Enabled = false;
            }
        }

        private void BotonesAcompañante()
        {
            if (this.IsNuevoAcompañante || this.IsEditarAcompañante)
            {
                this.HabilitarAcompañante(true);
                this.btnnuevoacompañante.Enabled = false;
                this.btnguardaracompañante.Enabled = true;
                this.btneditaracompañante.Enabled = false;
                this.btncancelaracompañante.Enabled = true;
            }
            else
            {
                this.HabilitarAcompañante(false);
                this.btnnuevoacompañante.Enabled = true;
                this.btnguardaracompañante.Enabled = false;
                this.btneditaracompañante.Enabled = true;
                this.btncancelaracompañante.Enabled = false;
            }
        }

        //Metodo para ocultar columnas


        private void OcultarColumnasReservacion()
        {
            this.datalistadoreservacion.Columns[0].Visible = false;
            this.datalistadoreservacion.Columns[1].Visible = false;
            this.datalistadoreservacion.Columns[2].Visible = false;
            this.datalistadoreservacion.Columns[3].Visible = false;

        }
        private void OcultarColumnasAcompañante()
        {
            this.datalistadoacompañante.Columns[0].Visible = false;
            this.datalistadoacompañante.Columns[1].Visible = false;
            this.datalistadoacompañante.Columns[2].Visible = false;

        }


        //Metodo para mostrar todos los servicios

        private void MostrarReservacion()
        {
            this.datalistadoreservacion.DataSource = LReservacion.MostrarReservaciones();
            this.OcultarColumnasReservacion();
            this.datalistadoreservacion.Columns[4].Width = 150;
            lbltotalreservaciones.Text = "Total de registros: " + Convert.ToString(datalistadoreservacion.Rows.Count);
        }

        private void MostrarAcompañante()
        {
            this.datalistadoacompañante.DataSource = LAcompañante.Mostrar();
            this.OcultarColumnasAcompañante();
            this.datalistadoacompañante.Columns[3].Width = 130;
            this.datalistadoacompañante.Columns[4].Width = 130;
            this.datalistadoacompañante.Columns[5].Width = 130;
            this.datalistadoacompañante.Columns[6].Width = 130;
            lbltotalacompañante.Text = "Total de registros: " + Convert.ToString(datalistadoacompañante.Rows.Count);
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscartour_Click(object sender, EventArgs e)
        {
            frmVistaTourNacional form = new frmVistaTourNacional();
            form.Consulta = "Reservacion";
            form.ShowDialog();
        }

        private void btnnuevoreservacion_Click(object sender, EventArgs e)
        {
            
        }

       




        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnguardarreservacion_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
               


                if (txtcedulaclientereservacion.Text == string.Empty || txtpagoreservacion.Text==string.Empty|| txtpendiente.Text==string.Empty || txtnombretour.Text==string.Empty)
                {
                    MensajeError("Falta ingresar los datos requeridos");

                    erroricono.SetError(txtnombretour, "Presione el botón con el ícono de la lupa para buscar un tour y asignar la reservación");
                    erroricono.SetError(txtcedulaclientereservacion, "Debe seleccionar un cliente para ingresar una reservación");
                    erroricono.SetError(txtpagoreservacion, "Debe ingresar la cantidad pagada por el cliente");
                    erroricono.SetError(txtpendiente, "Debe ingresar la cantidad pendiente por el cliente");
                }
                else
                {
                    if (IsNuevoReservacion)
                    {
                        Rpta = LReservacion.InsertarPendiente(Convert.ToInt32(ObtenerMaxIdReservacion())+1,dtfechareservacion.Value,Convert.ToDecimal(txtpagoreservacion.Text),
                            Convert.ToDecimal(txtpendiente.Text),Convert.ToString(txtcedulaclientereservacion.Text));
                        LServicioDeReservacion.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()),dtfechareservacion.Value,Convert.ToInt32(this.txtidtour.Text));
                        //insercion en las demas tablas relacionadas a reservacion
                        LFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdFormaPago())+1,cbtipopagoreservacion.Text);
                        LReservacionFormaPago.Insertar(Convert.ToInt32(ObtenerMaxIdReservacion()), Convert.ToInt32(ObtenerMaxIdFormaPago()));



                    }
                    else if (IsEditarReservacion)
                    {
                        Rpta = LReservacion.EditarPendiente(Convert.ToInt32(txtidreservacion.Text), dtfechareservacion.Value, Convert.ToDecimal(txtpagoreservacion.Text),
                            Convert.ToDecimal(txtpendiente.Text),Convert.ToString(txtcedulaclientereservacion.Text));
                        LFormaPago.Editar(Convert.ToInt32(txtidformapago.Text), cbtipopagoreservacion.Text);


                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevoReservacion)
                        {
                            this.MensajeOk("Reservación registrada con éxito");
                            
                        }
                        else if (this.IsEditarReservacion)
                        {
                            this.MensajeOk("Se actualizó la reservación de manera correcta");
                            
                        }
                    }
                    else
                    {
                        this.MensajeError(Rpta);

                    }
                    this.IsNuevoReservacion = false;
                    this.IsEditarReservacion = false;
                    this.BotonesReservacion();
                    this.LimpiarReservacion();
                    this.MostrarReservacion();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkeliminarreservacion_CheckedChanged(object sender, EventArgs e)
        { }
           


      
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (chkanular.Checked == false)
            {
                MessageBox.Show("Debe seleccionar al menos una reservacion para poder anular", "Destiny Tour Nicaragua", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Realmente desea anular la reservación?", "Destiny Tour Nicaragua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        int idreservacion;
                        string Rpta = "";

                        foreach (DataGridViewRow row in datalistadoreservacion.Rows)
                        {
                            if ((Convert.ToBoolean(row.Cells[0].Value)))
                            {
                                idreservacion = Convert.ToInt32(row.Cells[1].Value);
                                Rpta = LReservacion.Eliminar(idreservacion);
                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se anuló correctamente la reservacion");
                                }
                                else
                                {
                                    this.MensajeError(Rpta);
                                }
                            }
                        }
                        this.MostrarReservacion();
                        this.chkanular.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void datalistadoreservacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnnuevoreservacion_Click_1(object sender, EventArgs e)
        {
            this.IsNuevoReservacion = true;
            this.IsEditarReservacion = false;
            this.BotonesReservacion();
            this.LimpiarReservacion();
            this.HabilitarReservacion(true);
            this.txtpagoreservacion.Focus();
        }

        private void btneditarreservacion_Click(object sender, EventArgs e)
        {
            if (!this.txtcedulaclientereservacion.Text.Equals(""))
            {
                this.IsEditarReservacion = true;
                this.BotonesReservacion();
                this.HabilitarReservacion(true);
                this.txtcedulaclientereservacion.Focus();

            }
            else
            {
                this.MensajeError("Debe seleccionar primero el registro que desea modificar");
            }
        }

        private void btncancelarreservacion_Click(object sender, EventArgs e)
        {
            this.IsNuevoReservacion = false;
            this.IsEditarReservacion = false;
            this.BotonesReservacion();
            this.LimpiarReservacion();
            this.HabilitarReservacion(false);
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datalistadoreservacion_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void chkanular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkanular.Checked)
            {
                this.datalistadoreservacion.Columns[0].Visible = true;

            }
            else
            {
                this.datalistadoreservacion.Columns[0].Visible = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Reservacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frmVistaClientePersona form = new frmVistaClientePersona();
            form.Servicio = "ReservacionTour";
            form.ShowDialog();
        }

        private void txtnombrecliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            txtcedulaacompañante.Clear();
        }

        private void txtnombreacompañante_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtidreservacion.Text!=string.Empty && txtnombreclientereservacion.Text!=string.Empty && txtcedulaclientereservacion.Text!=string.Empty)
            {
                this.txtidreservacionacompañante.Text = this.txtidreservacion.Text;
                this.txtnombrecliente.Text = this.txtnombreclientereservacion.Text;
                this.txtcedulaclienteacompañante.Text = this.txtcedulaclientereservacion.Text;
                this.tabControl1.SelectedIndex = 1;
            }
            else
            {
                this.MensajeError("Debe seleccionar una reservación de un cliente para poder añadir acompañantes");
                this.MensajeError("Haga doble clic en uno de los registros para agregar acompañantes");

            }

        }

        private void btnguardaracompañante_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";



                if (txtnombreacompañante.Text == string.Empty )
                {
                    MensajeError("Falta ingresar los datos requeridos");

                    erroricono.SetError(txtnombreacompañante, "Ingrese el nombre del acompañante");
                  

                }
                else
                {
                    if (IsNuevoAcompañante)
                    {
                        Rpta = LAcompañante.Insertar(Convert.ToInt32(ObtenerMaxIdAcompañante())+1,txtnombreacompañante.Text.Trim().ToUpper(),txtcedulaacompañante.Text);

                        LAcompañanteDeReserva.Insertar(Convert.ToInt32(txtidreservacionacompañante.Text),Convert.ToInt32(ObtenerMaxIdAcompañante()));

                    }
                    else if (IsEditarAcompañante)
                    {
                        Rpta = LAcompañante.Editar(Convert.ToInt32(txtidacompañante.Text),txtnombreacompañante.Text,txtcedulaacompañante.Text);

                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevoAcompañante)
                        {
                            this.MensajeOk("Acompañante registrado con éxito");

                        }
                        else if (this.IsEditarAcompañante)
                        {
                            this.MensajeOk("Se actualizó el acompañante de manera correcta");

                        }
                    }
                    else
                    {
                        this.MensajeError(Rpta);

                    }
                    this.IsNuevoAcompañante = false;
                    this.IsEditarAcompañante = false;
                    this.BotonesAcompañante();
                    this.LimpiarAcompañante();
                    this.MostrarAcompañante();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnnuevoacompañante_Click(object sender, EventArgs e)
        {
            this.IsNuevoAcompañante = true;
            this.IsEditarAcompañante = false;
            this.BotonesAcompañante();
            this.LimpiarAcompañante();
            this.HabilitarAcompañante(true);
            this.txtnombreacompañante.Focus();
        }

        private void btneditaracompañante_Click(object sender, EventArgs e)
        {
            if (!this.txtnombreacompañante.Text.Equals(""))
            {
                this.IsEditarAcompañante = true;
                this.BotonesAcompañante();
                this.HabilitarAcompañante(true);
                this.txtnombreacompañante.Focus();

            }
            else
            {
                this.MensajeError("Debe seleccionar primero el registro que desea modificar");
            }
        }

        private void btncancelaracompañante_Click(object sender, EventArgs e)
        {
            this.IsNuevoAcompañante = false;
            this.IsEditarAcompañante = false;
            this.BotonesAcompañante();
            this.LimpiarAcompañante();
            this.HabilitarAcompañante(false);
        }

        private void datalistadoacompañante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chkeliminaracompañante.Checked == false)
            {
                MessageBox.Show("Debe seleccionar al menos un acompañante para poder eliminar", "Destiny Tour Nicaragua", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Realmente desea eliminar el acompañante?", "Destiny Tour Nicaragua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        int idacompañante;
                        string Rpta = "";

                        foreach (DataGridViewRow row in datalistadoacompañante.Rows)
                        {
                            if ((Convert.ToBoolean(row.Cells[0].Value)))
                            {
                                idacompañante = Convert.ToInt32(row.Cells[1].Value);
                                Rpta = LAcompañante.Eliminar(idacompañante);
                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se eliminó correctamente el acompañante");
                                }
                                else
                                {
                                    this.MensajeError(Rpta);
                                }
                            }
                        }
                        this.MostrarAcompañante();
                        this.chkeliminaracompañante.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void chkeliminaracompañante_CheckedChanged(object sender, EventArgs e)
        {
            if (chkeliminaracompañante.Checked)
            {
                this.datalistadoacompañante.Columns[0].Visible = true;

            }
            else
            {
                this.datalistadoacompañante.Columns[0].Visible = false;
            }
        }

        private void datalistadoacompañante_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
           // frmPrincipal consulta = frmPrincipal.GetInstancia();
            if (Acceso.Equals("Administrador"))
            {
            frmFacturaReservacionTour frm = new frmFacturaReservacionTour();
            frm.IdReservacion = Convert.ToInt32(this.datalistadoreservacion.CurrentRow.Cells["Id_reservacion"].Value);
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
            this.datalistadoreservacion.DataSource = LReservacion.BuscarCedula(txtbuscar.Text);
            this.OcultarColumnasReservacion();
            lbltotalreservaciones.Text = "Total de registros: " + Convert.ToString(datalistadoreservacion.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.datalistadoreservacion.DataSource = LReservacion.BuscarNombre(txtbuscar.Text);
            this.OcultarColumnasReservacion();
            lbltotalreservaciones.Text = "Total de registros: " + Convert.ToString(datalistadoreservacion.Rows.Count);
        }
        private void BuscarFecha()
        {
            this.datalistadoreservacion.DataSource = LReservacion.BuscarFecha(dtbuscarfecha.Value);
            this.OcultarColumnasReservacion();
            lbltotalreservaciones.Text = "Total de registros: " + Convert.ToString(datalistadoreservacion.Rows.Count);
        }
        public void ReservacionPorTour(string nombretour,DateTime fechatour)
        {
            this.datalistadoreservacion.DataSource = LReservacion.MostrarReservacionPorTour(nombretour,fechatour);
            this.OcultarColumnasReservacion();
            lbltotalreservaciones.Text = "Total de registros: " + Convert.ToString(datalistadoreservacion.Rows.Count);
        }

        //Metodos para buscar acompañante
        private void BuscarCedulaAcompañante()
        {
            this.datalistadoacompañante.DataSource = LAcompañante.BuscarCedula(txtbuscaracompañante.Text);
            this.OcultarColumnasAcompañante();
            lbltotalacompañante.Text = "Total de registros: " + Convert.ToString(datalistadoacompañante.Rows.Count);
        }
        private void BuscarNombreAcompañante()
        {
            this.datalistadoacompañante.DataSource = LAcompañante.BuscarNombre(txtbuscaracompañante.Text);
            this.OcultarColumnasAcompañante();
            lbltotalacompañante.Text = "Total de registros: " + Convert.ToString(datalistadoacompañante.Rows.Count);
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
                MostrarReservacion();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFecha();

        }

        private void cbbuscaracompañante_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtbuscaracompañante_TextChanged(object sender, EventArgs e)
        {
            if (cbbuscaracompañante.Text.Equals("Nombre"))
            {
                this.BuscarNombreAcompañante();
            }
            else if (cbbuscaracompañante.Text.Equals("Cedula"))
            {
                this.BuscarCedulaAcompañante();
            }
            else if (txtbuscar.Text == string.Empty)
            {
                MostrarAcompañante();
            }
        }

        private void txtpendiente_TextChanged(object sender, EventArgs e)
        {

        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadoreservacion.Columns["dataGridViewCheckBoxColumn1"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)datalistadoreservacion.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void datalistadoreservacion_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtidreservacion.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["Id_reservacion"].Value);
            this.txtidformapago.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["Id_FormaPago"].Value);
            this.txtidtour.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["IdTour"].Value);
            this.txtnombretour.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["NombreTour"].Value);
            this.txtfechatour.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["Fecha_Tour"].Value);
            this.txtcedulaclientereservacion.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["Cedula"].Value);
            this.txtnombreclientereservacion.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["Nombre"].Value);
            this.txtpagoreservacion.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["Pago"].Value);
            this.txtpendiente.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["Pendiente"].Value);
            this.cbtipopagoreservacion.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["Tipo_Pago"].Value);
            this.dtfechareservacion.Value = Convert.ToDateTime(this.datalistadoreservacion.CurrentRow.Cells["FechaReservacion"].Value);
            // this.txtchofercoster.Text = Convert.ToString(this.datalistadoreservacion.CurrentRow.Cells["IdChoferCoster"].Value);

            //this.tabControl1.SelectedIndex = 1;
        }

        private void datalistadoacompañante_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistadoacompañante.Columns["dataGridViewCheckBoxColumn2"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)datalistadoacompañante.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn2"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void datalistadoacompañante_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtidacompañante.Text = Convert.ToString(this.datalistadoacompañante.CurrentRow.Cells["id_acompañante"].Value);
            this.txtcedulaclienteacompañante.Text = Convert.ToString(this.datalistadoacompañante.CurrentRow.Cells["Cedula Cliente"].Value);
            this.txtnombrecliente.Text = Convert.ToString(this.datalistadoacompañante.CurrentRow.Cells["Nombre Cliente"].Value);
            this.txtnombreacompañante.Text = Convert.ToString(this.datalistadoacompañante.CurrentRow.Cells["Nombre Acompañante"].Value);
            this.txtcedulaacompañante.Text = Convert.ToString(this.datalistadoacompañante.CurrentRow.Cells["Cedula Acompañante"].Value);
            this.txtidreservacionacompañante.Text = Convert.ToString(this.datalistadoacompañante.CurrentRow.Cells["Id_reservacion"].Value);
        }

        private void btnMostrarPorTour_Click(object sender, EventArgs e)
        {
            frmVistaTourNacional frm = new frmVistaTourNacional();
            frm.Consulta = "MostrarPorTour";
            frm.ShowDialog();
            
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            MostrarReservacion();
            
        }
    }
    }
   
    

