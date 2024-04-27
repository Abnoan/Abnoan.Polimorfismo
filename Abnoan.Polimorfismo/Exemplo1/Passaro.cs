using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Passaro : Animal
    {
        public Passaro(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} canta.");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo sementes.");
        }
    }
}