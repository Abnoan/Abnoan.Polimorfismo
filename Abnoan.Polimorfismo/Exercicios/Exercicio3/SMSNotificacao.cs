using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Polimorfismo.Exercicios.Exercicio3
{
    public class SMSNotificacao : INotificacao
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Enviando SMS: {mensagem}");
        }
    }
}