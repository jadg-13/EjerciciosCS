using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2.modelos
{
    public class Empleado
    {
        public String Nombre {  get; set; }
        public String Cargo { get; set; }
        public Double Salario { get; set; }

        public Empleado()
        {
        }

        public Empleado(string nombre, string cargo, double salario)
        {
            Nombre = nombre;
            Cargo = cargo;
            Salario = salario;
        }

    }
}
