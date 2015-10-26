using CalcularFormas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormas.Classes
{
    public class Quadrado : Forma, ICalculator
    {
        public double Area()
        {
            AreaForma = Math.Pow(Base, Base);
            return AreaForma;
        }

        public double Perimetro()
        {
            PerimetroForma = Base * 4;
            return PerimetroForma;
        }

        public override string ApresentarAreaPerimetro()
        {
            return string.Format("A área e perímetro do quadrado são respectivamente {0} e {1}", AreaForma, PerimetroForma);
        }
    }
}
