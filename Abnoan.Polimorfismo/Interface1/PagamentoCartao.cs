using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Interface1
{
    public class PagamentoCartao : IPagamento
    {
        public string NumeroCartao { get; set; }

        public PagamentoCartao(string numeroCartao)
        {
            NumeroCartao = numeroCartao;
        }

        public bool ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Processando pagamento via cartão no valor de R$ {valor}");
            // Lógica para processar o pagamento
            Console.WriteLine("Pagamento autorizado.");
            return true;
        }
    }
}