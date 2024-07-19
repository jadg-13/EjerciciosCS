using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.modelos
{
    public class Saludo
    {

        public Saludo() { }

        public String saludar(String nombre)
        {
            return "Hola " + nombre + ", mucho gusto";
        }
    }
}
