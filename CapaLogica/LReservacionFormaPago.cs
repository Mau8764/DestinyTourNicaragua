using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
namespace CapaLogica
{
    public class LReservacionFormaPago
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idreservacion, int idformapago)
        {
            DReservacionFormaPago Obj = new DReservacionFormaPago();

            Obj.IdReservacion = idreservacion;
            Obj.IdFormaPago = idformapago;

            return Obj.Insertar(Obj);
        }
    }
}
