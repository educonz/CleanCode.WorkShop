using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode.WorkShop.AbstracaoClasseRefatorado;

namespace CleanCode.WorkShop.RetornoNulo
{
    public enum TipoFigura
    {
        Circulo,
        Quadrado,
        Triangulo
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
                    return null;
            }
        }
    }

    public class ProcessamentoFiguras
    {
        public void Processar(IFiguraGeometricaFactory factory)
        {
            var figura = factory.CriarFigura(TipoFigura.Triangulo);
            // aqui figura vai ser nula e vai extourar uma exception
            var area = figura.CalcularArea();
        }
    }
}
