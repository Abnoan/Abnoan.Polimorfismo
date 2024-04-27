using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Overload
{
    public class Calculadora
    {
        // Sobrecarga do método Somar para dois inteiros
        public int Somar(int a, int b)
        {
            return a + b;
        }

        // Sobrecarga do método Somar para três inteiros
        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        // Sobrecarga do método Somar para dois números de ponto flutuante
        public double Somar(double a, double b)
        {
            return a + b;
        }

        // Sobrecarga do método Somar para um vetor de inteiros
        public int Somar(params int[] numeros)
        {
            int soma = 0;
            foreach (int num in numeros)
            {
                soma += num;
            }
            return soma;
        }
    }

}