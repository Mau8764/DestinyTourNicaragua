using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DAcompañante
    {
        private int _IdAcompañante;
        private string _NombreAcompañante;
        private string _CedulaAcompañante;
        private string _TextoBuscar;

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

        public string NombreAcompañante
        {
            get
            {
                return _NombreAcompañante;
            }

            set
            {
                _NombreAcompañante = value;
            }
        }

        public string CedulaAcompañante
        {
            get
            {
                return _CedulaAcompañante;
            }

            set
            {
                _CedulaAcompañante = value;
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
        public DAcompañante()
        {

        }

        //Con Parametros
        public DAcompañante(int idacompañante,string nombreacompañante,string cedulaacompañante)
        {
            this.IdAcompañante = idacompañante;
            this.NombreAcompañante = nombreacompañante;
            this.CedulaAcompañante = cedulaacompañante;
        }
        //Metodos

        //Insertar
        public string Insertar(DAcompañante Acompañante)
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
                SqlCmd.CommandText = "SP_InsertarAcompañante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parámetros al comando
                //Establecemos los valores para el parámetro
                //@acompañante del Procedimiento Almacenado
                SqlParameter ParIdAcompañante = new SqlParameter();
                ParIdAcompañante.ParameterName = "@idacompañante";
                ParIdAcompañante.SqlDbType = SqlDbType.Int;
                ParIdAcompañante.Value = Acompañante.IdAcompañante;
                SqlCmd.Parameters.Add(ParIdAcompañante);
                //Agregamos el parámetro al comando


                SqlParameter ParNombreAcompañante = new SqlParameter();
                ParNombreAcompañante.ParameterName = "@Nombre_acompañante";
                ParNombreAcompañante.SqlDbType = SqlDbType.VarChar;
                ParNombreAcompañante.Size = 50;
                ParNombreAcompañante.Value = Acompañante.NombreAcompañante;
                SqlCmd.Parameters.Add(ParNombreAcompañante);

                SqlParameter ParCedulaAcom = new SqlParameter();
                ParCedulaAcom.ParameterName = "@cedula";
                ParCedulaAcom.SqlDbType = SqlDbType.VarChar;
                ParCedulaAcom.Size = 20;
                ParCedulaAcom.Value = Acompañante.CedulaAcompañante;
                SqlCmd.Parameters.Add(ParCedulaAcom);

                       //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Acompañante";

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

        public string Editar(DAcompañante Acompañante)
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
                SqlCmd.CommandText = "SP_EditarAcompañante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdAcompañante = new SqlParameter();
                ParIdAcompañante.ParameterName = "@idacompañante";
                ParIdAcompañante.SqlDbType = SqlDbType.Int;
                ParIdAcompañante.Value = Acompañante.IdAcompañante;
                SqlCmd.Parameters.Add(ParIdAcompañante);


                SqlParameter ParNombreAcompañante = new SqlParameter();
                ParNombreAcompañante.ParameterName = "@Nombre_acompañante";
                ParNombreAcompañante.SqlDbType = SqlDbType.VarChar;
                ParNombreAcompañante.Size = 50;
                ParNombreAcompañante.Value = Acompañante.NombreAcompañante;
                SqlCmd.Parameters.Add(ParNombreAcompañante);

                SqlParameter ParCedulaAcom = new SqlParameter();
                ParCedulaAcom.ParameterName = "@cedula";
                ParCedulaAcom.SqlDbType = SqlDbType.VarChar;
                ParCedulaAcom.Size = 20;
                ParCedulaAcom.Value = Acompañante.CedulaAcompañante;
                SqlCmd.Parameters.Add(ParCedulaAcom);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el acompañante";

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

        public string Eliminar(DAcompañante Acompañante)
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
                SqlCmd.CommandText = "SP_EliminarAcompañante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdAcompañante = new SqlParameter();
                ParIdAcompañante.ParameterName = "@idacompañante";
                ParIdAcompañante.SqlDbType = SqlDbType.Int;
                ParIdAcompañante.Value = Acompañante.IdAcompañante;
                SqlCmd.Parameters.Add(ParIdAcompañante);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el acompañante";

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
        /*public DataTable MostrarAcompañanteCedulaCliente(DAcompañante Acompañante)
        {
            DataTable DtResultado = new DataTable("Acompañante");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarAcompañante";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = Acompañante.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }*/

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Acompañantes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarAcompañantes";
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
        public DataTable BuscarCedula(DAcompañante Acompañante)
        {
            DataTable DtResultado = new DataTable("Acompañante");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarAcompañantePorCedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Acompañante.TextoBuscar;
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
        public DataTable BuscarNombre(DAcompañante Acompañante)
        {
            DataTable DtResultado = new DataTable("Acompañante");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarAcompañantePorNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.NVarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Acompañante.TextoBuscar;
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
