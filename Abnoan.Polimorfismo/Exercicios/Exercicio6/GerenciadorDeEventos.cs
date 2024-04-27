using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio6
{
    public class GerenciadorDeEventos : IEventoGerenciador
    {
        private List<Evento> eventos = new List<Evento>();

        public void AdicionarEvento(string nome, DateTime data)
        {
            Console.WriteLine($"Evento '{nome}' adicionado para {data.ToShortDateString()}.");
        }

        public void AdicionarEvento(string nome, string local, DateTime data)
        {
            Console.WriteLine($"Evento '{nome}' em '{local}' adicionado para {data.ToShortDateString()}.");
        }

        public void AdicionarEvento(string nome, DateTime data, string descricao)
        {
            Console.WriteLine($"Evento '{nome}' em {data.ToShortDateString()}: {descricao}");
        }

        public void AdicionarEvento(Evento evento)
        {
            Console.WriteLine($"Evento '{evento.Nome}' com todos os detalhes adicionado para {evento.Data.ToShortDateString()}.");
        }
        public void ListarEventos()
        {
            foreach (Evento evento in eventos)
            {
                Console.WriteLine($"Evento: {evento.Nome} em {evento.Data.ToShortDateString()}");
            }
        }
    }
}