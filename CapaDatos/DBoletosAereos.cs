using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DBoletosAereos
    {
        private int _IdBoleto;
        private string _Destino;
        private DateTime _FechaIda;
        private decimal _Tarifa;
        private DateTime _FechaRegreso;
        private string _LineaAerea;
        private string _CabinaAvion;
        private int _Idreservacion;
        private string _TextoBuscar;
        private DateTime _FechaBuscar;

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

        public decimal Tarifa
        {
            get
            {
                return _Tarifa;
            }

            set
            {
                _Tarifa = value;
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

        public string LineaAerea
        {
            get
            {
                return _LineaAerea;
            }

            set
            {
                _LineaAerea = value;
            }
        }

        public string CabinaAvion
        {
            get
            {
                return _CabinaAvion;
            }

            set
            {
                _CabinaAvion = value;
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

        public DBoletosAereos()
        {

        }
        public DBoletosAereos(int idboleto,string destino,DateTime fechaida, decimal tarifa,DateTime fecharegreso,string lineaaerea,string cabinaavion)
        {
            this.IdBoleto = idboleto;
            this.Destino = destino;
            this.FechaIda = fechaida;
            this.Tarifa = tarifa;
            this.FechaRegreso = fecharegreso;
            this.LineaAerea = lineaaerea;
            this.CabinaAvion = cabinaavion;
        }



        //Metodos

        //Insertar
        public string Insertar(DBoletosAereos BoletosAereos)
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
                SqlCmd.CommandText = "SP_InsertarBoletoAereo";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParIdBoleto = new SqlParameter();
                ParIdBoleto.ParameterName = "@idboleto";
                ParIdBoleto.SqlDbType = SqlDbType.Int;
                ParIdBoleto.Value = BoletosAereos.IdBoleto;
                SqlCmd.Parameters.Add(ParIdBoleto);

                SqlParameter ParDestino = new SqlParameter();
                ParDestino.ParameterName = "@destino";
                ParDestino.SqlDbType = SqlDbType.NVarChar;
                ParDestino.Size = 50;
                ParDestino.Value = BoletosAereos.Destino;
                SqlCmd.Parameters.Add(ParDestino);

                SqlParameter ParFechaIda = new SqlParameter();
                ParFechaIda.ParameterName = "@fechaida";
                ParFechaIda.SqlDbType = SqlDbType.DateTime;
                ParFechaIda.Value = BoletosAereos.FechaIda;
                SqlCmd.Parameters.Add(ParFechaIda);

                SqlParameter ParTarifa = new SqlParameter();
                ParTarifa.ParameterName = "@tarifa";
                ParTarifa.SqlDbType = SqlDbType.Decimal;
                ParTarifa.Value = BoletosAereos.Tarifa;
                SqlCmd.Parameters.Add(ParTarifa);

                SqlParameter ParFechaRegreso = new SqlParameter();
                ParFechaRegreso.ParameterName = "@fecharegreso";
                ParFechaRegreso.SqlDbType = SqlDbType.Date;
                ParFechaRegreso.Value = BoletosAereos.FechaRegreso;
                SqlCmd.Parameters.Add(ParFechaRegreso);

                SqlParameter ParLineaAerea = new SqlParameter();
                ParLineaAerea.ParameterName = "@lineaaerea";
                ParLineaAerea.SqlDbType = SqlDbType.NVarChar;
                ParLineaAerea.Size = 50;
                ParLineaAerea.Value = BoletosAereos.LineaAerea;
                SqlCmd.Parameters.Add(ParLineaAerea);

                SqlParameter ParCabinaAvion = new SqlParameter();
                ParCabinaAvion.ParameterName = "@cabinaavion";
                ParCabinaAvion.SqlDbType = SqlDbType.NVarChar;
                ParCabinaAvion.Size = 30;
                ParCabinaAvion.Value = BoletosAereos.CabinaAvion;
                SqlCmd.Parameters.Add(ParCabinaAvion);

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


        //Editar
        public string Editar(DBoletosAereos BoletosAereos)
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
                SqlCmd.CommandText = "SP_EditarBoletoAereo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdBoleto = new SqlParameter();
                ParIdBoleto.ParameterName = "@idboleto";
                ParIdBoleto.SqlDbType = SqlDbType.Int;
                ParIdBoleto.Value = BoletosAereos.IdBoleto;
                SqlCmd.Parameters.Add(ParIdBoleto);

                SqlParameter ParDestino = new SqlParameter();
                ParDestino.ParameterName = "@destino";
                ParDestino.SqlDbType = SqlDbType.NVarChar;
                ParDestino.Size = 50;
                ParDestino.Value = BoletosAereos.Destino;
                SqlCmd.Parameters.Add(ParDestino);

                SqlParameter ParFechaIda = new SqlParameter();
                ParFechaIda.ParameterName = "@fechaida";
                ParFechaIda.SqlDbType = SqlDbType.DateTime;
                ParFechaIda.Value = BoletosAereos.FechaIda;
                SqlCmd.Parameters.Add(ParFechaIda);

                SqlParameter ParTarifa = new SqlParameter();
                ParTarifa.ParameterName = "@tarifa";
                ParTarifa.SqlDbType = SqlDbType.Decimal;
                ParTarifa.Value = BoletosAereos.Tarifa;
                SqlCmd.Parameters.Add(ParTarifa);

                SqlParameter ParFechaRegreso = new SqlParameter();
                ParFechaRegreso.ParameterName = "@fecharegreso";
                ParFechaRegreso.SqlDbType = SqlDbType.Date;
                ParFechaRegreso.Value = BoletosAereos.FechaRegreso;
                SqlCmd.Parameters.Add(ParFechaRegreso);

                SqlParameter ParLineaAerea = new SqlParameter();
                ParLineaAerea.ParameterName = "@lineaaerea";
                ParLineaAerea.SqlDbType = SqlDbType.NVarChar;
                ParLineaAerea.Size = 50;
                ParLineaAerea.Value = BoletosAereos.LineaAerea;
                SqlCmd.Parameters.Add(ParLineaAerea);

                SqlParameter ParCabinaAvion = new SqlParameter();
                ParCabinaAvion.ParameterName = "@cabinaavion";
                ParCabinaAvion.SqlDbType = SqlDbType.NVarChar;
                ParCabinaAvion.Size = 30;
                ParCabinaAvion.Value = BoletosAereos.CabinaAvion;
                SqlCmd.Parameters.Add(ParCabinaAvion);

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

        //Eliminar o Anular
        public string Eliminar(DBoletosAereos BoletosAereos)
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
                SqlCmd.CommandText = "SP_EliminarBoletoAereo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdReservacion = new SqlParameter();
                ParIdReservacion.ParameterName = "@idreservacion";
                ParIdReservacion.SqlDbType = SqlDbType.Int;
                ParIdReservacion.Value = BoletosAereos.Idreservacion;
                SqlCmd.Parameters.Add(ParIdReservacion);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se anuló la venta del boleto";

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
            DataTable DtResultado = new DataTable("Boleto Aereo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarBoletosAereos";
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
        public DataTable BuscarCedula(DBoletosAereos Boletos)
        {
            DataTable DtResultado = new DataTable("Boletos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarBoletoPorCedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Boletos.TextoBuscar;
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
        public DataTable BuscarNombre(DBoletosAereos Boletos)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarBoletoPorNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Boletos.TextoBuscar;
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
        public DataTable BuscarFecha(DBoletosAereos Boletos)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarBoletoPorFecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Date;
                ParTextoBuscar.Value = Boletos.FechaBuscar;
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
