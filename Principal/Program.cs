using Datos;
using Datos.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.AnyadeCategoria();
            //program.Comprobar();
            //program.Modificar();
            //program.Comprobar();
            //program.Eliminar();
            //program.Comprobar();
            program.EliminarTodosLosRegistrosQue();
            program.Comprobar();
        }

        //INSERT O CREATE
        private void AnyadeCategoria()
        {
            Class1 class1 = new Class1();
            //IList<Categoria> categorias = class1.DevuelveCategorias();

            Categoria categoria = new Categoria();
            //categoria.CategoryID = 1;
            categoria.CategoryName = "Chisme";
            categoria.Description = "Producto de escaso valor";

            //categorias.Add(categoria);

            bool ok = false;
            ok = class1.GuardarRegistro(categoria);

            Console.WriteLine("El resultado de la inserción ha sido: " + ok);

            Console.ReadLine();
        }

        //SELECT O READ
        private void Comprobar()
        {
            Class1 class1 = new Class1();
            IList<Categoria> categorias = class1.DevuelveCategorias();
            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine(categoria.CategoryID + " " + categoria.CategoryName);
            }

            Console.ReadLine();
        }

        //UPDATE
        private void Modificar()
        {
            Class1 class1 = new Class1();
            IList<Categoria> categorias = class1.DevuelveCategorias();


            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine(categoria.CategoryID + " " + categoria.CategoryName);
            }

            Console.WriteLine("Dime el id del registro a modificar");
            string texto = Console.ReadLine();
            int id = 0;
            if (int.TryParse(texto, out id) == true)
            {
                id = int.Parse(texto);
            }
            Console.WriteLine("Ahora, Dime el nuevo nombre");

            texto = Console.ReadLine();

            bool ok = false;
            ok = class1.GuardarRegistro(id, texto);

            Console.WriteLine("El resultado de la modificación ha sido: " + ok);

            Console.ReadLine();
        }

        //DELETE
        private void Eliminar()
        {
            Class1 class1 = new Class1();
            IList<Categoria> categorias = class1.DevuelveCategorias();


            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine(categoria.CategoryID + " " + categoria.CategoryName);
            }

            Console.WriteLine("Dime el id del registro a eliminar");
            string texto = Console.ReadLine();
            int id = 0;
            if (int.TryParse(texto, out id) == true)
            {
                id = int.Parse(texto);
            }
            //Console.WriteLine("Ahora, Dime el nuevo nombre");

            //texto = Console.ReadLine();

            bool ok = false;
            ok = class1.GuardarRegistro(id);

            Console.WriteLine("El resultado de la eliminación ha sido: " + ok);

            Console.ReadLine();
        }

        //DELETE muchos registros
        private void EliminarTodosLosRegistrosQue()
        {
            Class1 class1 = new Class1();
            IList<Categoria> categorias = class1.DevuelveCategorias();

            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine(categoria.CategoryID + " " + categoria.CategoryName);
            }

            Console.WriteLine("Dime el NOMBRE del registro a eliminar");
            string texto = Console.ReadLine();

            //Elimina todos los registros que tengan ese nombre

            bool ok = false;
            ok = class1.GuardarRegistro(texto);

            Console.WriteLine("El resultado de la eliminación ha sido: " + ok);

            Console.ReadLine();
        }
    }
}
