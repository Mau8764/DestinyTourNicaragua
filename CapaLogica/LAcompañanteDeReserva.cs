using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
    public class LAcompañanteDeReserva
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idreservacion, int idacompañante)
        {
            DAcompañaneDeReserva Obj = new DAcompañaneDeReserva();

            Obj.IdReservacion = idreservacion;
            Obj.IdAcompañante = idacompañante;

            return Obj.Insertar(Obj);
        }
    }
}
