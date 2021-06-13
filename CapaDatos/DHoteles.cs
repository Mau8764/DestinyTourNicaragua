using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DHoteles
    {
        private int _IdServicioHotel;
        private string _NombreHotel;
        private DateTime _FechaIngreso;
        private int _EdadPersona;
        private DateTime _FechaSalida;
        private int _CantidadPersona;
        private DateTime _FechaReservacion;
        private string _TipoHabitacion;
        private int _IdReservacion;
        private string _TextoBuscar;
        private DateTime _FechaBuscar;
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

        public DateTime FechaIngreso
        {
            get
            {
                return _FechaIngreso;
            }

            set
            {
                _FechaIngreso = value;
            }
        }

        public int EdadPersona
        {
            get
            {
                return _EdadPersona;
            }

            set
            {
                _EdadPersona = value;
            }
        }

        public DateTime FechaSalida
        {
            get
            {
                return _FechaSalida;
            }

            set
            {
                _FechaSalida = value;
            }
        }

        public int CantidadPersona
        {
            get
            {
                return _CantidadPersona;
            }

            set
            {
                _CantidadPersona = value;
            }
        }

        public DateTime FechaReservacion
        {
            get
            {
                return _FechaReservacion;
            }

            set
            {
                _FechaReservacion = value;
            }
        }

        public string TipoHabitacion
        {
            get
            {
                return _TipoHabitacion;
            }

            set
            {
                _TipoHabitacion = value;
            }
        }

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

        public string NombreHotel
        {
            get
            {
                return _NombreHotel;
            }

            set
            {
                _NombreHotel = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }

        public DateTime FechaBuscar
        {
            get
            {
                return _FechaBuscar;
            }

            set
            {
                _FechaBuscar = value;
            }
        }

        public DHoteles()
        {

        }

        public DHoteles(int idserviciohotel,DateTime fechaingreso,int edadpersona,DateTime fechasalida,int cantidadpersonas,DateTime fechareserva,string tipohabitacion)
        {
            this.IdServicioHotel = idserviciohotel;
            this.FechaIngreso = fechaingreso;
            this.EdadPersona = edadpersona;
            this.FechaSalida = fechasalida;
            this.CantidadPersona = cantidadpersonas;
            this.FechaReservacion = fechareserva;
            this.TipoHabitacion = tipohabitacion;
        }


        //Metodos

        //Insertar
        public string Insertar(DHoteles Hoteles)
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
                SqlCmd.CommandText = "SP_InsertarHotel";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParIdServicioHotel = new SqlParameter();
                ParIdServicioHotel.ParameterName = "@idserviciohotel";
                ParIdServicioHotel.SqlDbType = SqlDbType.Int;
                ParIdServicioHotel.Value = Hoteles.IdServicioHotel;
                SqlCmd.Parameters.Add(ParIdServicioHotel);

                SqlParameter ParNombreHotel = new SqlParameter();
                ParNombreHotel.ParameterName = "@nombrehotel";
                ParNombreHotel.SqlDbType = SqlDbType.NVarChar;
                ParNombreHotel.Size = 50;
                ParNombreHotel.Value = Hoteles.NombreHotel;
                SqlCmd.Parameters.Add(ParNombreHotel);

                SqlParameter ParFechaIngreso = new SqlParameter();
                ParFechaIngreso.ParameterName = "@fechaingreso";
                ParFechaIngreso.SqlDbType = SqlDbType.Date;
                ParFechaIngreso.Value = Hoteles.FechaIngreso;
                SqlCmd.Parameters.Add(ParFechaIngreso);

                SqlParameter ParEdadPersona = new SqlParameter();
                ParEdadPersona.ParameterName = "@edadpersona";
                ParEdadPersona.SqlDbType = SqlDbType.Int;
                ParEdadPersona.Value = Hoteles.EdadPersona;
                SqlCmd.Parameters.Add(ParEdadPersona);

                SqlParameter ParFechaSalida = new SqlParameter();
                ParFechaSalida.ParameterName = "@fechasalida";
                ParFechaSalida.SqlDbType = SqlDbType.Date;
                ParFechaSalida.Value = Hoteles.FechaSalida;
                SqlCmd.Parameters.Add(ParFechaSalida);

                SqlParameter ParCantidaPersonas = new SqlParameter();
                ParCantidaPersonas.ParameterName = "@cantidadpersonas";
                ParCantidaPersonas.SqlDbType = SqlDbType.Int;
                ParCantidaPersonas.Value = Hoteles.CantidadPersona;
                SqlCmd.Parameters.Add(ParCantidaPersonas);

                SqlParameter ParFechaReservacion = new SqlParameter();
                ParFechaReservacion.ParameterName = "@fechareservacion";
                ParFechaReservacion.SqlDbType = SqlDbType.Date;
                ParFechaReservacion.Value = Hoteles.FechaReservacion;
                SqlCmd.Parameters.Add(ParFechaReservacion);

                SqlParameter ParTipoHabitacion = new SqlParameter();
                ParTipoHabitacion.ParameterName = "@tipohabitacion";
                ParTipoHabitacion.SqlDbType = SqlDbType.NVarChar;
                ParTipoHabitacion.Size = 50;
                ParTipoHabitacion.Value = Hoteles.TipoHabitacion;
                SqlCmd.Parameters.Add(ParTipoHabitacion);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "No se ingresó la reservación del hotel";

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


        //Editar
        public string Editar(DHoteles Hoteles)
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
                SqlCmd.CommandText = "SP_EditarHotel";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdServicioHotel = new SqlParameter();
                ParIdServicioHotel.ParameterName = "@idserviciohotel";
                ParIdServicioHotel.SqlDbType = SqlDbType.Int;
                ParIdServicioHotel.Value = Hoteles.IdServicioHotel;
                SqlCmd.Parameters.Add(ParIdServicioHotel);

                SqlParameter ParNombreHotel = new SqlParameter();
                ParNombreHotel.ParameterName = "@nombrehotel";
                ParNombreHotel.SqlDbType = SqlDbType.NVarChar;
                ParNombreHotel.Size = 50;
                ParNombreHotel.Value = Hoteles.NombreHotel;
                SqlCmd.Parameters.Add(ParNombreHotel);

                SqlParameter ParFechaIngreso = new SqlParameter();
                ParFechaIngreso.ParameterName = "@fechaingreso";
                ParFechaIngreso.SqlDbType = SqlDbType.Date;
                ParFechaIngreso.Value = Hoteles.FechaIngreso;
                SqlCmd.Parameters.Add(ParFechaIngreso);

                SqlParameter ParEdadPersona = new SqlParameter();
                ParEdadPersona.ParameterName = "@edadpersona";
                ParEdadPersona.SqlDbType = SqlDbType.Int;
                ParEdadPersona.Value = Hoteles.EdadPersona;
                SqlCmd.Parameters.Add(ParEdadPersona);

                SqlParameter ParFechaSalida = new SqlParameter();
                ParFechaSalida.ParameterName = "@fechasalida";
                ParFechaSalida.SqlDbType = SqlDbType.Date;
                ParFechaSalida.Value = Hoteles.FechaSalida;
                SqlCmd.Parameters.Add(ParFechaSalida);

                SqlParameter ParCantidaPersonas = new SqlParameter();
                ParCantidaPersonas.ParameterName = "@cantidadpersonas";
                ParCantidaPersonas.SqlDbType = SqlDbType.Int;
                ParCantidaPersonas.Value = Hoteles.CantidadPersona;
                SqlCmd.Parameters.Add(ParCantidaPersonas);

                SqlParameter ParFechaReservacion = new SqlParameter();
                ParFechaReservacion.ParameterName = "@fechareservacion";
                ParFechaReservacion.SqlDbType = SqlDbType.Date;
                ParFechaReservacion.Value = Hoteles.FechaReservacion;
                SqlCmd.Parameters.Add(ParFechaReservacion);

                SqlParameter ParTipoHabitacion = new SqlParameter();
                ParTipoHabitacion.ParameterName = "@tipohabitacion";
                ParTipoHabitacion.SqlDbType = SqlDbType.NVarChar;
                ParTipoHabitacion.Size = 50;
                ParTipoHabitacion.Value = Hoteles.TipoHabitacion;
                SqlCmd.Parameters.Add(ParTipoHabitacion);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó la reservación del hotel";

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

        //Eliminar o Anular
        public string Eliminar(DHoteles Hoteles)
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
                SqlCmd.CommandText = "SP_EliminarHotel";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdReservacion = new SqlParameter();
                ParIdReservacion.ParameterName = "@idreservacion";
                ParIdReservacion.SqlDbType = SqlDbType.Int;
                ParIdReservacion.Value = Hoteles.IdReservacion;
                SqlCmd.Parameters.Add(ParIdReservacion);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se anuló la reservación del hotel";

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


        //metodo mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Hoteles");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarHoteles";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //metodo buscar por cedula
        public DataTable BuscarCedula(DHoteles Hoteles)
        {
            DataTable DtResultado = new DataTable("Hoteles");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarHotelPorCedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Hoteles.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //buscar boleto por nombre
        public DataTable BuscarNombre(DHoteles Hoteles)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarHotelPorNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Hoteles.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //buscar boleto por fecha
        public DataTable BuscarFecha(DHoteles Hoteles)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarHotelPorFecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Date;
                ParTextoBuscar.Value = Hoteles.FechaBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
