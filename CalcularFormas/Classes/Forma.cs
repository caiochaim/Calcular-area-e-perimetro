using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormas.Classes
{
    public abstract class Forma
    {
        private double _base;
        private double _altura;

        public double AreaForma { get; set; }
        public double PerimetroForma { get; set; }

        public double Base
        {
            get { return this._base; }

            set { this._base = (value > 0) ? value : 0;}
        }

        public double Altura
        {
            get { return this._altura; }

            set { this._altura = (value > 0) ? value : 0; }
        }

        public virtual string ApresentarAreaPerimetro()
        {
            return string.Empty;
        }
    }
}
