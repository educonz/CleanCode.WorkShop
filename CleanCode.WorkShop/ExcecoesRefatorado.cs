using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.WorkShop.ExcecoesRefatorado
{
    public class BusinessException : Exception
    {
        public BusinessException(string message)
            : base(message)
        {

        }
    }

    public class OrdemServico
    {
        public void Gerar(Servico servico)
        {
            if (servico == null)
                throw new ArgumentNullException(nameof(servico));

            var valorTotal = servico.HorasTrabalhadas * servico.Valor;

            if (valorTotal > servico.Orcamento)
                throw new BusinessException("Valor total é maior que o orçado!");
        }
    }

    public class Trabalho
    {
        public void IncluirOrdemServico()
        {
            try
            {
                new OrdemServico().Gerar(new Servico
                {
                    Descricao = "Programar",
                    HorasTrabalhadas = 8,
                    Valor = 30,
                    Orcamento = 500
                });
            }
            catch (ArgumentNullException ex)
            {
                //ação quando for null
            }
            catch (BusinessException ex)
            {
                //ação quando for regra de negócio
            }
        }
    }


    public class Servico
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal HorasTrabalhadas { get; set; }
        public decimal Orcamento { get; set; }
    }
}
