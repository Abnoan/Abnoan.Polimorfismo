using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio2
{
    public class Smartphone : DispositivoEletronico
    {
        public string SistemaOperacional { get; set; }
        public int CapacidadeBateria { get; set; }

        public override void Ligar()
        {
            Console.WriteLine($"Ligando {Modelo} com {SistemaOperacional}.");
        }

        public override void Desligar()
        {
            Console.WriteLine($"Desligando {Modelo}.");
        }

        public override string ObterDescricao()
        {
            return $"{base.ObterDescricao()}, OS: {SistemaOperacional}";
        }

        public override int VerificarBateria()
        {
            return CapacidadeBateria;  // Retorna a capacidade em porcentagem
        }
    }
}