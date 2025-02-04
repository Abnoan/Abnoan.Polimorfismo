using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio5
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }

        public Evento(string nome, DateTime data)
        {
            Nome = nome;
            Data = data;
        }

        public Evento(string nome, string local, DateTime data) : this(nome, data)
        {
            Local = local;
        }

        public Evento(string nome, DateTime data, string descricao) : this(nome, data)
        {
            Descricao = descricao;
        }
    }
}