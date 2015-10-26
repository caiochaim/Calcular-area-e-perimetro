using CalcularFormas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormas.Classes
{
    public class Retangulo : Forma, ICalculator
    {
        public double Area()
        {
            // faz uma condicional para saber se tem todos os lados iguais, se tiver ele retorna a área e perímetro de um quadrado, 
            // pois todo quadrado também é um retângulo. O mesmo acontece com o perímetro.
            AreaForma = (Base == Altura) ? Math.Pow(Base, Base) : Base * Altura;
            return AreaForma;
        }

        public double Perimetro()
        {
            PerimetroForma = (Base == Altura) ? Base * 4 : 2 * (Base + Altura);
            return PerimetroForma;
        }

        public override string ApresentarAreaPerimetro()
        {
            return string.Format("A área e perímetro do retângulo são respectivamente {0} e {1}", AreaForma, PerimetroForma);
        }
    }
}
