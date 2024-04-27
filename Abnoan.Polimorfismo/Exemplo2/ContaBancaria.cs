using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exemplo2
{
    public abstract class ContaBancaria
    {
        public string NumeroConta { get; private set; }
        protected decimal Saldo { get; set; }

        public ContaBancaria(string numeroConta)
        {
            NumeroConta = numeroConta;
            Saldo = 0;
        }

        public abstract void Depositar(decimal valor);
        public abstract bool Sacar(decimal valor);
    }
}