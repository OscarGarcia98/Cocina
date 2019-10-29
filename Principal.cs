using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    class Principal
    {
        List<Platillo> platillos = new List<Platillo>();

        Menu m = new Menu();
         public Principal()
        {
            MostrarSaludo();
            IU();
        }

        private void IU()
        {
            Console.WriteLine("elija una opción");
            Console.WriteLine("1.- Agregar al Menú\n" +
                "2.- Mostrar Menú\n" +
                "3.- Menú detallado");
            switch (Console.ReadLine())
            {

                case "1":
                    m.CrearMenu(platillos);
                    break;

                case "2":
                    m.ListaMenu(platillos);
                    break;




            }
            IU();
        }

        public static void MostrarSaludo()
        {
            Console.WriteLine("Bienvenido Restaurant Garcia´s");
        }
    }
}
