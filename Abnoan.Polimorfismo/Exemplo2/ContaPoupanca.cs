using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exemplo2
{
    public class ContaPoupanca : ContaBancaria
    {
        private readonly decimal taxaJuros = 0.02M;

        public ContaPoupanca(string numeroConta) : base(numeroConta) { }

        public override void Depositar(decimal valor)
        {
            decimal valorComJuros = valor + (valor * taxaJuros);
            Saldo += valorComJuros;
            Console.WriteLine($"Depositado com juros: {valorComJuros} | Saldo Atual: {Saldo}");
        }

        public override bool Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Sacado: {valor} | Saldo Atual: {Saldo}");
                return true;
            }
            Console.WriteLine("Saldo insuficiente.");
            return false;
        }
    }
}