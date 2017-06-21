using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.WorkShop.AbstracaoClasseRefatorado
{
    public interface IFiguraGeometrica
    {
        double CalcularArea();
    }

    public class Quadrado : IFiguraGeometrica
    {
        public int Lado { get; set; }

        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }

    public class Retangulo : IFiguraGeometrica
    {
        public int Altura { get; set; }

        public int Largura { get; set; }
        public double CalcularArea()
        {
            return Altura * Largura;
        }
    }

    public class Circulo : IFiguraGeometrica
    {
        public int Raio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Raio;
        }
    }

    public class CalculoAreaFiguraGeometrica2
    {
        public IEnumerable<double> Calcular(IEnumerable<IFiguraGeometrica> figuras)
        {
            foreach (var figura in figuras)
            {
                yield return figura.CalcularArea();
            }
        }
    }
}
