using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.WorkShop.Comentarios
{
    public class CalculoTrabalho
    {
        // Calcula o valor do resultado de um dia de trabalho na função X
        public decimal ObterResultado(decimal horas, decimal vlHora, int e)
        {
            // aqui é iniciado as horas
            decimal h = horas;

            // verifica se tem hora extra, caso tenha adicionar mais 70%
            if (h > 9)
                h += (h - 9) * 0.7m;
            // verifica se não trabalho no horário, caso não trabalhou descontar 50%
            else if (h < 9)
                h = h - (h * -0.5m);

            // verifica se o dia é igual a domingo
            if (e == 7)
                h += h * 1.0m;

            // retornar resultado de horas multiplicado pelo valor da hora
            return h * vlHora;
        }
    }
}
