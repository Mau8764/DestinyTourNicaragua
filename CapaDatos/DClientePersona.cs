using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DClientePersona
    {
        private string _Cedula;
        private string _Correo;
        private string _Nombre;
        private string _Sexo;
        private int _Edad;
        private int _Telefono;
        private string _TextoBuscar;

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

        public string Correo
        {
            get
            {
                return _Correo;
            }

            set
            {
                _Correo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Sexo
        {
            get
            {
                return _Sexo;
            }

            set
            {
                _Sexo = value;
            }
        }

        public int Edad
        {
            get
            {
                return _Edad;
            }

            set
            {
                _Edad = value;
            }
        }

        public int Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
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

        //Constructor vacío
        public DClientePersona()
        {

        }

        //contructor con parametros
        public DClientePersona(string cedula,string correo,string nombre,
            string sexo,int edad,int telefono,string textobuscar)
        {
            this.Cedula = cedula;
            this.Correo = correo;
            this.Nombre = nombre;
            this.Sexo = sexo;
            this.Edad = edad;
            this.Telefono = telefono;
            this.TextoBuscar = textobuscar;
        }

        //metodo insertar
        public string Insertar(DClientePersona ClientePersona)//List<DAcompañante> Acompañante)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo para insertar
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer la transaccion
               // SqlTransaction SqlTra = SqlCon.BeginTransaction();  
                //Establece codigo para ejecutar el procedimiento
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                //SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "SP_InsertarClientePersona";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@Cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 20;
                ParCedula.Direction = ParameterDirection.InputOutput;
                ParCedula.Value = ClientePersona.Cedula;
                SqlCmd.Parameters.Add(ParCedula);


                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo_Electronico";
                ParCorreo.SqlDbType = SqlDbType.NVarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = ClientePersona.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = ClientePersona.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 10;
                ParSexo.Value = ClientePersona.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEdad = new SqlParameter();
                ParEdad.ParameterName = "@Edad";
                ParEdad.SqlDbType = SqlDbType.Int;
                ParEdad.Value = ClientePersona.Edad;
                SqlCmd.Parameters.Add(ParEdad);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.Int;
                ParTelefono.Value = ClientePersona.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "Cédula Inválida";

               
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

        //metodo editar 
        public string EditarPersona(DClientePersona ClientePersona)
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
                SqlCmd.CommandText = "SP_EditarPersona";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@Cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 20;
                ParCedula.Value = ClientePersona.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = ClientePersona.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 10;
                ParSexo.Value = ClientePersona.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEdad = new SqlParameter();
                ParEdad.ParameterName = "@Edad";
                ParEdad.SqlDbType = SqlDbType.Int;
                ParEdad.Value = ClientePersona.Edad;
                SqlCmd.Parameters.Add(ParEdad);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.Int;
                ParTelefono.Value = ClientePersona.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó el cliente";

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

        public string EditarCliente(DClientePersona ClientePersona)
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
                SqlCmd.CommandText = "SP_EditarCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@Cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 20;
                ParCedula.Value = ClientePersona.Cedula;
                SqlCmd.Parameters.Add(ParCedula);


                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo_Electronico";
                ParCorreo.SqlDbType = SqlDbType.NVarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = ClientePersona.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el cliente";

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

        public string Eliminar(DClientePersona ClientePersona)
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
                SqlCmd.CommandText = "SP_EliminarClientePersona";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@Cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 20;
                ParCedula.Value = ClientePersona.Cedula;
                SqlCmd.Parameters.Add(ParCedula);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "No se elimino el cliente";

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
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarClientePersona";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch(Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //metodo para mostrar los acompañantes
        /*public DataTable MostrarAcompañante(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("Acompañantes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_Mostrar_Acompañante_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
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

        //metodo buscar cedula
        public DataTable BuscarCedula(DClientePersona ClientePersona)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarClientePersona_Cedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = ClientePersona.TextoBuscar;
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

        //buscar cliente por nombre
        public DataTable BuscarNombre(DClientePersona ClientePersona)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarClientePersona_Nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = ClientePersona.TextoBuscar;
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
