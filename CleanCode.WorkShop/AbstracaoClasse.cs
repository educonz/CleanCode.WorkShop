using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.WorkShop.AbstracaoClasse
{
    public class Quadrado
    {
        public int Lado { get; set; }
    }

    public class Retangulo
    {
        public int Altura { get; set; }

        public int Largura { get; set; }

    }

    public class Circulo
    {
        public int Raio { get; set; }
    }

    public class CalculoAreaFiguraGeometrica
    {
        public IEnumerable<double> Calcular(IEnumerable<object> figuras)
        {
            foreach (var figura in figuras)
            {
                if (figura is Quadrado quadrado)
                {
                    yield return quadrado.Lado * quadrado.Lado;
                }
                else if (figura is Retangulo retangulo)
                {
                    yield return retangulo.Largura * retangulo.Altura;
                }
                else if (figura is Circulo circulo)
                {
                    yield return Math.PI * circulo.Raio;
                }
            }
        }
    }
}

