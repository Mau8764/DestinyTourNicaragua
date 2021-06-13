using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
    public class LSeguroViaje
    {
        public static string Insertar(int idseguroviaje,string pasaporte,string destino,DateTime fechaida,DateTime fecharegreso,
            string contactoemergencia,string telefonoemergencia)
        {
            DSeguroViaje Obj = new DSeguroViaje();
            Obj.IdSeguroViaje = idseguroviaje;
            Obj.Pasaporte = pasaporte;
            Obj.Destino = destino;
            Obj.FechaIda = fechaida;
            Obj.FechaRegreso = fecharegreso;
            Obj.ContactoEmergencia =contactoemergencia;
            Obj.TelefonoEmergencia = telefonoemergencia;
            return Obj.Insertar(Obj);
        }

        //metodo editar que llame al metodo editar tour de la capa datos
        public static string Editar(int idseguroviaje, string pasaporte, string destino, DateTime fechaida, DateTime fecharegreso,
            string contactoemergencia, string telefonoemergencia)
        {
            DSeguroViaje Obj = new DSeguroViaje();
            Obj.IdSeguroViaje = idseguroviaje;
            Obj.Pasaporte = pasaporte;
            Obj.Destino = destino;
            Obj.FechaIda = fechaida;
            Obj.FechaRegreso = fecharegreso;
            Obj.ContactoEmergencia = contactoemergencia;
            Obj.TelefonoEmergencia = telefonoemergencia;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int idreservacion)
        {
            DSeguroViaje Obj = new DSeguroViaje();
            Obj.IdReservacion = idreservacion;
            return Obj.Eliminar(Obj);
        }
        //metodo mostrar que llame al metodo mostrar tour de la capa datos
        public static DataTable Mostrar()
        {
            return new DSeguroViaje().Mostrar();
        }

        //metodo Buscar por cedula
        public static DataTable BuscarCedula(string textobuscar)
        {
            DSeguroViaje Obj = new DSeguroViaje();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCedula(Obj);
        }

        //metodo Buscar por pasaporte
        public static DataTable BuscarPasaporte(string textobuscar)
        {
            DSeguroViaje Obj = new DSeguroViaje();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarPasaporte(Obj);
        }

        //metodo buscar por nombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DSeguroViaje Obj = new DSeguroViaje();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //metodo buscar por fecha
        public static DataTable BuscarFecha(DateTime textobuscar)
        {
            DSeguroViaje Obj = new DSeguroViaje();
            Obj.FechaBuscar = textobuscar;
            return Obj.BuscarFecha(Obj);
        }

    }
}
