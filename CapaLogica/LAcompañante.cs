using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
   public class LAcompañante
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(int idacompañante,string nombreacompañante,string cedulaacompañante)
        {
            DAcompañante Obj = new DAcompañante();
            Obj.IdAcompañante = idacompañante;
            Obj.NombreAcompañante = nombreacompañante;
            Obj.CedulaAcompañante = cedulaacompañante;
       
            return Obj.Insertar(Obj);
        }


        //metodo editar que llame al metodo editar acompañante de la capa datos
        public static string Editar(int idacompañante, string nombreacompañante, string cedulaacompañante)
        {
            DAcompañante Obj = new DAcompañante();
            Obj.IdAcompañante = idacompañante;
            Obj.NombreAcompañante = nombreacompañante;
            Obj.CedulaAcompañante = cedulaacompañante;
            return Obj.Editar(Obj);
        }

        //metodo eliminar que llame al metodo eliminar acompañante de la capa datos
        public static string Eliminar(int idacompañante)
        {
            DAcompañante Obj = new DAcompañante();
            Obj.IdAcompañante = idacompañante;
            return Obj.Eliminar(Obj);
        }

        //metodo Buscar tour por nombre
        /*public static DataTable MostrarAcompañanteCedulaCliente(string textobuscar)
        {
            DAcompañante Obj = new DAcompañante();
            Obj.TextoBuscar = textobuscar;
            return Obj.MostrarAcompañanteCedulaCliente(Obj);
        }*/

        public static DataTable Mostrar()
        {
            return new DAcompañante().Mostrar();
        }

        //metodo Buscar por cedula
        public static DataTable BuscarCedula(string textobuscar)
        {
            DAcompañante Obj = new DAcompañante();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCedula(Obj);
        }

        //metodo buscar por nombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DAcompañante Obj = new DAcompañante();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
