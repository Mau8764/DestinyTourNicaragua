using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class LRentaVehiculo
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idrentavehiculo, int cantidaddias, string tipocarro, DateTime fecharenta, DateTime fechadevolucion, string placa)
        {
            DRentaVehiculo Obj = new DRentaVehiculo();
            Obj.IdRentaVehiculo = idrentavehiculo;
            Obj.CantidadDias = cantidaddias;
            Obj.TipoCarro = tipocarro;
            Obj.FechaRenta = fecharenta;
            Obj.FechaDevolucion = fechadevolucion;
            Obj.Placa = placa;
            return Obj.Insertar(Obj);
        }

        //metodo editar que llame al metodo editar tour de la capa datos
        public static string Editar(int idrentavehiculo, int cantidaddias, string tipocarro, DateTime fecharenta, DateTime fechadevolucion, string placa)
        {
            DRentaVehiculo Obj = new DRentaVehiculo();
            Obj.IdRentaVehiculo = idrentavehiculo;
            Obj.CantidadDias = cantidaddias;
            Obj.TipoCarro = tipocarro;
            Obj.FechaRenta = fecharenta;
            Obj.FechaDevolucion = fechadevolucion;
            Obj.Placa = placa;
            return Obj.Editar(Obj);
        }


        //metodo eliminar que llame al metodo eliminar tour de la capa datos
        public static string Eliminar(int idreservacion)
        {
            DRentaVehiculo Obj = new DRentaVehiculo();
            Obj.Idreservacion = idreservacion; ;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar que llame al metodo mostrar tour de la capa datos
        public static DataTable Mostrar()
        {
            return new DRentaVehiculo().Mostrar();
        }

        //metodo Buscar por cedula
        public static DataTable BuscarCedula(string textobuscar)
        {
            DRentaVehiculo Obj = new DRentaVehiculo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCedula(Obj);
        }

        //metodo buscar por nombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DRentaVehiculo Obj = new DRentaVehiculo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //metodo buscar por fecha
        public static DataTable BuscarFecha(DateTime textobuscar)
        {
            DRentaVehiculo Obj = new DRentaVehiculo();
            Obj.FechaBuscar = textobuscar;
            return Obj.BuscarFecha(Obj);
        }
    }
}
