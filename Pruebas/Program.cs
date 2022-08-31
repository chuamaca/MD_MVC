using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioGenerico.Repositorio.Excepcion += Repositorio_Excepcion;
            var datos =
            RepositorioGenerico.Repositorio.QuerySQL("Select * From Persona.Persona_Tipo", 
                @"Data Source = .\sqlexpress;Initial Catalog = MD_MVC;Integrated Security = True;");

            Modelos.MD_MVCEntities contexto = new Modelos.MD_MVCEntities();
            using (RepositorioGenerico.Repositorio<Modelos.Producto_Tipo> obj = 
                new RepositorioGenerico.Repositorio<Modelos.Producto_Tipo>(contexto))
            {
                obj.Excepcion += Repositorio_Excepcion;
                var datosDeTipos = obj.All();
            }

            Console.WriteLine("Presione <enter> para salir...");
            Console.ReadLine();
        }

        private static void Repositorio_Excepcion(object sender, RepositorioGenerico.ExceptionEvenArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
