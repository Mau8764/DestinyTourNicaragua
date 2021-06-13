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
    public partial class frmPaqueteNacional : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
  

        public frmPaqueteNacional()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtnombrepaquete, "Ingrese el Nombre del Paquete Nacional");
            this.ttMensaje.SetToolTip(this.dthorasalida, "Seleccione la Hora de Salida");
            this.ttMensaje.SetToolTip(this.txtdestino, "Ingreso el Destino");
            this.ttMensaje.SetToolTip(this.txtprecio, "Ingrese el precio del Paquete");
            this.ttMensaje.SetToolTip(this.dtfecha, "Seleccione la fecha del Paquete");
            this.ttMensaje.SetToolTip(this.txtcantidaddias, "Ingrese la Cantidad de Días");
            this.ttMensaje.SetToolTip(this.txtcantidadnoches, "Ingrese la Cantidad de Noches");
            this.ttMensaje.SetToolTip(this.txtdescripcion, "Ingrese la descripción del Paquete");
        }

        //Mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Destiny Tour Nicaragua", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpiar()
        {
            this.txtidpaquetenacional.Text = string.Empty;
            this.txtnombrepaquete.Text = string.Empty;
            this.txtdestino.Text = string.Empty;
            this.txtprecio.Text = string.Empty;
            this.txtcantidaddias.Text = string.Empty;
            this.txtcantidadnoches.Text = string.Empty;
            this.txtdescripcion.Text = string.Empty;
            

        }
        //Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Destiny Tour Nicaragua", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            //textbox
            this.txtnombrepaquete.ReadOnly = !valor;
            this.txtdestino.ReadOnly = !valor;
            this.txtprecio.ReadOnly = !valor;
            this.txtcantidaddias.ReadOnly = !valor;
            this.txtcantidadnoches.ReadOnly = !valor;
            this.txtdescripcion.ReadOnly = !valor;

            //otros controles
            this.dthorasalida.Enabled = valor;
            this.dtfecha.Enabled = valor;
            
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
        private void frmPaqueteNacional_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkanular.Checked == true)
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("Realmente desea anular el Paquete Nacional", "Destiny Tour Nicaragua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (opcion == DialogResult.OK)
                    {
                        int idpaquetenacional;
                        string Rpta = "";

                        foreach (DataGridViewRow row in datalistado.Rows)
                        {
                            if ((Convert.ToBoolean(row.Cells[0].Value)))
                            {
                                idpaquetenacional = Convert.ToInt32(row.Cells[1].Value);
                                Rpta = LPaqueteNacional.Eliminar(idpaquetenacional);
                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se anuló correctamente el Paquete Nacional");
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
            
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            txtnombrepaquete.Focus();
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtnombrepaquete.Text == string.Empty || txtdestino.Text== string.Empty || txtprecio.Text == string.Empty || txtcantidaddias.Text == string.Empty
                    || txtcantidadnoches.Text == string.Empty || txtdescripcion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar los datos requeridos");

                    erroricono.SetError(txtnombrepaquete, "Ingrese un nombre");
                    erroricono.SetError(txtdestino, "Ingrese el Destino");
                    erroricono.SetError(txtprecio, "Ingrese el precio del Paquete Nacional");
                    erroricono.SetError(txtcantidaddias, "Ingrese la Cantidad de Días");
                    erroricono.SetError(txtcantidadnoches, "Ingrese la Cantida de Noches");
                    erroricono.SetError(txtdescripcion, "Ingrese la Descripción del Paquete Nacional");
                }
                else
                {
                    if (IsNuevo)
                    {
                        Rpta = LPaqueteNacional.Insertar(Convert.ToInt32(ObtenerMaxIdTipoServicio()) + 1, txtnombrepaquete.Text.ToUpper().Trim(), dthorasalida.Text,
                             txtdestino.Text.ToUpper().Trim(),Convert.ToDecimal( txtprecio.Text),Convert.ToInt32(txtcantidaddias.Text),Convert.ToInt32(txtcantidadnoches.Text),
                             txtdescripcion.Text,dtfecha.Value);


                    }
                    else
                    {
                        Rpta = LPaqueteNacional.Editar(Convert.ToInt32(txtidpaquetenacional.Text), txtnombrepaquete.Text.ToUpper().Trim(), dthorasalida.Text,
                             txtdestino.Text.ToUpper().Trim(), Convert.ToDecimal(txtprecio.Text), Convert.ToInt32(txtcantidaddias.Text), Convert.ToInt32(txtcantidadnoches.Text),
                             txtdescripcion.Text.ToUpper().Trim(), dtfecha.Value);


                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Paquete Nacional registrado con éxito");
                        }
                        else
                        {
                            this.MensajeOk("Se actualizó el Paquete Nacional de manera correcta");
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
                this.txtnombrepaquete.Focus();

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
            this.txtidpaquetenacional.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["IdPaqueteNacional"].Value);
            this.txtnombrepaquete.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            this.dtfecha.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha"].Value);
            this.dthorasalida.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Hora de Salida"].Value);
            this.txtdestino.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Destino"].Value);
            this.txtprecio.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Precio"].Value);
            this.txtcantidaddias.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cantidad de Días"].Value);
            this.txtcantidadnoches.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cantidad de Noches"].Value);
            this.txtdescripcion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Descripcion"].Value);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
            this.txtidpaquetenacional.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["IdPaqueteNacional"].Value);
            this.txtnombrepaquete.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            this.dtfecha.Value = Convert.ToDateTime(this.datalistado.CurrentRow.Cells["Fecha"].Value);
            this.dthorasalida.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Hora de Salida"].Value);
            this.txtdestino.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Destino"].Value);
            this.txtprecio.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Precio"].Value);
            this.txtcantidaddias.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cantidad de Días"].Value);
            this.txtcantidadnoches.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cantidad de Noches"].Value);
            this.txtdescripcion.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Descripcion"].Value);

        }
    }
}
