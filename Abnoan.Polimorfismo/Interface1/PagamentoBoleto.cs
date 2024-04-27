using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Interface1
{
    // Implementação da interface IPagamento para pagamentos com boleto
    public class PagamentoBoleto : IPagamento
    {
        public string CodigoBarras { get; set; }

        public PagamentoBoleto(string codigoBarras)
        {
            CodigoBarras = codigoBarras;
        }

        public bool ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Processando pagamento via boleto no valor de R$ {valor}");
            // Lógica para processar o pagamento
            Console.WriteLine("Boleto emitido.");
            return true;
        }
    }
}