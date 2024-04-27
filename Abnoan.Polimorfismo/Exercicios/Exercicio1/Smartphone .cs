using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio1
{
    public class Smartphone : DispositivoEletronico
    {
        public string SistemaOperacional { get; set; }

        public override void Ligar()
        {
            Console.WriteLine($"Ligando {Modelo} com {SistemaOperacional}.");
        }

        public override void Desligar()
        {
            Console.WriteLine($"Desligando {Modelo}.");
        }
    }
}