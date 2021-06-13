using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DReservacion
    {
        private int _IdReservacion;
        private DateTime _FechaReservacion;
        private decimal _Pago;
        private decimal _Pendiente;
        private string _Cedula;
        private string _TextoBuscar;
        private DateTime _FechaBuscar;
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

        public decimal Pago
        {
            get
            {
                return _Pago;
            }

            set
            {
                _Pago = value;
            }
        }

        public string Cedula
        {
            get
            {
                return _Cedula;
            }

            set
            {
                _Cedula = value;
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

        public decimal Pendiente
        {
            get
            {
                return _Pendiente;
            }

            set
            {
                _Pendiente = value;
            }
        }

        //Constructores primero el vacio y luego con parametros
        public DReservacion()
        {

        }

        //Con Parametros
        public DReservacion(int idreservacion, DateTime fechareservacion, decimal pago,
            string cedula,int idchofercoster)
        {
            this.IdReservacion = idreservacion;
            this.FechaReservacion = fechareservacion;
            this.Pago = pago;
            this.Cedula = cedula;
          
        }


        //Metodos

        //Insertar
        public string Insertar(DReservacion Reservacion)
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
                SqlCmd.CommandText = "SP_InsertarReservacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parámetros al comando
                //Establecemos los valores para el parámetro
                //@idcategoria del Procedimiento Almacenado
                SqlParameter ParIdReservacion = new SqlParameter();
                ParIdReservacion.ParameterName = "@idreservacion";
                ParIdReservacion.SqlDbType = SqlDbType.Int;
                ParIdReservacion.Value = Reservacion.IdReservacion;
                SqlCmd.Parameters.Add(ParIdReservacion);
                //Agregamos el parámetro al comando


                SqlParameter ParFechaReservacion = new SqlParameter();
                ParFechaReservacion.ParameterName = "@fechareservacion";
                ParFechaReservacion.SqlDbType = SqlDbType.Date;
                ParFechaReservacion.Value = Reservacion.FechaReservacion;
                SqlCmd.Parameters.Add(ParFechaReservacion);

                SqlParameter ParPago = new SqlParameter();
                ParPago.ParameterName = "@pago";
                ParPago.SqlDbType = SqlDbType.Decimal;
                ParPago.Value = Reservacion.Pago;
                SqlCmd.Parameters.Add(ParPago);

                SqlParameter ParPendiente = new SqlParameter();
                ParPendiente.ParameterName = "@pendiente";
                ParPendiente.SqlDbType = SqlDbType.Decimal;
                ParPendiente.Value = Reservacion.Pendiente;
                SqlCmd.Parameters.Add(ParPendiente);

                SqlParameter ParCedulaCliente = new SqlParameter();
                ParCedulaCliente.ParameterName = "@cedula";
                ParCedulaCliente.SqlDbType = SqlDbType.VarChar;
                ParCedulaCliente.Size = 20;
                ParCedulaCliente.Value = Reservacion.Cedula;
                SqlCmd.Parameters.Add(ParCedulaCliente);

                

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso la reservacion";

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


        public string Editar(DReservacion Reservacion)
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
                SqlCmd.CommandText = "SP_EditarReservacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdReservacion = new SqlParameter();
                ParIdReservacion.ParameterName = "@idreservacion";
                ParIdReservacion.SqlDbType = SqlDbType.Int;
                ParIdReservacion.Value = Reservacion.IdReservacion;
                SqlCmd.Parameters.Add(ParIdReservacion);


                SqlParameter ParFechaReservacion = new SqlParameter();
                ParFechaReservacion.ParameterName = "@fechareservacion";
                ParFechaReservacion.SqlDbType = SqlDbType.Date;
                ParFechaReservacion.Value = Reservacion.FechaReservacion;
                SqlCmd.Parameters.Add(ParFechaReservacion);

                SqlParameter ParPago = new SqlParameter();
                ParPago.ParameterName = "@pago";
                ParPago.SqlDbType = SqlDbType.Decimal;
                ParPago.Value = Reservacion.Pago;
                SqlCmd.Parameters.Add(ParPago);

                SqlParameter ParPendiente = new SqlParameter();
                ParPendiente.ParameterName = "@pendiente";
                ParPendiente.SqlDbType = SqlDbType.Decimal;
                ParPendiente.Value = Reservacion.Pendiente;
                SqlCmd.Parameters.Add(ParPendiente);

                SqlParameter ParCedulaCliente = new SqlParameter();
                ParCedulaCliente.ParameterName = "@cedula";
                ParCedulaCliente.SqlDbType = SqlDbType.VarChar;
                ParCedulaCliente.Size = 20;
                ParCedulaCliente.Value = Reservacion.Cedula;
                SqlCmd.Parameters.Add(ParCedulaCliente);

                


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el reservacion";

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

        public string Eliminar(DReservacion Reservacion)
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
                SqlCmd.CommandText = "SP_EliminarReservacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdReservacion = new SqlParameter();
                ParIdReservacion.ParameterName = "@idreservacion";
                ParIdReservacion.SqlDbType = SqlDbType.Int;
                ParIdReservacion.Value = Reservacion.IdReservacion;
                SqlCmd.Parameters.Add(ParIdReservacion);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se anuló la reservacion";

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




        /* public string ObteneMAXIDReservacion(DReservacion Reservacion)
         {
             string rpta = "";
             string sql= "select MAX(Id_Reservacion) from Reservacion";
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 //codigo para editar
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCon.Open();
                 //Establece codigo para ejecutar el procedimiento
                 SqlCommand SqlCmd = new SqlCommand(sql, SqlCon);
                 SqlDataReader lector = SqlCmd.ExecuteReader();
                 Console.WriteLine(lector.GetValue(0));
             }
             catch (Exception ex)
             {
                 rpta = ex.Message;
             }
             finally
             {
                 if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
             }



         }*/
       
        public DataTable MostrarReservacionCedulaCliente(DReservacion Reservacion)
        {
            DataTable DtResultado = new DataTable("Acompañante");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarReservacionCedulaCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = Reservacion.TextoBuscar;
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


        public DataTable MostrarReservaciones()
        {
            DataTable DtResultado = new DataTable("Reservaciones");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarReservaciones";
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

        public DataTable MostrarReservacionesPaqueteNacional()
        {
            DataTable DtResultado = new DataTable("Reservaciones");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarReservacionesPaqueteNacional";
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
        public DataTable BuscarCedula(DReservacion Reservacion)
        {
            DataTable DtResultado = new DataTable("Reservacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarReservacionPorCedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Reservacion.TextoBuscar;
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

        //buscar renta por nombre
        public DataTable BuscarNombre(DReservacion Reservacion)
        {
            DataTable DtResultado = new DataTable("Reservacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarReservacionPorNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Reservacion.TextoBuscar;
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

        //buscar renta por fecha
        public DataTable BuscarFecha(DReservacion Reservacion)
        {
            DataTable DtResultado = new DataTable("Reservacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarReservacionPorFecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Date;
                ParTextoBuscar.Value = Reservacion.FechaBuscar;
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

        public DataTable MostrarReservacionTour(DReservacion Reservacion)
        {
            DataTable DtResultado = new DataTable("Reservacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarReservacionesTour";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Reservacion.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParFechaBuscar = new SqlParameter();
                ParFechaBuscar.ParameterName = "@fecha";
                ParFechaBuscar.SqlDbType = SqlDbType.Date;
                ParFechaBuscar.Value = Reservacion.FechaBuscar;
                SqlCmd.Parameters.Add(ParFechaBuscar);

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
