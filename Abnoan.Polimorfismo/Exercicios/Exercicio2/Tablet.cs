using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio2
{
    public class Tablet : DispositivoEletronico
    {
        public double TamanhoTela { get; set; }
        public int CapacidadeBateria { get; set; }

        public override void Ligar()
        {
            Console.WriteLine($"Ligando {Modelo} com tela de {TamanhoTela} polegadas.");
        }

        public override void Desligar()
        {
            Console.WriteLine($"Desligando {Modelo}.");
        }

        public override string ObterDescricao()
        {
            return $"{base.ObterDescricao()}, Tela: {TamanhoTela} polegadas";
        }

        public override int VerificarBateria()
        {
            return CapacidadeBateria;  // Retorna a capacidade em porcentagem
        }
    }
}