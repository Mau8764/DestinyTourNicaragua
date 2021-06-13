using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DChoferCoster
    {
        private int _IdChofer;
        private string _CedulaChofer;
        private string _NombreChofer;
        private int _CantidaCoster;
        private int _CapacidadCoster;
        private string _TextoBuscar;

        public int IdChofer
        {
            get
            {
                return _IdChofer;
            }

            set
            {
                _IdChofer = value;
            }
        }

        public string CedulaChofer
        {
            get
            {
                return _CedulaChofer;
            }

            set
            {
                _CedulaChofer = value;
            }
        }

        public string NombreChofer
        {
            get
            {
                return _NombreChofer;
            }

            set
            {
                _NombreChofer = value;
            }
        }

        public int CantidaCoster
        {
            get
            {
                return _CantidaCoster;
            }

            set
            {
                _CantidaCoster = value;
            }
        }

        public int CapacidadCoster
        {
            get
            {
                return _CapacidadCoster;
            }

            set
            {
                _CapacidadCoster = value;
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

        //Constructores primero el vacio y luego con parametros
        public DChoferCoster()
        {

        }

        //Con Parametros
        public DChoferCoster(int idchofercoster, string cedulachofer, string nombrechofer,int cantidadcoster,int capacidad)
        {
            this.IdChofer = idchofercoster;
            this.CedulaChofer = cedulachofer;
            this.NombreChofer = nombrechofer;
            this.CantidaCoster = cantidadcoster;
            this.CapacidadCoster = capacidad;
        }

        //Metodos

        //Insertar
        public string Insertar(DChoferCoster Chofer)
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
                SqlCmd.CommandText = "SP_InsertarChofer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parámetros al comando
                //Establecemos los valores para el parámetro
                //@idcategoria del Procedimiento Almacenado
                SqlParameter ParIdChofer = new SqlParameter();
                ParIdChofer.ParameterName = "@idchofer";
                ParIdChofer.SqlDbType = SqlDbType.Int;
                ParIdChofer.Value = Chofer.IdChofer;
                SqlCmd.Parameters.Add(ParIdChofer);
                //Agregamos el parámetro al comando


                SqlParameter ParCedulaChofer = new SqlParameter();
                ParCedulaChofer.ParameterName = "@cedulachofer";
                ParCedulaChofer.SqlDbType = SqlDbType.VarChar;
                ParCedulaChofer.Size = 20;
                ParCedulaChofer.Value = Chofer.CedulaChofer;
                SqlCmd.Parameters.Add(ParCedulaChofer);

                SqlParameter ParNombreChofer = new SqlParameter();
                ParNombreChofer.ParameterName = "@nombrechofer";
                ParNombreChofer.SqlDbType = SqlDbType.VarChar;
                ParNombreChofer.Size = 50;
                ParNombreChofer.Value = Chofer.NombreChofer;
                SqlCmd.Parameters.Add(ParNombreChofer);

                SqlParameter ParCantidadCoster = new SqlParameter();
                ParCantidadCoster.ParameterName = "@cantidadcoster";
                ParCantidadCoster.SqlDbType = SqlDbType.Int;
                ParCantidadCoster.Value = Chofer.CantidaCoster;
                SqlCmd.Parameters.Add(ParCantidadCoster);

                SqlParameter ParCapacidad = new SqlParameter();
                ParCapacidad.ParameterName = "@capacidad";
                ParCapacidad.SqlDbType = SqlDbType.Int;
                ParCapacidad.Value = Chofer.CapacidadCoster;
                SqlCmd.Parameters.Add(ParCapacidad);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el chofer";

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

        public string EditarChofer(DChoferCoster Chofer)
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
                SqlCmd.CommandText = "SP_EditarChofer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdChofer = new SqlParameter();
                ParIdChofer.ParameterName = "@@idchofer";
                ParIdChofer.SqlDbType = SqlDbType.Int;
                ParIdChofer.Value = Chofer.IdChofer;
                SqlCmd.Parameters.Add(ParIdChofer);


                SqlParameter ParCedulaChofer = new SqlParameter();
                ParCedulaChofer.ParameterName = "@cedulachofer";
                ParCedulaChofer.SqlDbType = SqlDbType.VarChar;
                ParCedulaChofer.Size = 20;
                ParCedulaChofer.Value = Chofer.CedulaChofer;
                SqlCmd.Parameters.Add(ParCedulaChofer);

                SqlParameter ParNombreChofer = new SqlParameter();
                ParNombreChofer.ParameterName = "@nombrechofer";
                ParNombreChofer.SqlDbType = SqlDbType.VarChar;
                ParNombreChofer.Size = 50;
                ParNombreChofer.Value = Chofer.NombreChofer;
                SqlCmd.Parameters.Add(ParNombreChofer);

                SqlParameter ParCantidadCoster = new SqlParameter();
                ParCantidadCoster.ParameterName = "@cantidadcoster";
                ParCantidadCoster.SqlDbType = SqlDbType.Int;
                ParCantidadCoster.Value = Chofer.CantidaCoster;
                SqlCmd.Parameters.Add(ParCantidadCoster);

                SqlParameter ParCapacidad = new SqlParameter();
                ParCapacidad.ParameterName = "@capacidad";
                ParCapacidad.SqlDbType = SqlDbType.Int;
                ParCapacidad.Value = Chofer.CapacidadCoster;
                SqlCmd.Parameters.Add(ParCapacidad);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el chofer";

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

        public string Eliminar(DChoferCoster Chofer)
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
                SqlCmd.CommandText = "SP_EliminarChofer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdChofer = new SqlParameter();
                ParIdChofer.ParameterName = "@idchofer";
                ParIdChofer.SqlDbType = SqlDbType.Int;
                ParIdChofer.Value = Chofer.IdChofer;
                SqlCmd.Parameters.Add(ParIdChofer);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el chofer";

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
        public DataTable MostrarChoferReservacion(DChoferCoster Chofer)
        {
            DataTable DtResultado = new DataTable("Acompañante");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarChofer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = Chofer.TextoBuscar;
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
