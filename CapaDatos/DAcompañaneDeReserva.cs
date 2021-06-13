using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DAcompañaneDeReserva
    {
        private int _IdReservacion;
        private int _IdAcompañante;

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

        public int IdAcompañante
        {
            get
            {
                return _IdAcompañante;
            }

            set
            {
                _IdAcompañante = value;
            }
        }


        //Constructores primero el vacio y luego con parametros
        public DAcompañaneDeReserva()
        {

        }

        //Con Parametros
        public DAcompañaneDeReserva(int idreservacion, int idacompañante)
        {
            this.IdReservacion = idreservacion;
            this.IdAcompañante = idacompañante;
        }


        //Metodos

        //Insertar
        public string Insertar(DAcompañaneDeReserva AcompañanteDeReserva)
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
                SqlCmd.CommandText = "SP_Insertar_AcompañanteDeReserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;




                SqlParameter ParIdReservacion = new SqlParameter();
                ParIdReservacion.ParameterName = "@idreservacion";
                ParIdReservacion.SqlDbType = SqlDbType.Int;
                ParIdReservacion.Value = AcompañanteDeReserva.IdReservacion;
                SqlCmd.Parameters.Add(ParIdReservacion);

                SqlParameter ParIdAcompañante = new SqlParameter();
                ParIdAcompañante.ParameterName = "@idacompañante";
                ParIdAcompañante.SqlDbType = SqlDbType.Int;
                ParIdAcompañante.Value = AcompañanteDeReserva.IdAcompañante;
                SqlCmd.Parameters.Add(ParIdAcompañante);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el acompañante";

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
