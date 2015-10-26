using CalcularFormas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormas.Classes
{
    public class Losango : Forma, ICalculator
    {
        public double Area()
        {
            // faz uma condicional para saber se tem todos os lados iguais, se tiver ele retorna a área e perímetro de um quadrado, 
            // pois todo quadrado também é um losango. O mesmo acontece com o perímetro.
            AreaForma = (Base == Altura) ? Math.Pow(Base, Base) : (Base * Altura) / 2;
            return AreaForma;
        }

        public double Perimetro()
        {
            double lado = Math.Pow((Altura / 2), 2) + Math.Pow((Base / 2), 2);
                   lado = Math.Sqrt(lado);

            PerimetroForma = (Base == Altura) ?  Base * 4 : lado * 4;
            return PerimetroForma;
        }

        public override string ApresentarAreaPerimetro()
        {
            return string.Format("A área e perímetro do losango são respectivamente {0} e {1}", string.Format("{0:0.#}", AreaForma), string.Format("{0:0.#}", PerimetroForma));
        }
    }
}
