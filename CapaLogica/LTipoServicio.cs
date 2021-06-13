using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
    public class LTipoServicio
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idtiposervicio,string nombreservicio,int idpaqueteeuropa,int idseguriviaje,int idpaquetenacional,
            int idrentavehiculo,int idtour,int idserviciohotel,int idboleto)
        {
            DTipoServicio Obj = new DTipoServicio();
            Obj.IdServicio = idtiposervicio;
            Obj.NombreServicio = nombreservicio;
            Obj.IdPaqueteEuropa = idpaqueteeuropa;
            Obj.IdSeguroViaje = idseguriviaje;
            Obj.IdPaqueteNacional = idpaquetenacional;
            Obj.IdRentaVehiculo = idrentavehiculo;
            Obj.IdTour = idtour;
            Obj.IdServicioHotel = idserviciohotel;
            Obj.IdBoleto = idboleto;

            return Obj.Insertar(Obj);
        }

        public static string Eliminar(int idtiposervicio)
        {
            DTipoServicio Obj = new DTipoServicio();
            Obj.IdServicio = idtiposervicio;
            return Obj.Eliminar(Obj);
        }

    }
}
