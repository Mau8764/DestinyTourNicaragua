using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DTourNacional
    {
        private int _IdTour;
        private string _Hora_Salida;
        private string _Hora_Regreso;
        private DateTime _FechaTour;
        private string _NombreTour;
        private string _Tipo_Tour;
        private string _Nombre_Institucion;
        private string _TextoBuscar;
        private DateTime _FechaBuscar;
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

        public string Hora_Salida
        {
            get
            {
                return _Hora_Salida;
            }

            set
            {
                _Hora_Salida = value;
            }
        }

        public string Hora_Regreso
        {
            get
            {
                return _Hora_Regreso;
            }

            set
            {
                _Hora_Regreso = value;
            }
        }

        public DateTime FechaTour
        {
            get
            {
                return _FechaTour;
            }

            set
            {
                _FechaTour = value;
            }
        }

        public string NombreTour
        {
            get
            {
                return _NombreTour;
            }

            set
            {
                _NombreTour = value;
            }
        }

        public string Tipo_Tour
        {
            get
            {
                return _Tipo_Tour;
            }

            set
            {
                _Tipo_Tour = value;
            }
        }

        public string Nombre_Institucion
        {
            get
            {
                return _Nombre_Institucion;
            }

            set
            {
                _Nombre_Institucion = value;
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

        //Constructor vacío
        public DTourNacional()
        {

        }

        //contructor con parametros
        public DTourNacional(int idtour,string hora_salida,string hora_regreso,
            DateTime fecha_tour,string nombre_tour,string tipo_tour,string nombre_institucion,string textobuscar)
        {
            this.IdTour = idtour;
            this.Hora_Salida = Hora_Salida;
            this.Hora_Regreso = hora_regreso;
            this.FechaTour = fecha_tour;
            this.NombreTour = nombre_tour;
            this.Tipo_Tour = tipo_tour;
            this.Nombre_Institucion = nombre_institucion;
            this.TextoBuscar = textobuscar;
        }

        //metodo insertar
            public string Insertar(DTourNacional TourNacional)
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
                    SqlCmd.CommandText = "SP_InsertarTour";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    //4. Agregar los parámetros al comando
                    //Establecemos los valores para el parámetro
                    //@idtour del Procedimiento Almacenado
                    SqlParameter ParIdTour = new SqlParameter();
                    ParIdTour.ParameterName = "@IdTour";
                    ParIdTour.SqlDbType = SqlDbType.Int;
                    ParIdTour.Value = TourNacional.IdTour;
                    SqlCmd.Parameters.Add(ParIdTour);
                    //Agregamos el parámetro al comando


                    SqlParameter ParNombreTour = new SqlParameter();
                    ParNombreTour.ParameterName = "@NombreTour";
                    ParNombreTour.SqlDbType = SqlDbType.VarChar;
                    ParNombreTour.Size = 50;
                    ParNombreTour.Value = TourNacional.NombreTour;
                    SqlCmd.Parameters.Add(ParNombreTour);

                    SqlParameter ParHoraSalida = new SqlParameter();
                    ParHoraSalida.ParameterName = "@Hora_Salida";
                    ParHoraSalida.SqlDbType = SqlDbType.VarChar;
                    ParHoraSalida.Size = 5;
                    ParHoraSalida.Value = TourNacional.Hora_Salida;
                    SqlCmd.Parameters.Add(ParHoraSalida);

                    SqlParameter ParHoraRegreso = new SqlParameter();
                    ParHoraRegreso.ParameterName = "@Hora_Regreso";
                    ParHoraRegreso.SqlDbType = SqlDbType.VarChar;
                    ParHoraSalida.Size = 5;
                    ParHoraRegreso.Value = TourNacional.Hora_Regreso;
                    SqlCmd.Parameters.Add(ParHoraRegreso);

                    SqlParameter ParFechaTour = new SqlParameter();
                    ParFechaTour.ParameterName = "@Fecha_Tour";
                    ParFechaTour.SqlDbType = SqlDbType.Date;
                    ParFechaTour.Value = TourNacional.FechaTour;
                    SqlCmd.Parameters.Add(ParFechaTour);

                    SqlParameter ParTipoTour = new SqlParameter();
                    ParTipoTour.ParameterName = "@Tipo_Tour";
                    ParTipoTour.SqlDbType = SqlDbType.VarChar;
                    ParTipoTour.Size = 8;
                    ParTipoTour.Value = TourNacional.Tipo_Tour;
                    SqlCmd.Parameters.Add(ParTipoTour);

                    SqlParameter ParNombreInstitucion = new SqlParameter();
                    ParNombreInstitucion.ParameterName = "@Nombre_Institucion";
                    ParNombreInstitucion.SqlDbType = SqlDbType.NVarChar;
                    ParNombreInstitucion.Size = 50;
                    ParNombreInstitucion.Value = TourNacional.Nombre_Institucion;
                    SqlCmd.Parameters.Add(ParNombreInstitucion);

                    //ejecucion
                    rpta = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "No se ingreso el Tour Nacional";

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
        public string EditarTour(DTourNacional TourNacional)
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
                SqlCmd.CommandText = "SP_EditarTour";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTour = new SqlParameter();
                ParIdTour.ParameterName = "@Idtour";
                ParIdTour.SqlDbType = SqlDbType.Int;
                ParIdTour.Value = TourNacional.IdTour;
                SqlCmd.Parameters.Add(ParIdTour);


                SqlParameter ParNombreTour = new SqlParameter();
                ParNombreTour.ParameterName = "@NombreTour";
                ParNombreTour.SqlDbType = SqlDbType.VarChar;
                ParNombreTour.Size = 50;
                ParNombreTour.Value = TourNacional.NombreTour;
                SqlCmd.Parameters.Add(ParNombreTour);

                SqlParameter ParHoraSalida = new SqlParameter();
                ParHoraSalida.ParameterName = "@Hora_Salida";
                ParHoraSalida.SqlDbType = SqlDbType.VarChar;
                ParHoraSalida.Size = 6;
                ParHoraSalida.Value = TourNacional.Hora_Salida;
                SqlCmd.Parameters.Add(ParHoraSalida);

                SqlParameter ParHoraRegreso = new SqlParameter();
                ParHoraRegreso.ParameterName = "@Hora_Regreso";
                ParHoraRegreso.SqlDbType = SqlDbType.VarChar;
                ParHoraSalida.Size = 6;
                ParHoraRegreso.Value = TourNacional.Hora_Regreso;
                SqlCmd.Parameters.Add(ParHoraRegreso);

                SqlParameter ParFechaTour = new SqlParameter();
                ParFechaTour.ParameterName = "@Fecha_Tour";
                ParFechaTour.SqlDbType = SqlDbType.Date;
                ParFechaTour.Value = TourNacional.FechaTour;
                SqlCmd.Parameters.Add(ParFechaTour);

                SqlParameter ParTipoTour = new SqlParameter();
                ParTipoTour.ParameterName = "@Tipo_Tour";
                ParTipoTour.SqlDbType = SqlDbType.VarChar;
                ParTipoTour.Size = 8;
                ParTipoTour.Value = TourNacional.Tipo_Tour;
                SqlCmd.Parameters.Add(ParTipoTour);

                SqlParameter ParNombreInstitucion = new SqlParameter();
                ParNombreInstitucion.ParameterName = "@Nombre_Institucion";
                ParNombreInstitucion.SqlDbType = SqlDbType.NVarChar;
                ParNombreInstitucion.Size = 50;
                ParNombreInstitucion.Value = TourNacional.Nombre_Institucion;
                SqlCmd.Parameters.Add(ParNombreInstitucion);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el Tour Nacional";

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

        public string Eliminar(DTourNacional TourNacional)
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
                SqlCmd.CommandText = "SP_EliminarTour";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTour = new SqlParameter();
                ParIdTour.ParameterName = "@idtour";
                ParIdTour.SqlDbType = SqlDbType.Int;
                ParIdTour.Value = TourNacional.IdTour;
                SqlCmd.Parameters.Add(ParIdTour);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el Tour Nacional";

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
            DataTable DtResultado = new DataTable("Tour Nacional");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarTour";
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

        //metodo buscar 
        public DataTable BuscarTour_Nombre(DTourNacional TourNacional)
        {
            DataTable DtResultado = new DataTable("Tour Nacional");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarTour_Nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TourNacional.TextoBuscar;
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
        public DataTable BuscarTour_Fecha(DTourNacional TourNacional)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_BuscarTour_Fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Date;
                ParTextoBuscar.Value = TourNacional.FechaBuscar;
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
