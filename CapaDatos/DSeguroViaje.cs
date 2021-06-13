using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DSeguroViaje
    {
        private int _IdSeguroViaje;
        private string _Pasaporte;
        private string _Destino;
        private DateTime _FechaIda;
        private DateTime _FechaRegreso;
        private string _ContactoEmergencia;
        private string _TelefonoEmergencia;
        private int _IdReservacion;
        private string _TextoBuscar;
        private DateTime _FechaBuscar;
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

        public string Pasaporte
        {
            get
            {
                return _Pasaporte;
            }

            set
            {
                _Pasaporte = value;
            }
        }

        public string Destino
        {
            get
            {
                return _Destino;
            }

            set
            {
                _Destino = value;
            }
        }

        public DateTime FechaIda
        {
            get
            {
                return _FechaIda;
            }

            set
            {
                _FechaIda = value;
            }
        }

        public DateTime FechaRegreso
        {
            get
            {
                return _FechaRegreso;
            }

            set
            {
                _FechaRegreso = value;
            }
        }

        public string ContactoEmergencia
        {
            get
            {
                return _ContactoEmergencia;
            }

            set
            {
                _ContactoEmergencia = value;
            }
        }

        public string TelefonoEmergencia
        {
            get
            {
                return _TelefonoEmergencia;
            }

            set
            {
                _TelefonoEmergencia = value;
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

        public DSeguroViaje()
        {

        }

        public DSeguroViaje(int idseguroviaje,string pasaporte,string destino,DateTime fechaida,DateTime fecharegreso,string contactoemergencia,
            string telefenoemergencia)
        {
            this.IdSeguroViaje = idseguroviaje;
            this.Pasaporte = pasaporte;
            this.Destino = destino;
            this.FechaIda = fechaida;
            this.FechaRegreso = FechaRegreso;
            this.ContactoEmergencia = contactoemergencia;
            this.TelefonoEmergencia = telefenoemergencia;
        }


        //Metodos

        //Insertar
        public string Insertar(DSeguroViaje Seguros)
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
                SqlCmd.CommandText = "SP_InsertarSeguroViaje";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParSeguroViaje = new SqlParameter();
                ParSeguroViaje.ParameterName = "@idseguroviaje";
                ParSeguroViaje.SqlDbType = SqlDbType.Int;
                ParSeguroViaje.Value = Seguros.IdSeguroViaje;
                SqlCmd.Parameters.Add(ParSeguroViaje);

                SqlParameter ParPasaporte = new SqlParameter();
                ParPasaporte.ParameterName = "@pasaporte";
                ParPasaporte.SqlDbType = SqlDbType.NVarChar;
                ParPasaporte.Size = 50;
                ParPasaporte.Value = Seguros.Pasaporte;
                SqlCmd.Parameters.Add(ParPasaporte);

                SqlParameter ParDestino = new SqlParameter();
                ParDestino.ParameterName = "@destino";
                ParDestino.SqlDbType = SqlDbType.NVarChar;
                ParPasaporte.Size = 50;
                ParDestino.Value = Seguros.Destino;
                SqlCmd.Parameters.Add(ParDestino);

                SqlParameter ParFechaIda = new SqlParameter();
                ParFechaIda.ParameterName = "@fechaida";
                ParFechaIda.SqlDbType = SqlDbType.Date;
                ParFechaIda.Value = Seguros.FechaIda;
                SqlCmd.Parameters.Add(ParFechaIda);

                SqlParameter ParFechaRegreso = new SqlParameter();
                ParFechaRegreso.ParameterName = "@fecharegreso";
                ParFechaRegreso.SqlDbType = SqlDbType.Date;
                ParFechaRegreso.Value = Seguros.FechaRegreso;
                SqlCmd.Parameters.Add(ParFechaRegreso);

                SqlParameter ParContactoEmergencia = new SqlParameter();
                ParContactoEmergencia.ParameterName = "@contactoemergencia";
                ParContactoEmergencia.SqlDbType = SqlDbType.NVarChar;
                ParPasaporte.Size = 100;
                ParContactoEmergencia.Value = Seguros.ContactoEmergencia;
                SqlCmd.Parameters.Add(ParContactoEmergencia);

                SqlParameter ParTelefonoEmergencia = new SqlParameter();
                ParTelefonoEmergencia.ParameterName = "@telefonoemergencia";
                ParTelefonoEmergencia.SqlDbType = SqlDbType.NVarChar;
                ParPasaporte.Size = 15;
                ParTelefonoEmergencia.Value = Seguros.TelefonoEmergencia;
                SqlCmd.Parameters.Add(ParTelefonoEmergencia);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "No se ingresó el seguro de viaje";

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
        public string Editar(DSeguroViaje Seguros)
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
                SqlCmd.CommandText = "SP_EditarSeguroViaje";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParSeguroViaje = new SqlParameter();
                ParSeguroViaje.ParameterName = "@idseguroviaje";
                ParSeguroViaje.SqlDbType = SqlDbType.Int;
                ParSeguroViaje.Value = Seguros.IdSeguroViaje;
                SqlCmd.Parameters.Add(ParSeguroViaje);

                SqlParameter ParPasaporte = new SqlParameter();
                ParPasaporte.ParameterName = "@pasaporte";
                ParPasaporte.SqlDbType = SqlDbType.NVarChar;
                ParPasaporte.Size = 50;
                ParPasaporte.Value = Seguros.Pasaporte;
                SqlCmd.Parameters.Add(ParPasaporte);

                SqlParameter ParDestino = new SqlParameter();
                ParDestino.ParameterName = "@destino";
                ParDestino.SqlDbType = SqlDbType.NVarChar;
                ParPasaporte.Size = 50;
                ParDestino.Value = Seguros.Destino;
                SqlCmd.Parameters.Add(ParDestino);

                SqlParameter ParFechaIda = new SqlParameter();
                ParFechaIda.ParameterName = "@fechaida";
                ParFechaIda.SqlDbType = SqlDbType.Date;
                ParFechaIda.Value = Seguros.FechaIda;
                SqlCmd.Parameters.Add(ParFechaIda);

                SqlParameter ParFechaRegreso = new SqlParameter();
                ParFechaRegreso.ParameterName = "@fecharegreso";
                ParFechaRegreso.SqlDbType = SqlDbType.Date;
                ParFechaRegreso.Value = Seguros.FechaRegreso;
                SqlCmd.Parameters.Add(ParFechaRegreso);

                SqlParameter ParContactoEmergencia = new SqlParameter();
                ParContactoEmergencia.ParameterName = "@contactoemergencia";
                ParContactoEmergencia.SqlDbType = SqlDbType.NVarChar;
                ParPasaporte.Size = 100;
                ParContactoEmergencia.Value = Seguros.ContactoEmergencia;
                SqlCmd.Parameters.Add(ParContactoEmergencia);

                SqlParameter ParTelefonoEmergencia = new SqlParameter();
                ParTelefonoEmergencia.ParameterName = "@telefonoemergencia";
                ParTelefonoEmergencia.SqlDbType = SqlDbType.NVarChar;
                ParPasaporte.Size = 15;
                ParTelefonoEmergencia.Value = Seguros.TelefonoEmergencia;
                SqlCmd.Parameters.Add(ParTelefonoEmergencia);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó el seguro de viaje";

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
        public string Eliminar(DSeguroViaje Seguros)
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
                SqlCmd.CommandText = "SP_EliminarSeguroViaje";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdReservacion = new SqlParameter();
                ParIdReservacion.ParameterName = "@idreservacion";
                ParIdReservacion.SqlDbType = SqlDbType.Int;
                ParIdReservacion.Value = Seguros.IdReservacion;
                SqlCmd.Parameters.Add(ParIdReservacion);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se anuló el seguro de viaje";

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
            DataTable DtResultado = new DataTable("Seguros");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarSeguroViajes";
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
        public DataTable BuscarCedula(DSeguroViaje Seguros)
        {
            DataTable DtResultado = new DataTable("Seguros");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarSeguroPorCedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Seguros.TextoBuscar;
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
        public DataTable BuscarNombre(DSeguroViaje Seguros)
        {
            DataTable DtResultado = new DataTable("Seguros");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarSeguroPorNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Seguros.TextoBuscar;
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

        //metodo buscar por pasaporte
        public DataTable BuscarPasaporte(DSeguroViaje Seguros)
        {
            DataTable DtResultado = new DataTable("Seguros");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarSeguroPorPasaporte";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Seguros.TextoBuscar;
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
        public DataTable BuscarFecha(DSeguroViaje Seguros)
        {
            DataTable DtResultado = new DataTable("Seguros");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarSeguroPorFecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Date;
                ParTextoBuscar.Value = Seguros.FechaBuscar;
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
