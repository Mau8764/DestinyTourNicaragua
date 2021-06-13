using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class LFormaPago
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idformapago, string tipopago)
        {
            DFormaDePago Obj = new DFormaDePago();
            Obj.IdFormaPago = idformapago;
            Obj.TipoPago = tipopago;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int idformapago, string tipopago)
        {
            DFormaDePago Obj = new DFormaDePago();
            Obj.IdFormaPago = idformapago;
            Obj.TipoPago = tipopago;
            return Obj.Editar(Obj);
        }


        public static string Eliminar(int idformapago)
        {
            DFormaDePago Obj = new DFormaDePago();
            Obj.IdFormaPago = idformapago;
            return Obj.Eliminar(Obj);
        }


    }
}
