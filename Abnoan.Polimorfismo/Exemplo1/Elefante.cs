using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Elefante : Animal
    {
        public Elefante(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz Barrito!");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo vegetação.");
        }
    }
}