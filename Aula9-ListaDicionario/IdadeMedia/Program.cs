using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, int> idadePessoas = new();
        Console.WriteLine("Quantos nomes deseja digitar?");
        int quant = int.Parse(Console.ReadLine());
        for (int i = 0; i < quant; i++)
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade de " + nome + ": ");
            int idade = int.Parse(Console.ReadLine());

            idadePessoas.Add(nome, idade);
        }

        string maisVelhoNome = "";
        int maiorIdade = int.MinValue;
        string maisNovaNome = "";
        int menorIdade = int.MaxValue;

        foreach (var pessoa in idadePessoas)
        {
            if (pessoa.Value > 17)
            {
                Console.WriteLine($"{pessoa.Key} tem {pessoa.Value} anos. Ou seja, é maior de idade");
            }
            if (pessoa.Value < menorIdade)
            {
                menorIdade = pessoa.Value;
                maisNovaNome = pessoa.Key;
            }
            if (pessoa.Value > maiorIdade)
            {
                maiorIdade = pessoa.Value;
                maisVelhoNome = pessoa.Key;
            }
        }
        Console.WriteLine(maisVelhoNome + "É a pessoa mais velha");
        Console.WriteLine(maisNovaNome + "É a pessoa mais nova");

        Console.Write("Digite a idade para remover as pessoas com essa idade: ");
        int idadeRemover = int.Parse(Console.ReadLine());
        List<string> nomesParaRemover = new();
        foreach (var pessoa in idadePessoas)
        {
            if (pessoa.Value == idadeRemover)
            {
                nomesParaRemover.Add(pessoa.Key);
            }
        }
        foreach (string nome in nomesParaRemover)
        {
            idadePessoas.Remove(nome);
        }
        Console.WriteLine("Dicionário atualizado:");
        foreach (var pessoa in idadePessoas)
        {
            Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
        }
    }
}