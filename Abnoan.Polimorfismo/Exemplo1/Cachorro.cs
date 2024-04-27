using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz Au Au!");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo ração.");
        }
    }
}