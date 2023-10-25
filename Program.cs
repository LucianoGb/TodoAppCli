// See https://aka.ms/new-console-template for more information


using ConsoleTables;
using System.Diagnostics;
using System.Linq.Expressions;
using TodoAppCli;

//List<Tarefa> tarefas = new List<Tarefa>();

Tarefa tarefa = new Tarefa();


void BoasVindas()
{
    Console.WriteLine(@"
████████╗░█████╗░██████╗░░█████╗░
╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
░░░██║░░░██║░░██║██║░░██║██║░░██║
░░░██║░░░██║░░██║██║░░██║██║░░██║
░░░██║░░░╚█████╔╝██████╔╝╚█████╔╝
░░░╚═╝░░░░╚════╝░╚═════╝░░╚════╝░");

    string boasvindas = "Boas Vindas ao TodoApp!";
    string caracteres = string.Empty.PadLeft(boasvindas.Length, '=');
    Console.WriteLine(caracteres);
    Console.WriteLine("Boas Vindas ao Todo App");
    Console.WriteLine(caracteres);

}

void ChamaPrograma()
{
    Console.Clear();
    Thread.Sleep(800);
    BoasVindas();
    ExibeOpcoesDoMenu();

}
void CadastrarTarefa()
{
    Console.WriteLine("Digite uma pequena descrição :");
    string descricao = Console.ReadLine()!;
    Thread.Sleep(1000);
    tarefa.AdicionarTarefa(descricao);
    Console.WriteLine("Tarefa cadastrada com sucesso!");
    Thread.Sleep(1000);
    ChamaPrograma();

}

void Tabela()
{
    var table = new ConsoleTable("Nº", "DESCRIÇÃO");
    table.AddRow(1, 2)
         .AddRow("this line should be longer", "yes it is");

    table.Write();
    Console.WriteLine();

    var rows = Enumerable.Repeat(new Tarefa(), 10);

    ConsoleTable
        .From<Tarefa>(rows)
        .Configure(o => o.NumberAlignment = Alignment.Right)
        .Write(Format.Alternative);

    Console.ReadKey();
}
void ListarTarefa()
{
    int indice = 1;
    var table = new ConsoleTable("Nº", "DESCRIÇÃO");

    Console.WriteLine();

    foreach (string descricao in tarefa.Descricao)
    {
        table.AddRow(indice, descricao);
        //Console.WriteLine($"{indice} - {descricao}");
        indice++;
    }
    table.Write();
    Console.WriteLine("Aperte uma tecla para voltar ao inicio");
    Console.ReadLine();
    ChamaPrograma();
}


void OpcaoEscolhida(int opcao)
{
    switch (opcao)
    {
        case 1:
            CadastrarTarefa();
            break;
        case 2:
            ListarTarefa();
            break;
        case 3:
            Tabela();
            break;
        case 4:
            Console.WriteLine("Opção 4");
            break;
        case 0:

            break;

    }
}

void ExibeOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 para registrar uma nova tarefa.");
    Console.WriteLine("Digite 2 para mostrar todas as tarefas.");
    Console.WriteLine("Digite 3 para editar uma tarefa.");
    Console.WriteLine("Digite 4 para concluir uma tarefa registrada.");
    Console.WriteLine("Digite 0 para sair.");
    Console.Write("\nFaça sua escolha: ");
    int opcao = int.Parse(Console.ReadLine()!);
    OpcaoEscolhida(opcao);

}


BoasVindas();
ExibeOpcoesDoMenu();



