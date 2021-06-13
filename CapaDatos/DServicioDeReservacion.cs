using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DServicioDeReservacion
    {
        private int _IdReservacion;
        private DateTime _FechaServicio;
        private int _IdServicio;

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

        public DateTime FechaServicio
        {
            get
            {
                return _FechaServicio;
            }

            set
            {
                _FechaServicio = value;
            }
        }

        public int IdServicio
        {
            get
            {
                return _IdServicio;
            }

            set
            {
                _IdServicio = value;
            }
        }

        //Constructores primero el vacio y luego con parametros
        public DServicioDeReservacion()
        {

        }

        //Con Parametros
        public DServicioDeReservacion(int idreservacion, DateTime fechaservicio,int idservicio)
        {
            this.IdReservacion = idreservacion;
            this.FechaServicio = fechaservicio;
            this.IdReservacion = idservicio;
        }


        //Metodos

        //Insertar
        public string Insertar(DServicioDeReservacion ServicioReservacion)
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
                SqlCmd.CommandText = "SP_Insertar_ServicioDeReservacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;




                SqlParameter ParIdReservacion = new SqlParameter();
                ParIdReservacion.ParameterName = "@idreservacion";
                ParIdReservacion.SqlDbType = SqlDbType.Int;
                ParIdReservacion.Value = ServicioReservacion.IdReservacion;
                SqlCmd.Parameters.Add(ParIdReservacion);

                SqlParameter ParFechaReservacion = new SqlParameter();
                ParFechaReservacion.ParameterName = "@fechadeservicio";
                ParFechaReservacion.SqlDbType = SqlDbType.Date;
                ParFechaReservacion.Value = ServicioReservacion.FechaServicio;
                SqlCmd.Parameters.Add(ParFechaReservacion);


                SqlParameter ParIdServicio = new SqlParameter();
                ParIdServicio.ParameterName = "@idservicio";
                ParIdServicio.SqlDbType = SqlDbType.Int;
                ParIdServicio.Value = ServicioReservacion.IdServicio;
                SqlCmd.Parameters.Add(ParIdServicio);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el dato";

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
