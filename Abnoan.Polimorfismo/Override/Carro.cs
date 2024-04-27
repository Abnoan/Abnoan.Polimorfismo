using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Override
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        // Construtor que inicializa um novo objeto Carro com marca, modelo e ano
        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        // Sobrescrita do método ToString para retornar informações do carro formatadas
        // public override string ToString()
        // {
        //     return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}";
        // }
    }
}