using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    interface IMenu
    {
        void CrearMenu(List<Platillo> p);
         void ListaMenu(List<Platillo> p);
         void DetallePlatillo();


    }
}
