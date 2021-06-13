using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DPaqueteNacional
    {
        private int _IdPaqueteNacional;
        private int _IdReservacion;
        private string _NombrePaquete;
        private string _HoraSalida;
        private string _Destino;
        private decimal _Precio;
        private int _CantidadDias;
        private int _CantidadNoches;
        private string _Descripcion;
        private DateTime _FechaPaquete;
        private string _TextoBuscar;
        private DateTime _FechaBuscar;
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

        public string NombrePaquete
        {
            get
            {
                return _NombrePaquete;
            }

            set
            {
                _NombrePaquete = value;
            }
        }

        public string HoraSalida
        {
            get
            {
                return _HoraSalida;
            }

            set
            {
                _HoraSalida = value;
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

        public decimal Precio
        {
            get
            {
                return _Precio;
            }

            set
            {
                _Precio = value;
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

        public int CantidadNoches
        {
            get
            {
                return _CantidadNoches;
            }

            set
            {
                _CantidadNoches = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public DateTime FechaPaquete
        {
            get
            {
                return _FechaPaquete;
            }

            set
            {
                _FechaPaquete = value;
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

        public DPaqueteNacional()
        {

        }

        public DPaqueteNacional(int idpaquetenacional,string nombrepaquete,string horasalida,string destino,decimal precio,
            int cantidaddias,int cantidadnoches,string descripcion,DateTime fechapaquete)
        {
            this.IdPaqueteNacional = idpaquetenacional;
            this.NombrePaquete = nombrepaquete;
            this.HoraSalida = horasalida;
            this.Destino = destino;
            this.Precio = precio;
            this.CantidadDias = cantidaddias;
            this.CantidadNoches = cantidadnoches;
            this.Descripcion = descripcion;
            this.FechaPaquete = fechapaquete;
        }

        //metodo insertar
        public string Insertar(DPaqueteNacional PaqueteNacional)
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
                SqlCmd.CommandText = "SP_InsertarPaqueteNacional";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //4. Agregar los parámetros al comando
                //Establecemos los valores para el parámetro
                //@idtour del Procedimiento Almacenado
                SqlParameter ParIdPaqueteNacional = new SqlParameter();
                ParIdPaqueteNacional.ParameterName = "@idpaquetenacional";
                ParIdPaqueteNacional.SqlDbType = SqlDbType.Int;
                ParIdPaqueteNacional.Value = PaqueteNacional.IdPaqueteNacional;
                SqlCmd.Parameters.Add(ParIdPaqueteNacional);
                //Agregamos el parámetro al comando


                SqlParameter ParNombrePaquete = new SqlParameter();
                ParNombrePaquete.ParameterName = "@nombrepaquete";
                ParNombrePaquete.SqlDbType = SqlDbType.NVarChar;
                ParNombrePaquete.Size = 50;
                ParNombrePaquete.Value = PaqueteNacional.NombrePaquete;
                SqlCmd.Parameters.Add(ParNombrePaquete);

                SqlParameter ParHoraSalida = new SqlParameter();
                ParHoraSalida.ParameterName = "@horasalida";
                ParHoraSalida.SqlDbType = SqlDbType.VarChar;
                ParHoraSalida.Size = 5;
                ParHoraSalida.Value = PaqueteNacional.HoraSalida;
                SqlCmd.Parameters.Add(ParHoraSalida);

                SqlParameter ParDestino = new SqlParameter();
                ParDestino.ParameterName = "@destino";
                ParDestino.SqlDbType = SqlDbType.NVarChar;
                ParDestino.Size = 50;
                ParDestino.Value = PaqueteNacional.Destino;
                SqlCmd.Parameters.Add(ParDestino);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.Money;
                ParPrecio.Value = PaqueteNacional.Precio;
                SqlCmd.Parameters.Add(ParPrecio);

                SqlParameter ParCantidadDias = new SqlParameter();
                ParCantidadDias.ParameterName = "@cantidaddias";
                ParCantidadDias.SqlDbType = SqlDbType.Int;
                ParCantidadDias.Value = PaqueteNacional.CantidadDias;
                SqlCmd.Parameters.Add(ParCantidadDias);

                SqlParameter ParCantidadNoches = new SqlParameter();
                ParCantidadNoches.ParameterName = "@cantidadnoches";
                ParCantidadNoches.SqlDbType = SqlDbType.Int;
                ParCantidadNoches.Value = PaqueteNacional.CantidadNoches;
                SqlCmd.Parameters.Add(ParCantidadNoches);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NVarChar;
                ParDescripcion.Size = 1000;
                ParDescripcion.Value = PaqueteNacional.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParFechaPaquete = new SqlParameter();
                ParFechaPaquete.ParameterName = "@fechapaquete";
                ParFechaPaquete.SqlDbType = SqlDbType.Date;
                ParFechaPaquete.Value = PaqueteNacional.FechaPaquete;
                SqlCmd.Parameters.Add(ParFechaPaquete);
                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 2 ? "OK" : "No se ingreso el Paquete Nacional";

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

        public string Editar(DPaqueteNacional PaqueteNacional)
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
                SqlCmd.CommandText = "SP_EditarPaqueteNacional";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPaqueteNacional = new SqlParameter();
                ParIdPaqueteNacional.ParameterName = "@idpaquetenacional";
                ParIdPaqueteNacional.SqlDbType = SqlDbType.Int;
                ParIdPaqueteNacional.Value = PaqueteNacional.IdPaqueteNacional;
                SqlCmd.Parameters.Add(ParIdPaqueteNacional);
                //Agregamos el parámetro al comando


                SqlParameter ParNombrePaquete = new SqlParameter();
                ParNombrePaquete.ParameterName = "@nombrepaquete";
                ParNombrePaquete.SqlDbType = SqlDbType.NVarChar;
                ParNombrePaquete.Size = 50;
                ParNombrePaquete.Value = PaqueteNacional.NombrePaquete;
                SqlCmd.Parameters.Add(ParNombrePaquete);

                SqlParameter ParHoraSalida = new SqlParameter();
                ParHoraSalida.ParameterName = "@horasalida";
                ParHoraSalida.SqlDbType = SqlDbType.VarChar;
                ParHoraSalida.Size = 5;
                ParHoraSalida.Value = PaqueteNacional.HoraSalida;
                SqlCmd.Parameters.Add(ParHoraSalida);

                SqlParameter ParDestino = new SqlParameter();
                ParDestino.ParameterName = "@destino";
                ParDestino.SqlDbType = SqlDbType.NVarChar;
                ParDestino.Size = 50;
                ParDestino.Value = PaqueteNacional.Destino;
                SqlCmd.Parameters.Add(ParDestino);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.Money;
                ParPrecio.Value = PaqueteNacional.Precio;
                SqlCmd.Parameters.Add(ParPrecio);

                SqlParameter ParCantidadDias = new SqlParameter();
                ParCantidadDias.ParameterName = "@cantidaddias";
                ParCantidadDias.SqlDbType = SqlDbType.Int;
                ParCantidadDias.Value = PaqueteNacional.CantidadDias;
                SqlCmd.Parameters.Add(ParCantidadDias);

                SqlParameter ParCantidadNoches = new SqlParameter();
                ParCantidadNoches.ParameterName = "@cantidadnoches";
                ParCantidadNoches.SqlDbType = SqlDbType.Int;
                ParCantidadNoches.Value = PaqueteNacional.CantidadNoches;
                SqlCmd.Parameters.Add(ParCantidadNoches);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NVarChar;
                ParDescripcion.Size = 1000;
                ParDescripcion.Value = PaqueteNacional.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParFechaPaquete = new SqlParameter();
                ParFechaPaquete.ParameterName = "@fechapaquete";
                ParFechaPaquete.SqlDbType = SqlDbType.Date;
                ParFechaPaquete.Value = PaqueteNacional.FechaPaquete;
                SqlCmd.Parameters.Add(ParFechaPaquete);

                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el Paquete Nacional";

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

        public string Eliminar(DPaqueteNacional PaqueteNacional)
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
                SqlCmd.CommandText = "SP_EliminarPaqueteNacional";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPaqueteNacional = new SqlParameter();
                ParIdPaqueteNacional.ParameterName = "@idreservacion";
                ParIdPaqueteNacional.SqlDbType = SqlDbType.Int;
                ParIdPaqueteNacional.Value = PaqueteNacional.IdReservacion;
                SqlCmd.Parameters.Add(ParIdPaqueteNacional);


                //ejecucion
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se anuló el Paquete Nacional";

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
            DataTable DtResultado = new DataTable("Paquete Nacional");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SP_MostrarPaqueteNacional";
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
    }
}
