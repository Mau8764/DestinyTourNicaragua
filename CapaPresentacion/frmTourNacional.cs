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
    public partial class frmTourNacional : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;


        public frmTourNacional()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtnombretour, "Ingrese el nombre del tour");
            this.ttMensaje.SetToolTip(this.dtfechatour, "Ingrese la fecha en que se va a realizar el Tour");
            this.ttMensaje.SetToolTip(this.dthorasalida, "Ingrese la hora de salida del Tour");
            this.ttMensaje.SetToolTip(this.dthoraregreso, "Ingrese la hora de regreso del Tour");
           
        }

        /*AQUI METER EL CODIGO PARA CAPTURAR EL ID ULTIMO*/


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
            this.txtidtour.Text = string.Empty;
            this.txtnombretour.Text = string.Empty;
            this.txtnombreinstitucion.Text = string.Empty;
        }


        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtidtour.ReadOnly = !valor;
            this.txtnombretour.ReadOnly = !valor;
            this.txtnombreinstitucion.ReadOnly = !valor;
            this.dtfechatour.Enabled = valor;
            this.dthorasalida.Enabled = valor;
            this.dthoraregreso.Enabled = valor;
            this.cbtipotour.Enabled = valor;

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
            this.datalistado.DataSource = LTourNacional.BuscarTour_Fecha(this.dtbuscarfecha.Value);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datalistado.Rows.Count);
        }



        private void frmTourNacional_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkEliminar.Checked == true)
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Realmente desea eliminar los registros", "Destiny Tour Nicaragua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        int idtour;
                        string Rpta = "";

                        foreach (DataGridViewRow row in datalistado.Rows)
                        {
                            if ((Convert.ToBoolean(row.Cells[0].Value)))
                            {
                                idtour = Convert.ToInt32(row.Cells[1].Value);
                                Rpta = LTourNacional.Eliminar(idtour);
                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se eliminó correctamente el Tour");
                                }
                                else
                                {
                                    this.MensajeError(Rpta);
                                }
                            }
                        }
                        this.Mostrar();

                    }
                }else
                {
                    this.MensajeError("Debe seleccionar una fila para poder eliminarla");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
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
            this.txtnombretour.Focus();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtnombretour.Text == string.Empty)
                {
                    MensajeError("Falta ingresar los datos requeridos");
                   
                    erroricono.SetError(txtnombretour, "Ingrese un nombre");

                }
                else
                {
                    if (IsNuevo)
                    {
                       Rpta = LTourNacional.Insertar(Convert.ToInt32(ObtenerMaxIdTipoServicio())+1,dthorasalida.Value.ToString("HH:mm"), dthoraregreso.Value.ToString("HH:mm"),
                            this.dtfechatour.Value,this.txtnombretour.Text.Trim().ToUpper(),
                            this.cbtipotour.Text,this.txtnombreinstitucion.Text.Trim().ToUpper());


                    }
                    else
                    {
                        Rpta = LTourNacional.Editar(Convert.ToInt32(this.txtidtour.Text), dthorasalida.Value.ToString("HH:mm"), dthoraregreso.Value.ToString("HH:mm"),
                            this.dtfechatour.Value, this.txtnombretour.Text.Trim().ToUpper(),
                            this.cbtipotour.Text, this.txtnombreinstitucion.Text.Trim().ToUpper());
                        

                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Tour registrado con éxito");
                            this.tabControl1.SelectedIndex = 0;
                        }
                        else
                        {
                            this.MensajeOk("Se actualizó el tour de manera correcta");
                            this.tabControl1.SelectedIndex = 0;
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

 //                   LTipoServicio.Insertar("Tour Nacional",0, 0, 0, 0,Convert.ToInt32( this.dataListado.CurrentRow.Cells["IdTour"].Value), 0,0);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtidtour.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.txtnombretour.Focus();

            }
            else
            {
                this.MensajeError("Debe seleccionar primero el registro que desea modificar");
            }
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
    

            this.tabControl1.SelectedIndex = 1;
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

            if (txtBuscar.Text==string.Empty)
            {
                Mostrar();
            } 

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dthoraregreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dthorasalida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
             ListadoDeClientesPorTour frm = new ListadoDeClientesPorTour();
            frm.IdTour = Convert.ToInt32(this.datalistado.CurrentRow.Cells["IdTour"].Value);
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            this.txtidtour.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["IdTour"].Value);
            this.txtnombretour.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["NombreTour"].Value);
            this.dtfechatour.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha_Tour"].Value);
            this.dthorasalida.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Hora_Salida"].Value);
            this.dthoraregreso.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Hora_Regreso"].Value);
            this.txtnombreinstitucion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre_Institucion"].Value);
            this.cbtipotour.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Tipo_Tour"].Value);
        }
    }
    }

