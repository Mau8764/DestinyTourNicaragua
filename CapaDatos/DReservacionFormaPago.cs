using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DReservacionFormaPago
    {
        private int _IdReservacion;
        private int _IdFormaPago;

        public int IdReservacion
        {
            get
            {
                return _IdReservacion;
            }

            set
            {
                _IdReservacion = value;
            }
        }

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

        //Constructores primero el vacio y luego con parametros
        public DReservacionFormaPago()
        {

        }

        //Con Parametros
        public DReservacionFormaPago(int idreservacion, int idformapago)
        {
            this.IdReservacion = idformapago;
            this.IdFormaPago = idformapago;
        }


        //Metodos

        //Insertar
        public string Insertar(DReservacionFormaPago ReservacionFormaPago)
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
                SqlCmd.CommandText = "SP_Insertar_ReservacionFormaPago";
                SqlCmd.CommandType = CommandType.StoredProcedure;




                SqlParameter ParIdReservacion = new SqlParameter();
                ParIdReservacion.ParameterName = "@idreservacion";
                ParIdReservacion.SqlDbType = SqlDbType.Int;
                ParIdReservacion.Value = ReservacionFormaPago.IdReservacion;
                SqlCmd.Parameters.Add(ParIdReservacion);

                SqlParameter ParIdFormaPago = new SqlParameter();
                ParIdFormaPago.ParameterName = "@idformapago";
                ParIdFormaPago.SqlDbType = SqlDbType.Int;
                ParIdFormaPago.Value = ReservacionFormaPago.IdFormaPago;
                SqlCmd.Parameters.Add(ParIdFormaPago);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso la Forma de Pago";

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
