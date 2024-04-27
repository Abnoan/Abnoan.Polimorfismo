using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Interface2
{
    public class Funcionario : IDesenvolvedor, IGerente, IConsultor
    {
        public string Nome { get; set; }

        public Funcionario(string nome)
        {
            Nome = nome;
        }

        public void EscreverCodigo()
        {
            Console.WriteLine($"{Nome} está escrevendo código.");
        }

        public void GerenciarProjeto()
        {
            Console.WriteLine($"{Nome} está gerenciando um projeto.");
        }

        public void ConsultarCliente()
        {
            Console.WriteLine($"{Nome} está consultando um cliente.");
        }
    }
}