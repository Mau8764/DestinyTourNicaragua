using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
namespace CapaLogica
{
    public class LReservacion
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idreservacion,DateTime fechareservacion,decimal pago,string cedula)
        {
            DReservacion Obj = new DReservacion();
            Obj.IdReservacion = idreservacion;
            Obj.FechaReservacion = fechareservacion;
            Obj.Pago = pago;
            Obj.Cedula = cedula;

            return Obj.Insertar(Obj);
        }

        public static string InsertarPendiente(int idreservacion, DateTime fechareservacion, decimal pago,decimal pendiente, string cedula)
        {
            DReservacion Obj = new DReservacion();
            Obj.IdReservacion = idreservacion;
            Obj.FechaReservacion = fechareservacion;
            Obj.Pago = pago;
            Obj.Pendiente = pendiente;
            Obj.Cedula = cedula;

            return Obj.Insertar(Obj);
        }

        //metodo editar que llame al metodo editar reservacion de la capa datos
        public static string Editar(int idreservacion, DateTime fechareservacion, decimal pago, string cedula)
        {
            DReservacion Obj = new DReservacion();
            Obj.IdReservacion = idreservacion;
            Obj.FechaReservacion = fechareservacion;
            Obj.Pago = pago;
            Obj.Cedula = cedula;
            return Obj.Editar(Obj);
        }

        public static string EditarPendiente(int idreservacion, DateTime fechareservacion, decimal pago,decimal pendiente, string cedula)
        {
            DReservacion Obj = new DReservacion();
            Obj.IdReservacion = idreservacion;
            Obj.FechaReservacion = fechareservacion;
            Obj.Pago = pago;
            Obj.Pendiente = pendiente;
            Obj.Cedula = cedula;
            return Obj.Editar(Obj);
        }

        //metodo eliminar que llame al metodo eliminar reservacion de la capa datos
        public static string Eliminar(int idreservacion)
        {
            DReservacion Obj = new DReservacion();
            Obj.IdReservacion = idreservacion;
            return Obj.Eliminar(Obj);
        }

        //metodo Buscar reservacion por cedula cliente
        public static DataTable MostrarReservacionCedulaCliente(string textobuscar)
        {
            DReservacion Obj = new DReservacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.MostrarReservacionCedulaCliente(Obj);
        }

        //Mostrar todas la reservaciones
        public static DataTable MostrarReservaciones()
        {
            return new DReservacion().MostrarReservaciones();
        }

        public static DataTable MostrarReservacionesPaqueteNacional()
        {
            return new DReservacion().MostrarReservacionesPaqueteNacional();
        }

        //metodo Buscar por cedula
        public static DataTable BuscarCedula(string textobuscar)
        {
            DReservacion Obj = new DReservacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCedula(Obj);
        }

        //metodo buscar por nombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DReservacion Obj = new DReservacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //metodo buscar por fecha
        public static DataTable BuscarFecha(DateTime textobuscar)
        {
            DReservacion Obj = new DReservacion();
            Obj.FechaBuscar = textobuscar;
            return Obj.BuscarFecha(Obj);
        }

        //metodo Buscar por tour
        public static DataTable MostrarReservacionPorTour(string textobuscar,DateTime fecha)
        {
            DReservacion Obj = new DReservacion();
            Obj.TextoBuscar = textobuscar;
            Obj.FechaBuscar = fecha;
            return Obj.MostrarReservacionTour(Obj);
        }
    }
}
