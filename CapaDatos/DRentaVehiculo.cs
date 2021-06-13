using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DRentaVehiculo
    {
        private int _IdRentaVehiculo;
        private int _CantidadDias;
        private string _TipoCarro;
        private DateTime _FechaRenta;
        private DateTime _FechaDevolucion;
        private string _Placa;
        private string _TextoBuscar;
        private int _Idreservacion;
        private DateTime _FechaBuscar;
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

        public int CantidadDias
        {
            get
            {
                return _CantidadDias;
            }

            set
            {
                _CantidadDias = value;
            }
        }

        public string TipoCarro
        {
            get
            {
                return _TipoCarro;
            }

            set
            {
                _TipoCarro = value;
            }
        }

        public DateTime FechaRenta
        {
            get
            {
                return _FechaRenta;
            }

            set
            {
                _FechaRenta = value;
            }
        }

        public DateTime FechaDevolucion
        {
            get
            {
                return _FechaDevolucion;
            }

            set
            {
                _FechaDevolucion = value;
            }
        }

        public string Placa
        {
            get
            {
                return _Placa;
            }

            set
            {
                _Placa = value;
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

        public int Idreservacion
        {
            get
            {
                return _Idreservacion;
            }

            set
            {
                _Idreservacion = value;
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

        public DRentaVehiculo()
        {

        }

        public DRentaVehiculo(int idrentavehiculo, int cantidaddias, string tipocarro, DateTime fecharenta, DateTime fechadevolucion, string placa)
        {
            this.IdRentaVehiculo = idrentavehiculo;
            this.CantidadDias = cantidaddias;
            this.TipoCarro = tipocarro;
            this.FechaRenta = fecharenta;
            this.FechaDevolucion = fechadevolucion;
            this.Placa = placa;
        }


        //Metodos

        //Insertar
        public string Insertar(DRentaVehiculo RentaVehiculo)
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
                SqlCmd.CommandText = "SP_InsertarRentaVehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParIdRentaVehiculo = new SqlParameter();
                ParIdRentaVehiculo.ParameterName = "@idrentavehiculo";
                ParIdRentaVehiculo.SqlDbType = SqlDbType.Int;
                ParIdRentaVehiculo.Value = RentaVehiculo.IdRentaVehiculo;
                SqlCmd.Parameters.Add(ParIdRentaVehiculo);

                SqlParameter ParCantidadDia = new SqlParameter();
                ParCantidadDia.ParameterName = "@cantidaddia";
                ParCantidadDia.SqlDbType = SqlDbType.Int;
                ParCantidadDia.Value = RentaVehiculo.CantidadDias;
                SqlCmd.Parameters.Add(ParCantidadDia);

                SqlParameter ParTipoCarro = new SqlParameter();
                ParTipoCarro.ParameterName = "@tipocarro";
                ParTipoCarro.SqlDbType = SqlDbType.NVarChar;
                ParTipoCarro.Size = 20;
                ParTipoCarro.Value = RentaVehiculo.TipoCarro;
                SqlCmd.Parameters.Add(ParTipoCarro);

                SqlParameter ParFechaRenta = new SqlParameter();
                ParFechaRenta.ParameterName = "@fecharenta";
                ParFechaRenta.SqlDbType = SqlDbType.Date;
                ParFechaRenta.Value = RentaVehiculo.FechaRenta;
                SqlCmd.Parameters.Add(ParFechaRenta);

                SqlParameter ParFechaDevolucion = new SqlParameter();
                ParFechaDevolucion.ParameterName = "@fechadevolucion";
                ParFechaDevolucion.SqlDbType = SqlDbType.Date;
                ParFechaDevolucion.Value = RentaVehiculo.FechaDevolucion;
                SqlCmd.Parameters.Add(ParFechaDevolucion);

                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 8;
                ParPlaca.Value = RentaVehiculo.Placa;
                SqlCmd.Parameters.Add(ParPlaca);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "No se ingresó la renta del vehículo";

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


        public string Editar(DRentaVehiculo RentaVehiculo)
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
                SqlCmd.CommandText = "SP_EditarRentaVehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRentaVehiculo = new SqlParameter();
                ParIdRentaVehiculo.ParameterName = "@idrentavehiculo";
                ParIdRentaVehiculo.SqlDbType = SqlDbType.Int;
                ParIdRentaVehiculo.Value = RentaVehiculo.IdRentaVehiculo;
                SqlCmd.Parameters.Add(ParIdRentaVehiculo);

                SqlParameter ParCantidadDia = new SqlParameter();
                ParCantidadDia.ParameterName = "@cantidaddia";
                ParCantidadDia.SqlDbType = SqlDbType.Int;
                ParCantidadDia.Value = RentaVehiculo.CantidadDias;
                SqlCmd.Parameters.Add(ParCantidadDia);

                SqlParameter ParTipoCarro = new SqlParameter();
                ParTipoCarro.ParameterName = "@tipocarro";
                ParTipoCarro.SqlDbType = SqlDbType.NVarChar;
                ParTipoCarro.Size = 20;
                ParTipoCarro.Value = RentaVehiculo.TipoCarro;
                SqlCmd.Parameters.Add(ParTipoCarro);

                SqlParameter ParFechaRenta = new SqlParameter();
                ParFechaRenta.ParameterName = "@fecharenta";
                ParFechaRenta.SqlDbType = SqlDbType.Date;
                ParFechaRenta.Value = RentaVehiculo.FechaRenta;
                SqlCmd.Parameters.Add(ParFechaRenta);

                SqlParameter ParFechaDevolucion = new SqlParameter();
                ParFechaDevolucion.ParameterName = "@fechadevolucion";
                ParFechaDevolucion.SqlDbType = SqlDbType.Date;
                ParFechaDevolucion.Value = RentaVehiculo.FechaDevolucion;
                SqlCmd.Parameters.Add(ParFechaDevolucion);

                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 8;
                ParPlaca.Value = RentaVehiculo.Placa;
                SqlCmd.Parameters.Add(ParPlaca);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó la renta de vehículo";

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

        public string Eliminar(DRentaVehiculo RentaVehiculo)
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
                SqlCmd.CommandText = "SP_EliminarRentaVehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdReservacion = new SqlParameter();
                ParIdReservacion.ParameterName = "@idreservacion";
                ParIdReservacion.SqlDbType = SqlDbType.Int;
                ParIdReservacion.Value = RentaVehiculo.Idreservacion;
                SqlCmd.Parameters.Add(ParIdReservacion);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se eliminó la renta del vehículo";

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
            DataTable DtResultado = new DataTable("Renta Vehiculo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarRentaVehiculos";
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
        public DataTable BuscarCedula(DRentaVehiculo Renta)
        {
            DataTable DtResultado = new DataTable("Renta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarRentaPorCedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Renta.TextoBuscar;
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
        public DataTable BuscarNombre(DRentaVehiculo Renta)
        {
            DataTable DtResultado = new DataTable("Renta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarRentaPorNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Renta.TextoBuscar;
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
        public DataTable BuscarFecha(DRentaVehiculo Renta)
        {
            DataTable DtResultado = new DataTable("Renta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarRentaPorFecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Date;
                ParTextoBuscar.Value = Renta.FechaBuscar;
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
