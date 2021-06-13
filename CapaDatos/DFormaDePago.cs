using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class DFormaDePago
    {
        private int _IdFormaPago;
        private string _TipoPago;


        public int IdFormaPago
        {
            get
            {
                return _IdFormaPago;
            }

            set
            {
                _IdFormaPago = value;
            }
        }

        public string TipoPago
        {
            get
            {
                return _TipoPago;
            }

            set
            {
                _TipoPago = value;
            }
        }



        public DFormaDePago()
        {

        }

        public DFormaDePago(int idformapago,string tipopago)
        {
            this.IdFormaPago = idformapago;
            this.TipoPago = tipopago;
        }


        //Insertar
        public string Insertar(DFormaDePago FormaPago)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo para insertar
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establece codigo para ejecutar el procedimiento
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_InsertarFormaPago";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parámetros al comando
                //Establecemos los valores para el parámetro
                //@acompañante del Procedimiento Almacenado
                SqlParameter ParIdFormaPago = new SqlParameter();
                ParIdFormaPago.ParameterName = "@idformapago";
                ParIdFormaPago.SqlDbType = SqlDbType.Int;
                ParIdFormaPago.Value = FormaPago.IdFormaPago;
                SqlCmd.Parameters.Add(ParIdFormaPago);
                //Agregamos el parámetro al comando


                SqlParameter ParTipoPago = new SqlParameter();
                ParTipoPago.ParameterName = "@Tipopago";
                ParTipoPago.SqlDbType = SqlDbType.VarChar;
                ParTipoPago.Value = FormaPago.TipoPago;
                SqlCmd.Parameters.Add(ParTipoPago);

            

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Tipo pago";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        public string Editar(DFormaDePago FormaPago)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo para editar
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establece codigo para ejecutar el procedimiento
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "[SP_EditarFormaPago]";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdFormaPago = new SqlParameter();
                ParIdFormaPago.ParameterName = "@idformapago";
                ParIdFormaPago.SqlDbType = SqlDbType.Int;
                ParIdFormaPago.Value = FormaPago.IdFormaPago;
                SqlCmd.Parameters.Add(ParIdFormaPago);
                //Agregamos el parámetro al comando


                SqlParameter ParTipoPago = new SqlParameter();
                ParTipoPago.ParameterName = "@Tipopago";
                ParTipoPago.SqlDbType = SqlDbType.VarChar;
                ParTipoPago.Value = FormaPago.TipoPago;
                SqlCmd.Parameters.Add(ParTipoPago);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo la forma de pago";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string Eliminar(DFormaDePago FormaPago)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo para editar
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establece codigo para ejecutar el procedimiento
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "[SP_EliminarFormaPago]";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdFormaPago = new SqlParameter();
                ParIdFormaPago.ParameterName = "@idformapago";
                ParIdFormaPago.SqlDbType = SqlDbType.Int;
                ParIdFormaPago.Value = FormaPago.IdFormaPago;
                SqlCmd.Parameters.Add(ParIdFormaPago);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino la forma de pago";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
    }
}
