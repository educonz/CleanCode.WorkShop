using System;
using System.Collections.Generic;

namespace CleanCode.WorkShop.Funcoes
{
    public class Venda
    {
        private readonly IOperableRepository _operableRepository;
        private readonly IAlert _alert;

        public Venda(IOperableRepository operableRepository, IAlert alert)
        {
            _operableRepository = operableRepository;
            _alert = alert;
        }

        public void RealizarVenda(IEnumerable<Pedido> pedidos)
        {
            var totalVenda = 0m;

            foreach(var pedido in pedidos)
            {
            var estoque = pedido.Estoque;
              estoque.QuantidadeAtual = -pedido.Quantidade;

                _operableRepository.Save(estoque);

                if (pedido.Presente)
                             _alert.Show("Empacotar!!!");

                totalVenda += (pedido.Quantidade 
                    * pedido.ValorUnitario) 
                    - pedido.Desconto;
            }

            _alert.Show($"Total da venda {totalVenda}");
        }
    }


    public class Pedido
    {
        public Estoque Estoque { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Desconto { get; set; }
        public bool Presente { get; set; }
    }

    public class Estoque
    {
        public int QuantidadeAtual { get; set; }
    }

    public interface IAlert
    {
        void Show(string message);
    }

    public interface IOperableRepository
    {
        T Save<T>(T entity);
    }
}
