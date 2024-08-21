using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01B
{
    internal class Triangulo
    {
        public int Base { get; set; }

        public int Altura { get; set; }

        public int calcularArea()
        {
            return (Base * Altura) / 2;

        }

    }
}
