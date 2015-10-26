using CalcularFormas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormas.Classes
{
    public class Trapezio : Forma, ICalculator
    {
        private double _baseMaior;  // O usuário deverá informar tambem a base maior e menor da forma.
        private double _baseMenor;

        public double BaseMaior
        {
            get { return this._baseMaior; }

            set { this._baseMaior = (value > 0) ? value : 0; }
        }

        public double BaseMenor
        {
            get { return this._baseMenor; }

            set { this._baseMenor = (value > 0) ? value : 0; }
        }

        public double Area()
        {
            AreaForma = (Altura * (BaseMaior + BaseMenor)) / 2;
            return AreaForma;
        }

        public double Perimetro()
        {
            // Primeiro descobrindo o lado da forma para fazer a soma e obter o perímetro.
            double lado = Math.Pow((BaseMaior - BaseMenor), 2) + Math.Pow(Altura, 2);
            lado = Math.Sqrt(lado);

            PerimetroForma = BaseMaior + BaseMenor + (lado * 2);
            return PerimetroForma;
        }

        public override string ApresentarAreaPerimetro()
        {
            return string.Format("A área e perímetro do trapézio são respectivamente {0} e {1}", AreaForma, PerimetroForma);
        }
    }
}
