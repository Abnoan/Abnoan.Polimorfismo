using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio6
{
    public class GerenciadorDeEventosOnline : IEventoGerenciador
    {
        private List<Evento> eventosOnline = new List<Evento>();

        public void AdicionarEvento(Evento evento)
        {
            eventosOnline.Add(evento);
            Console.WriteLine($"Evento online '{evento.Nome}' adicionado para {evento.Data.ToShortDateString()} com link.");
        }

        public void ListarEventos()
        {
            foreach (Evento evento in eventosOnline)
            {
                Console.WriteLine($"Evento Online: {evento.Nome} em {evento.Data.ToShortDateString()}");
            }
        }
    }
}