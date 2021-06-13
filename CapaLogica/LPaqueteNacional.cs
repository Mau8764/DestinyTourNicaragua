using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
    public class LPaqueteNacional
    {

        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idpaquetnacional,string nombrepaquete,string horasalida,string destino,decimal precio,int cantidaddias,
            int cantidadnoches,string descripcion,DateTime fechapaquete)
        {
            DPaqueteNacional Obj = new DPaqueteNacional();
            Obj.IdPaqueteNacional = idpaquetnacional;
            Obj.NombrePaquete = nombrepaquete;
            Obj.HoraSalida = horasalida;
            Obj.Destino = destino;
            Obj.Precio = precio;
            Obj.CantidadDias = cantidaddias;
            Obj.CantidadNoches = cantidadnoches;
            Obj.Descripcion = descripcion;
            Obj.FechaPaquete = fechapaquete;
            return Obj.Insertar(Obj);
        }
        //metodo editar que llame al metodo editar tour de la capa datos
        public static string Editar(int idpaquetnacional, string nombrepaquete, string horasalida, string destino, decimal precio, int cantidaddias,
            int cantidadnoches, string descripcion, DateTime fechapaquete)
        {
            DPaqueteNacional Obj = new DPaqueteNacional();
            Obj.IdPaqueteNacional = idpaquetnacional;
            Obj.NombrePaquete = nombrepaquete;
            Obj.HoraSalida = horasalida;
            Obj.Destino = destino;
            Obj.Precio = precio;
            Obj.CantidadDias = cantidaddias;
            Obj.CantidadNoches = cantidadnoches;
            Obj.Descripcion = descripcion;
            Obj.FechaPaquete = fechapaquete;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int idreservacion)
        {
            DPaqueteNacional Obj = new DPaqueteNacional();
            Obj.IdReservacion = idreservacion; ;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DPaqueteNacional().Mostrar();
        }
    }
}
