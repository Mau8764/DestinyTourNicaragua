using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
    public class LServicioDeReservacion
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idreservacion,DateTime fechaservicio ,int idservicio)
        {
            DServicioDeReservacion Obj = new DServicioDeReservacion();

            Obj.IdReservacion = idreservacion;
            Obj.FechaServicio = fechaservicio;
            Obj.IdServicio = idservicio;

            return Obj.Insertar(Obj);
        }
    }
}
