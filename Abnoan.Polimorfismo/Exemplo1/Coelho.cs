using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Coelho : Animal
    {
        public Coelho(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz som suave.");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo cenouras.");
        }
    }
}