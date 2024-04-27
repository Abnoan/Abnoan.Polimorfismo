using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio1
{    public abstract class DispositivoEletronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoDeFabricacao { get; set; }

        public abstract void Ligar();
        public abstract void Desligar();
    }
}