using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio4
{
    // Classe abstrata base para formas geométricas
    public abstract class Forma
    {
        public abstract void Desenhar();
    }

    // Classe concreta para Circulo
    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando um círculo com raio {Raio}.");
        }
    }

    // Classe concreta para Retangulo
    public class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando um retângulo de largura {Largura} e altura {Altura}.");
        }
    }
}