using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio6
{
    public interface IEventoGerenciador
    {
        void AdicionarEvento(Evento evento);
        void ListarEventos();
    }
}