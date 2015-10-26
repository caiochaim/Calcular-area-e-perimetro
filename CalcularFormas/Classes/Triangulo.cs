using CalcularFormas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormas.Classes
{
    public class Triangulo : Forma, ICalculator
    {
        public double Area()
        {
            AreaForma = (Base * Altura) / 2;
            return AreaForma;
        }

        public double Perimetro()
        {
            PerimetroForma = Base * 3;
            return PerimetroForma;
        }

        public override string ApresentarAreaPerimetro()
        {
            return string.Format("A área e perímetro do triangulo são respectivamente {0} e {1}", AreaForma, PerimetroForma);
        }
    }
}
