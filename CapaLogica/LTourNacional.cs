using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
    public class LTourNacional
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idtour,string horasalida,string horaregreso,DateTime fechatour,string nombretour,string tipotour,string nombreinstitucion)
        {
            DTourNacional Obj = new DTourNacional();
            Obj.IdTour = idtour;
            Obj.Hora_Salida = horasalida;
            Obj.Hora_Regreso = horaregreso;
            Obj.FechaTour = fechatour;
            Obj.NombreTour = nombretour;
            Obj.Tipo_Tour = tipotour;
            Obj.Nombre_Institucion = nombreinstitucion;
            return Obj.Insertar(Obj);
        }

        //metodo editar que llame al metodo editar tour de la capa datos
        public static string Editar(int idtour,string horasalida, string horaregreso, DateTime fechatour, string nombretour, string tipotour, string nombreinstitucion)
        {
            DTourNacional Obj = new DTourNacional();
            Obj.IdTour = idtour;
            Obj.Hora_Salida = horasalida;
            Obj.Hora_Regreso = horaregreso;
            Obj.FechaTour = fechatour;
            Obj.NombreTour = nombretour;
            Obj.Tipo_Tour = tipotour;
            Obj.Nombre_Institucion = nombreinstitucion;
            return Obj.EditarTour(Obj);
        }

       
        //metodo eliminar que llame al metodo eliminar tour de la capa datos
        public static string Eliminar(int idtour)
        {
            DTourNacional Obj = new DTourNacional() ;
            Obj.IdTour = idtour; ;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar que llame al metodo mostrar tour de la capa datos
        public static DataTable Mostrar()
        {
            return new DTourNacional().Mostrar();
        }

        //metodo Buscar tour por nombre
        public static DataTable BuscarTour_Nombre(string textobuscar)
        {
            DTourNacional Obj = new DTourNacional();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarTour_Nombre(Obj);
        }

        //metodo buscar tour por fecha
        public static DataTable BuscarTour_Fecha(DateTime textobuscar)
        {
            DTourNacional Obj = new DTourNacional();
            Obj.FechaBuscar = textobuscar;
            return Obj.BuscarTour_Fecha(Obj);
        }
    }
}
