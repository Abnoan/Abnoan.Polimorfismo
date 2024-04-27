using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio1
{
    public class Tablet : DispositivoEletronico
    {
        public double TamanhoTela { get; set; }

        public override void Ligar()
        {
            Console.WriteLine($"Ligando {Modelo} com tela de {TamanhoTela} polegadas.");
        }

        public override void Desligar()
        {
            Console.WriteLine($"Desligando {Modelo}.");
        }
    }
}