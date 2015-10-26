using CalcularFormas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormas.Classes
{
    public class Repositorio
    {
        public double CalcularArea(ICalculator calc)
        {
            return calc.Area();
        }

        public double CalcularPerimetro(ICalculator calc)
        {
            return calc.Perimetro();
        }
    }
}
