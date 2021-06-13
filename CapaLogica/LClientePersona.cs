using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
    public class LClientePersona
    {
        //metodos para insertar que llame al metodo insertar de la capa datos
        public static string Insertar(string cedula,string correo,string nombre,string sexo,
            int edad,int telefono)
        {
            DClientePersona Obj = new DClientePersona();
            Obj.Cedula = cedula;
            Obj.Correo = correo;
            Obj.Nombre = nombre;
            Obj.Sexo = sexo;
            Obj.Edad = edad;
            Obj.Telefono = telefono;
            
            return Obj.Insertar(Obj);
        }

        //metodo editar que llame al metodo editar cliente de la capa datos
        public static string EditarCliente(string cedula, string correo)
        {
            DClientePersona Obj = new DClientePersona();
            Obj.Cedula = cedula;
            Obj.Correo = correo;
            return Obj.EditarCliente(Obj);
        }

        //metodo editar que llame al metodo editar cliente de la capa datos
        public static string EditarPersona(string cedula, string nombre, string sexo,
         int edad, int telefono)
        {
            DClientePersona Obj = new DClientePersona();
            Obj.Cedula = cedula;
            Obj.Nombre = nombre;
            Obj.Sexo = sexo;
            Obj.Edad = edad;
            Obj.Telefono = telefono;
            return Obj.EditarPersona(Obj);
        }

        //metodo eliminar que llame al metodo eliminar cliente de la capa datos
        public static string Eliminar(string cedula)
        {
            DClientePersona Obj = new DClientePersona();
            Obj.Cedula = cedula;
            return Obj.Eliminar(Obj);
        }

        //metodo mostrar que llame al metodo mostrar clientes de la capa datos
        public static DataTable Mostrar()
        {
            return new DClientePersona().Mostrar();
        }

        //metodo Buscar cliente por cedula
        public static DataTable BuscarCedula(string textobuscar)
        {
            DClientePersona Obj = new DClientePersona();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCedula(Obj);
        }

        //metodo buscar cliente por nombre
        public static DataTable BuscarNombre(string textobuscar)
        {
            DClientePersona Obj = new DClientePersona();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
