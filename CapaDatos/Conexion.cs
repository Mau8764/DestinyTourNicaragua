using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class Conexion
    {
        //public static string Cn = "Data Source=tcp:DESKTOP-5ID2OGO,1433; Initial Catalog=Destiny;User Id=destiny;Password=tournic";
        //public static string Cn = @"Server=tcp:DESKTOP-5ID2OGO\MSSQLSERVER,1433;DataBase=Destiny; User Id=destiny;Password=tournic";
        public static string Cn = "data source =(local); initial catalog = Destiny; user id = User; password = destiny";
       // public static string Cn = " Data Source = (local); Initial Catalog = Destiny; Integrated Security = True";

      /*  public Conexion()
        {
            Cn = @"Server=tcp:DESKTOP-5ID2OGO\MSSQLSERVER,1433;DataBase=Destiny;User Id=User;Password=destiny";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Cn);
        }*/
    }
}
