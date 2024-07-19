using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2.modelos
{
    public class Tabla
    {
        public Tabla() { }

        public String obtTabla(int num)
        {
            string tbl = "";
            for(int i = 0; i <= 12; i++)
            {
                tbl += i + " * " + num + " = " + (i * num) + "\n";
            }
            return tbl;
        }
    }
}
