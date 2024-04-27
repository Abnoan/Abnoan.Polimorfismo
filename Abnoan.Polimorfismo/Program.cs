using Abnoan.Polimorfismo.Exemplo2;
using Abnoan.Polimorfismo.Exercicios.Exercicio1;
using Abnoan.Polimorfismo.Exercicios.Exercicio3;
using Abnoan.Polimorfismo.Exercicios.Exercicio4;
using Abnoan.Polimorfismo.Exercicios.Exercicio5;
using Abnoan.Polimorfismo.Interface1;
using Abnoan.Polimorfismo.Interface2;
using Abnoan.Polimorfismo.Interface3;
using Abnoan.Polimorfismo.Override;
using Exemplo;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Override
        // Criação de um novo objeto Carro
        var meuCarro = new Carro("Toyota", "Corolla", 2022);

        // Imprimindo o carro usando o método ToString padrão
        Console.WriteLine("ToString padrão antes de sobrescrever:");
        Console.WriteLine(meuCarro); //Se o ToString não estiver sobrescrito vai aparecer: Abnoan.Polimorfismo.Override.Carro

        // Sobrescrevendo ToString para obter uma saída mais informativa
        Console.WriteLine("\nToString sobrescrito com informações detalhadas do carro:");
        Console.WriteLine(meuCarro);
        #endregion

        #region Animal
        List<Animal> meusAnimais =
        [
            // Adiciona animais à lista
            new Cachorro("Totó"),
            new Gato("Joel"),
            new Passaro("Piupiu"),
            new Peixe("Beta"),
            new Elefante("Dumbo"),
            new Coelho("Paulo"),
        ];


        foreach (Animal animal in meusAnimais)
        {
            Console.WriteLine($"--- {animal.Nome} ---");
            animal.EmitirSom();
            animal.Comer();
            Console.WriteLine();
        }
        #endregion

        #region Conta
        ContaBancaria cc = new ContaCorrente("123-CC");
        ContaBancaria cp = new ContaPoupanca("123-CP");

        cc.Depositar(1000);
        cc.Sacar(500);

        cp.Depositar(1000);
        cp.Sacar(500);
        #endregion

        #region Interface - Pagamento
        // Criação de objetos de pagamento
        IPagamento pagamentoCartao = new PagamentoCartao("1234-5678-9012-3456");
        IPagamento pagamentoBoleto = new PagamentoBoleto("7890-1234-5678-9012");

        // Processamento dos pagamentos
        pagamentoCartao.ProcessarPagamento(500.00m);
        pagamentoBoleto.ProcessarPagamento(250.00m);
        #endregion

        #region Interface - Funcionario
        Funcionario joao = new Funcionario("João");

        // João exercendo suas várias habilidades
        joao.EscreverCodigo();
        joao.GerenciarProjeto();
        joao.ConsultarCliente();
        #endregion

        #region Interface - Pessoa
        // Criando duas pessoas
        Pessoa pessoa1 = new Pessoa("Maria", 30);
        Pessoa pessoa2 = new Pessoa("João", 25);

        // Comparando duas pessoas
        int resultadoComparacao = pessoa1.CompareTo(pessoa2);
        if (resultadoComparacao > 0)
        {
            Console.WriteLine($"{pessoa1.Nome} é mais velha que {pessoa2.Nome}.");
        }
        else if (resultadoComparacao < 0)
        {
            Console.WriteLine($"{pessoa1.Nome} é mais nova que {pessoa2.Nome}.");
        }
        else
        {
            Console.WriteLine($"{pessoa1.Nome} e {pessoa2.Nome} têm a mesma idade.");
        }

        // Criando uma lista de pessoas
        List<Pessoa> pessoas = new List<Pessoa>
        {
            pessoa1,
            new Pessoa("Ana", 22),
            pessoa2,
            new Pessoa("Paulo", 28)
        };

        //Ométodo Sort() internamente usa o CompareTo implementado em cada objeto para determinar a ordem dos elementos. 
        pessoas.Sort();

        // Imprimindo as pessoas ordenadas por idade
        Console.WriteLine("\nLista de Pessoas Ordenadas por Idade:");
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine(pessoa);
        }
        #endregion

        #region Exercicio 1
        Smartphone meuSmartphone = new Smartphone
        {
            Marca = "Google",
            Modelo = "Pixel 5",
            AnoDeFabricacao = 2020,
            SistemaOperacional = "Android"
        };
        meuSmartphone.Ligar();
        meuSmartphone.Desligar();

        Tablet meuTablet = new Tablet
        {
            Marca = "Apple",
            Modelo = "iPad Pro",
            AnoDeFabricacao = 2021,
            TamanhoTela = 12.9
        };
        meuTablet.Ligar();
        meuTablet.Desligar();
        #endregion

        #region  Ex3
        // Criar lista de INotificacao
        List<INotificacao> notificacoes = new List<INotificacao>();
        notificacoes.Add(new EmailNotificacao());
        notificacoes.Add(new SMSNotificacao());
        notificacoes.Add(new PushNotificacao());

        // Iterar sobre a lista e chamar Enviar()
        foreach (var notificacao in notificacoes)
        {
            notificacao.Enviar("Mensagem de teste");
        }
        #endregion

        #region Ex 4
        List<Forma> formas = new List<Forma>
        {
            new Circulo(5),
            new Retangulo(10, 4)
        };

        foreach (Forma forma in formas)
        {
            forma.Desenhar();
        }
        #endregion

        #region  Ex 5
        GerenciadorDeEventos gerenciador = new GerenciadorDeEventos();
        gerenciador.AdicionarEvento("Conferência Tech", DateTime.Now.AddDays(30));
        gerenciador.AdicionarEvento("Workshop de C#", "Auditório Principal", DateTime.Now.AddDays(60));
        gerenciador.AdicionarEvento("Lançamento de Produto", DateTime.Now.AddDays(90), "Descrição do evento aqui.");

        Evento meuEvento = new Evento("Festival de Música", DateTime.Now.AddDays(120));
        gerenciador.AdicionarEvento(meuEvento);

        #endregion
    }
}