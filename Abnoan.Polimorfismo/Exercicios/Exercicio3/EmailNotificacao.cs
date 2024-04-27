using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio4
{
    public class EmailNotificacao : INotificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Enviando email: {mensagem}");
        }
    }
}