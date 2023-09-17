using System.Linq.Expressions;
using System.Runtime.InteropServices;

string boasVindas = "SEJA BEM VINDO";
string nome;

List<string>livrosFavoritos = new List<string>();


Console.WriteLine(boasVindas);

Console.Write("Digite seu nome: ");
nome = Console.ReadLine();
Console.Clear();
Console.Write(nome+", Vamos começar!\n");

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite o 1 para registrar o nome de um livro.");
    Console.WriteLine("Digite o 2 para ler os livros regstrados.");
    Console.WriteLine("Digite o 3 para sair.");

    Console.Write("\nDigite uma opção: ");
    string escolha = Console.ReadLine()!;
    int numerica = int.Parse(escolha);
    switch(numerica) {
        case 1: RegistrarLivros();
            break;
        case 2: LerLivros();
            break;
        case 3: Sair();
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }
}

void RegistrarLivros() {
    Console.Clear();
    Console.WriteLine("Registro de livros: ");
    Console.Write("Ditite o nome de um livro: ");
    string nomeDoLivro = Console.ReadLine();
    livrosFavoritos.Add(nomeDoLivro);
    Console.WriteLine($"Livro {nomeDoLivro} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void LerLivros() {
    Console.Clear();
    Console.WriteLine("****************************************");
    Console.WriteLine("Mostrando todos os livros registrados:");
    Console.WriteLine("****************************************");
    for (int i = 0; i < livrosFavoritos.Count; i++) {
        Console.Write($"Livro: {livrosFavoritos [i]}");
        Console.WriteLine();
    }

    Console.Write("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void Sair()
{
    Console.WriteLine(nome+ ",Tchau Tchau");
    Thread.Sleep(2000);
    Console.Clear();
}

ExibirOpcoesMenu();
