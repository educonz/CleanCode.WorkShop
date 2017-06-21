using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.WorkShop.Excecoes
{
    public class OrdemServico
    {
        public void Gerar(Servico servico)
        {
            if (servico == null)
                throw new Exception("Serviço é nulo");

            var valorTotal = servico.HorasTrabalhadas * servico.Valor;

            if (valorTotal > servico.Orcamento)
                throw new Exception("Valor total é maior que o orçado!");
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
            catch(Exception ex)
            {
                if (ex.Message.Equals("Serviço é nulo"))
                {
                    //ação
                }
                else if (ex.Message.Equals("Valor total é maior que o orçado!"))
                {
                    //ação
                }
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
