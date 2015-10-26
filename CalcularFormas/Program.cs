using CalcularFormas.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Repositorio rep = new Repositorio();

            // TRIANGULO

            Triangulo triangulo = new Triangulo();
            triangulo.Base = 5;
            triangulo.Altura = 10;

            rep.CalcularArea(triangulo);
            rep.CalcularPerimetro(triangulo);

            string resultadoTriangulo = triangulo.ApresentarAreaPerimetro();

            Console.WriteLine(resultadoTriangulo);

            // QUADRADO

            Quadrado quadrado = new Quadrado();
            quadrado.Base = 3;
            quadrado.Altura = 3;

            rep.CalcularArea(quadrado);
            rep.CalcularPerimetro(quadrado);

            string resultadoQuadrado = quadrado.ApresentarAreaPerimetro();

            Console.WriteLine(resultadoQuadrado);

            // RETÂNGULO

            Retangulo retangulo = new Retangulo();
            retangulo.Base = 10;
            retangulo.Altura = 5;

            rep.CalcularArea(retangulo);
            rep.CalcularPerimetro(retangulo);

            string resultadoRetangulo = retangulo.ApresentarAreaPerimetro();

            Console.WriteLine(resultadoRetangulo);

            // CÍRCULO

            Circulo circulo = new Circulo();
            circulo.Base = 0;
            circulo.Altura = 0;
            circulo.Raio = 1;

            rep.CalcularArea(circulo);
            rep.CalcularPerimetro(circulo);

            string resultadoCirculo = circulo.ApresentarAreaPerimetro();

            Console.WriteLine(resultadoCirculo);

            // LOSANGO

            Losango losango = new Losango();
            losango.Base = 10;
            losango.Altura = 24;

            rep.CalcularArea(losango);
            rep.CalcularPerimetro(losango);

            string resultadoLosango = losango.ApresentarAreaPerimetro();

            Console.WriteLine(resultadoLosango);

            // PARALELOGRAMO

            Paralelogramo paralelogramo = new Paralelogramo();
            paralelogramo.Base = 8;
            paralelogramo.Altura = 12;

            rep.CalcularArea(paralelogramo);
            rep.CalcularPerimetro(paralelogramo);

            string resultadoParalelogramo = paralelogramo.ApresentarAreaPerimetro();

            Console.WriteLine(resultadoParalelogramo);

            // TRAPÉZIO

            Trapezio trapezio = new Trapezio();
            trapezio.Base = 0;
            trapezio.BaseMaior = 32;
            trapezio.BaseMenor = 20;
            trapezio.Altura = 16;

            rep.CalcularArea(trapezio);
            rep.CalcularPerimetro(trapezio);

            string resultadoTrapezio = trapezio.ApresentarAreaPerimetro();

            Console.WriteLine(resultadoTrapezio);

            Console.ReadKey();
        }
    }
}
