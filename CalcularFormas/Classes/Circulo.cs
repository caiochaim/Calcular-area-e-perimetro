using CalcularFormas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormas.Classes
{
    public class Circulo : Forma, ICalculator
    {
        private double _raio;

        public double Raio
        {
            get { return this._raio; }

            set { this._raio = (value > 0) ? value : 0; }
        }

        public double Area()
        {
            return AreaForma = Math.PI * Math.Pow(this._raio, 2);
        }

        public double Perimetro()
        {
            return PerimetroForma = 2 * Math.PI * this._raio;
        }

        public override string ApresentarAreaPerimetro()
        {
            return string.Format("A área e perímetro do círculo são respectivamente {0} e {1}", string.Format("{0:0.#}", AreaForma), string.Format("{0:0.#}", PerimetroForma));
        }
    }
}
