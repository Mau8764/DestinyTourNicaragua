using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class LHoteles
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idserviciohotel,string nombrehotel,DateTime fechaingreso,int edadpersona,DateTime fechasalida,int cantidadpersonas,
            DateTime fechareservacion,string tipohabitacion)
        {
            DHoteles Obj = new DHoteles();
            Obj.IdServicioHotel = idserviciohotel;
            Obj.NombreHotel = nombrehotel;
            Obj.FechaIngreso = fechaingreso;
            Obj.EdadPersona = edadpersona;
            Obj.FechaSalida = fechasalida;
            Obj.CantidadPersona = cantidadpersonas;
            Obj.FechaReservacion = fechareservacion;
            Obj.TipoHabitacion = tipohabitacion;
            return Obj.Insertar(Obj);
        }


        //metodo editar que llame al metodo editar tour de la capa datos
        public static string Editar(int idserviciohotel, string nombrehotel,DateTime fechaingreso, int edadpersona, DateTime fechasalida, int cantidadpersonas,
            DateTime fechareservacion, string tipohabitacion)
        {
            DHoteles Obj = new DHoteles();
            Obj.IdServicioHotel = idserviciohotel;
            Obj.NombreHotel = nombrehotel;
            Obj.FechaIngreso = fechaingreso;
            Obj.EdadPersona = edadpersona;
            Obj.FechaSalida = fechasalida;
            Obj.CantidadPersona = cantidadpersonas;
            Obj.FechaReservacion = fechareservacion;
            Obj.TipoHabitacion = tipohabitacion;
            return Obj.Editar(Obj);
        }

        //metodo eliminar que llame al metodo eliminar tour de la capa datos
        public static string Eliminar(int idreservacion)
        {
            DHoteles Obj = new DHoteles();
            Obj.IdReservacion = idreservacion;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar que llame al metodo mostrar tour de la capa datos
        public static DataTable Mostrar()
        {
            return new DHoteles().Mostrar();
        }

        //metodo Buscar boleto por cedula
        public static DataTable BuscarCedula(string textobuscar)
        {
            DHoteles Obj = new DHoteles();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCedula(Obj);
        }

        //metodo buscar boleto por nombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DHoteles Obj = new DHoteles();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //metodo buscar boleto por fecha
        public static DataTable BuscarFecha(DateTime textobuscar)
        {
            DHoteles Obj = new DHoteles();
            Obj.FechaBuscar = textobuscar;
            return Obj.BuscarFecha(Obj);
        }
    }
}
