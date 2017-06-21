using CleanCode.WorkShop.AbstracaoClasseRefatorado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.WorkShop.RetornoNuloRefatorado
{
    public enum TipoFigura
    {
        Circulo,
        Quadrado,
        Triangulo
    }

    public class FiguraGeometricaDesconhecida : IFiguraGeometrica
    {
        public double CalcularArea()
        {
            return default(double);
        }
    }

    public interface IFiguraGeometricaFactory
    {
        IFiguraGeometrica CriarFigura(TipoFigura tipo);
    }

    public class FiguraGeometricaFactory : IFiguraGeometricaFactory
    {
        public IFiguraGeometrica CriarFigura(TipoFigura tipo)
        {
            switch (tipo)
            {
                case TipoFigura.Circulo:
                    return new Circulo();
                case TipoFigura.Quadrado:
                    return new Quadrado();
                default:
                    return new FiguraGeometricaDesconhecida();
            }
        }
    }

    public class ProcessamentoFiguras
    {
        public void Processar(IFiguraGeometricaFactory factory)
        {
            var figura = factory.CriarFigura(TipoFigura.Triangulo);
            var area = figura.CalcularArea();
        }
    }
}
