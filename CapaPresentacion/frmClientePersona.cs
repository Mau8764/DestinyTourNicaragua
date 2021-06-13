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
    public partial class frmClientePersona : Form
    {

            private bool IsNuevo = false;
            private bool IsEditar = false;
        public frmClientePersona()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre del cliente");
            this.ttMensaje.SetToolTip(this.txtcedula, "Ingrese cédula del cliente");
            this.ttMensaje.SetToolTip(this.txtedad, "Ingrese la edad del cliente");
            this.ttMensaje.SetToolTip(this.cbsexo, "Seleccione el sexo del cliente");
            
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
            this.txtcedula.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtedad.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtcorreo.Text = string.Empty;
        }

        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtcedula.ReadOnly = !valor;
            this.cbsexo.Enabled = valor;
            this.txtedad.ReadOnly = !valor;
            this.txttelefono.ReadOnly = !valor;
            this.txtcorreo.ReadOnly = !valor;

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea eliminar los registros", "Destiny Tour Nicaragua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    string cedula;
                    string Rpta = "";

                    foreach (DataGridViewRow row in datalistado.Rows)
                    {
                        if ((Convert.ToBoolean(row.Cells[0].Value)))
                        {
                            cedula = Convert.ToString(row.Cells[1].Value);
                            Rpta = LClientePersona.Eliminar(cedula);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó correctamente el cliente");
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
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmClientePersona_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void Mostrar_acompañante_cliente()
        {

        }
       
        private void dataListado_DoubleClick_1(object sender, EventArgs e)
        {
            
        }

     

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtcedula.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                string Rpta2 = "";
                if (this.txtcedula.Text == string.Empty || txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar los datos requeridos");
                    erroricono.SetError(txtcedula, "Ingrese la cedula");
                    erroricono.SetError(txtNombre, "Ingrese un nombre");

                }
                else
                {
                    if (IsNuevo)
                    {
                        Rpta = LClientePersona.Insertar(this.txtcedula.Text.Trim().ToUpper(),
                            this.txtcorreo.Text.Trim(), this.txtNombre.Text.Trim().ToUpper(), this.cbsexo.Text,
                            Convert.ToInt32(this.txtedad.Text), Convert.ToInt32(this.txttelefono.Text));
                    }
                    else
                    {
                        Rpta = LClientePersona.EditarCliente(this.txtcedula.Text.Trim().ToUpper(),
                            this.txtcorreo.Text.Trim());
                        Rpta2 = LClientePersona.EditarPersona(this.txtcedula.Text.Trim().ToUpper(),
                            this.txtNombre.Text.Trim().ToUpper(), this.cbsexo.Text,
                           Convert.ToInt32(this.txtedad.Text), Convert.ToInt32(this.txttelefono.Text));

                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Cliente registrado con éxito");
                        }
                        else
                        {
                            this.MensajeOk("Se actualizó el cliente de manera correcta");
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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (!this.txtcedula.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.txtcedula.Focus();

            }
            else
            {
                this.MensajeError("Debe seleccionar primero el registro que desea modificar");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtcedula.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Cedula"].Value);
            this.txtNombre.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Nombre"].Value);
            this.cbsexo.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Sexo"].Value);
            this.txtedad.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Edad"].Value);
            this.txttelefono.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Telefono"].Value);
            this.txtcorreo.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["Correo_Electronico"].Value);
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
    }
    }

