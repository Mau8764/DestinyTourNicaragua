using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
    public class LChofer
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idchofer,string cedulachofer, string nombrechofer,int cantidadcoster,int capacidad)
        {
            DChoferCoster Obj = new DChoferCoster();
            Obj.IdChofer = idchofer;
            Obj.CedulaChofer = cedulachofer;
            Obj.NombreChofer = nombrechofer;
            Obj.CantidaCoster = cantidadcoster;
            Obj.CapacidadCoster = capacidad;

            return Obj.Insertar(Obj);
        }

        //metodo editar que llame al metodo editar chofer de la capa datos
        public static string Editar(int idchofer, string cedulachofer, string nombrechofer, int cantidadcoster, int capacidad)
        {
            DChoferCoster Obj = new DChoferCoster();
            Obj.IdChofer = idchofer;
            Obj.CedulaChofer = cedulachofer;
            Obj.NombreChofer = nombrechofer;
            Obj.CantidaCoster = cantidadcoster;
            Obj.CapacidadCoster = capacidad;
            return Obj.EditarChofer(Obj);
        }

        //metodo eliminar que llame al metodo eliminar chofer de la capa datos
        public static string Eliminar(int idchofer)
        {
            DChoferCoster Obj = new DChoferCoster();
            Obj.IdChofer = idchofer;
            return Obj.Eliminar(Obj);
        }

        //metodo Buscar tour por nombre
        public static DataTable MostrarChoferReservacion(string textobuscar)
        {
            DChoferCoster Obj = new DChoferCoster();
            Obj.TextoBuscar = textobuscar;
            return Obj.MostrarChoferReservacion(Obj);
        }
    }
}
