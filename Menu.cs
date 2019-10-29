using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public class Menu : Platillo, IMenu
    {
        Platillo p = new Platillo();
       
         public void CrearMenu(List<Platillo> platillos)
        {
            int c = 0;

            p.Id = c + 1;
            Console.WriteLine("Ingrese el nombre del platillo: ");
            p.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la descripcion del platillo: ");
            p.Descripcion = Console.ReadLine();
            AsignarCategoria(p);
            platillos.Add(p);
        }
       
       public void DetallePlatillo()
        {
           
        }

         public void ListaMenu(List<Platillo> platillos)
        { 
           foreach(var item in platillos)
            {
                Console.WriteLine(item.Id + ".- "+ item.Nombre);
            }
        }


        private void AsignarCategoria(Platillo p)
        {
            Console.WriteLine("Seleccione la categoria del platillo");
            Console.WriteLine("1.- Desayuno\n2.- Comida\n3.-Cena.\n");
            if (Console.ReadLine() == "desayuno")
            {
                p.Categoria = "desayuno";
            }
            else if (Console.ReadLine() == "comida")
            {
                p.Categoria = "comida";
            }
            else if (Console.ReadLine() == "cena")
            {
                p.Categoria = "cena";
            }
        }
    }
}
