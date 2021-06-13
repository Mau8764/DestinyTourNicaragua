using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DTipoServicio
    {
        private int _IdServicio;
        private string _NombreServicio;
        private int _IdPaqueteEuropa;
        private int _IdSeguroViaje;
        private int _IdPaqueteNacional;
        private int _IdRentaVehiculo;
        private int _IdTour;
        private int _IdServicioHotel;
        private int _IdBoleto;

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

        public string NombreServicio
        {
            get
            {
                return _NombreServicio;
            }

            set
            {
                _NombreServicio = value;
            }
        }

        public int IdPaqueteEuropa
        {
            get
            {
                return _IdPaqueteEuropa;
            }

            set
            {
                _IdPaqueteEuropa = value;
            }
        }

        public int IdSeguroViaje
        {
            get
            {
                return _IdSeguroViaje;
            }

            set
            {
                _IdSeguroViaje = value;
            }
        }

        public int IdPaqueteNacional
        {
            get
            {
                return _IdPaqueteNacional;
            }

            set
            {
                _IdPaqueteNacional = value;
            }
        }

        public int IdRentaVehiculo
        {
            get
            {
                return _IdRentaVehiculo;
            }

            set
            {
                _IdRentaVehiculo = value;
            }
        }

        public int IdTour
        {
            get
            {
                return _IdTour;
            }

            set
            {
                _IdTour = value;
            }
        }

        public int IdServicioHotel
        {
            get
            {
                return _IdServicioHotel;
            }

            set
            {
                _IdServicioHotel = value;
            }
        }

        public int IdBoleto
        {
            get
            {
                return _IdBoleto;
            }

            set
            {
                _IdBoleto = value;
            }
        }


        //Constructor vacío
        public DTipoServicio()
        {

        }

        //contructor con parametros
        public DTipoServicio(int idservicio, string nombreservicio, int idpaqueteeuropa, int idseguroviaje, int idpaquetenacional, int idrentavehiculo,
            int idtour, int idserviciohotel, int idboleto)
        {
            this.IdServicio = idservicio;
            this.NombreServicio = nombreservicio;
            this.IdPaqueteEuropa = idpaqueteeuropa;
            this.IdSeguroViaje = idseguroviaje;
            this.IdPaqueteNacional = idpaquetenacional;
            this.IdRentaVehiculo = idrentavehiculo;
            this.IdTour = idtour;
            this.IdServicioHotel = idserviciohotel;
            this.IdBoleto = idboleto;
        }

        //metodo insertar
        public string Insertar(DTipoServicio TipoServicio)
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
                SqlCmd.CommandText = "SP_InsertarTipoServicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parámetros al comando
                //Establecemos los valores para el parámetro
                //@idcategoria del Procedimiento Almacenado
                SqlParameter ParIdServicio = new SqlParameter();
                ParIdServicio.ParameterName = "@idservicio";
                ParIdServicio.SqlDbType = SqlDbType.Int;
                ParIdServicio.Value = TipoServicio.IdServicio;
                SqlCmd.Parameters.Add(ParIdServicio);
                //Agregamos el parámetro al comando


                SqlParameter ParNombreServicio = new SqlParameter();
                ParNombreServicio.ParameterName = "@nombreservicio";
                ParNombreServicio.SqlDbType = SqlDbType.NVarChar;
                ParNombreServicio.Size = 50;
                ParNombreServicio.Value = TipoServicio.NombreServicio;
                SqlCmd.Parameters.Add(ParNombreServicio);

                SqlParameter ParIdPaqueteEuropa = new SqlParameter();
                ParIdPaqueteEuropa.ParameterName = "@idpaqueteeuropa";
                ParIdPaqueteEuropa.SqlDbType = SqlDbType.Int;
                ParIdPaqueteEuropa.Value = TipoServicio.IdPaqueteEuropa;
                SqlCmd.Parameters.Add(ParIdPaqueteEuropa);

                SqlParameter ParIdSeguroViaje = new SqlParameter();
                ParIdSeguroViaje.ParameterName = "@idseguroviaje";
                ParIdSeguroViaje.SqlDbType = SqlDbType.Int;
                ParIdSeguroViaje.Value = TipoServicio.IdSeguroViaje;
                SqlCmd.Parameters.Add(ParIdSeguroViaje);

                SqlParameter ParIdPaqueteNacional = new SqlParameter();
                ParIdPaqueteNacional.ParameterName = "@idpaquetenacional";
                ParIdPaqueteNacional.SqlDbType = SqlDbType.Int;
                ParIdPaqueteNacional.Value = TipoServicio.IdPaqueteNacional;
                SqlCmd.Parameters.Add(ParIdPaqueteNacional);

                SqlParameter ParIdRentaVehiculo = new SqlParameter();
                ParIdRentaVehiculo.ParameterName = "@idrentavehiculo";
                ParIdRentaVehiculo.SqlDbType = SqlDbType.Int;
                ParIdRentaVehiculo.Value = TipoServicio.IdRentaVehiculo;
                SqlCmd.Parameters.Add(ParIdRentaVehiculo);

                SqlParameter ParIdTour = new SqlParameter();
                ParIdTour.ParameterName = "@idtour";
                ParIdTour.SqlDbType = SqlDbType.Int;
                ParIdTour.Value = TipoServicio.IdTour;
                SqlCmd.Parameters.Add(ParIdTour);

                SqlParameter ParIdServicioHotel = new SqlParameter();
                ParIdServicioHotel.ParameterName = "@idserviciohotel";
                ParIdServicioHotel.SqlDbType = SqlDbType.Int;
                ParIdServicioHotel.Value = TipoServicio.IdServicioHotel;
                SqlCmd.Parameters.Add(ParIdServicioHotel);

                SqlParameter ParIdBoleto = new SqlParameter();
                ParIdBoleto.ParameterName = "@idboleto";
                ParIdBoleto.SqlDbType = SqlDbType.Int;
                ParIdBoleto.Value = TipoServicio.IdBoleto;
                SqlCmd.Parameters.Add(ParIdBoleto);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Servicio";

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

        //metodo eliminar

        public string Eliminar(DTipoServicio TipoServicio)
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
                SqlCmd.CommandText = "SP_EliminarTipoServicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTipoServicio = new SqlParameter();
                ParIdTipoServicio.ParameterName = "@idservicio";
                ParIdTipoServicio.SqlDbType = SqlDbType.Int;
                ParIdTipoServicio.Value = TipoServicio.IdServicio;
                SqlCmd.Parameters.Add(ParIdTipoServicio);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el Servicio";

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
