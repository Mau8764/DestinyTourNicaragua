using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaLogica
{
    public class LBoletosAereos
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idboleto,string destino,DateTime fechaida,decimal tarifa,DateTime fecharegreso,string lineaaerea,string cabinaavion)
        {
            DBoletosAereos Obj = new DBoletosAereos();
            Obj.IdBoleto = idboleto;
            Obj.Destino = destino;
            Obj.FechaIda = fechaida;
            Obj.Tarifa = tarifa;
            Obj.FechaRegreso = fecharegreso;
            Obj.LineaAerea = lineaaerea;
            Obj.CabinaAvion = cabinaavion;
            return Obj.Insertar(Obj);
        }

        //metodo editar que llame al metodo editar tour de la capa datos
        public static string Editar(int idboleto, string destino, DateTime fechaida, decimal tarifa, DateTime fecharegreso, string lineaaerea, string cabinaavion)
        {
            DBoletosAereos Obj = new DBoletosAereos();
            Obj.IdBoleto = idboleto;
            Obj.Destino = destino;
            Obj.FechaIda = fechaida;
            Obj.Tarifa = tarifa;
            Obj.FechaRegreso = fecharegreso;
            Obj.LineaAerea = lineaaerea;
            Obj.CabinaAvion = cabinaavion;
            return Obj.Editar(Obj);
        }

        //metodo eliminar que llame al metodo eliminar tour de la capa datos
        public static string Eliminar(int idreservacion)
        {
            DBoletosAereos Obj = new DBoletosAereos();
            Obj.Idreservacion = idreservacion ;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar que llame al metodo mostrar tour de la capa datos
        public static DataTable Mostrar()
        {
            return new DBoletosAereos().Mostrar();
        }

        //metodo Buscar boleto por cedula
        public static DataTable BuscarCedula(string textobuscar)
        {
            DBoletosAereos Obj = new DBoletosAereos();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCedula(Obj);
        }

        //metodo buscar boleto por nombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DBoletosAereos Obj = new DBoletosAereos();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //metodo buscar boleto por fecha
        public static DataTable BuscarFecha(DateTime textobuscar)
        {
            DBoletosAereos Obj = new DBoletosAereos();
            Obj.FechaBuscar = textobuscar;
            return Obj.BuscarFecha(Obj);
        }
    }
}
