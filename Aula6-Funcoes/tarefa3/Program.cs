using System;
class aula6
{
    static string nome1 = "", nome2 = "", nome3 = "", nome4 = "", nome5 = "";
    static string poder1 = "", poder2 = "", poder3 = "", poder4 = "", poder5 = "";
    static int pont1 = 0, pont2 = 0, pont3 = 0, pont4 = 0, pont5 = 0;

    static string escolha1 = "", escolha2 = "", escolha3 = "";
    static string poderEscolha1 = "", poderEscolha2 = "", poderEscolha3 = "";
    static int pontEscolha1 = 0, pontEscolha2 = 0, pontEscolha3 = 0;

    static void Main(string[] args)
    {
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("1 - Cadastrar personagens");
            Console.WriteLine("2 - Formar equipe");
            Console.WriteLine("3 - Exibir equipe");
            Console.WriteLine("4 - Pontuação total da equipe");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Escolha uma opção:");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                cadastrar();
            }
            else if (opcao == 2)
            {
                equipe();
            }
            else if (opcao == 3)
            {
                exibir(escolha1, escolha2, escolha3, poderEscolha1, poderEscolha2, poderEscolha3);
            }
            else if (opcao == 4)
            {
                ponttotal();
            }
            else if (opcao == 5)
            {
                Console.WriteLine("Encerrando o programa...");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            Console.WriteLine();
        }
    }

    static void cadastrar()
    {
        int contador = 0;
        string nome = null;
        string poder = null;
        int pontuacao = 0;
        int conta = 0;
        Console.WriteLine("Quantos personagens você quer digitar? (mínimo 3 e máximo 5)");
        int n = int.Parse(Console.ReadLine());
        if (n < 3 || n > 5)
        {
            Console.WriteLine("Número inválido. O número deve ser entre 3 e 5.");
            return;
        }

        while (contador < n)
        {
            Console.WriteLine("Nome do personagem:");
            nome = Console.ReadLine();
            Console.WriteLine("Poder do personagem:");
            poder = Console.ReadLine();
            Console.WriteLine("Pontuação do personagem:");
            pontuacao = int.Parse(Console.ReadLine());
            conta++;
            transforma(nome, poder, pontuacao, conta);
            contador++;
        }
    }

    static void transforma(string nome, string poder, int pontuacao, int conta)
    {
        if (conta == 1)
        {
            nome1 = nome;
            poder1 = poder;
            pont1 = pontuacao;
        }
        else if (conta == 2)
        {
            nome2 = nome;
            poder2 = poder;
            pont2 = pontuacao;
        }
        else if (conta == 3)
        {
            nome3 = nome;
            poder3 = poder;
            pont3 = pontuacao;
        }
        else if (conta == 4)
        {
            nome4 = nome;
            poder4 = poder;
            pont4 = pontuacao;
        }
        else if (conta == 5)
        {
            nome5 = nome;
            poder5 = poder;
            pont5 = pontuacao;
        }
    }

    static void equipe()
    {
        escolha1 = "";
        escolha2 = "";
        escolha3 = "";
        poderEscolha1 = "";
        poderEscolha2 = "";
        poderEscolha3 = "";
        pontEscolha1 = 0;
        pontEscolha2 = 0;
        pontEscolha3 = 0;

        int i = 0;
        while (i < 3)
        {
            Console.WriteLine("Escolha três para formar uma equipe:");
            Console.WriteLine($"1 - {nome1}");
            Console.WriteLine($"2 - {nome2}");
            Console.WriteLine($"3 - {nome3}");
            Console.WriteLine($"4 - {nome4}");
            Console.WriteLine($"5 - {nome5}");
            string entrada = Console.ReadLine();

            if (entrada == "1")
            {
                Console.WriteLine($"Você escolheu {nome1}, com poder {poder1} e pontuação {pont1}");
                if (escolha1 == "")
                {
                    escolha1 = nome1;
                    poderEscolha1 = poder1;
                    pontEscolha1 = pont1;
                }
                else if (escolha2 == "")
                {
                    escolha2 = nome1;
                    poderEscolha2 = poder1;
                    pontEscolha2 = pont1;
                }
                else if (escolha3 == "")
                {
                    escolha3 = nome1;
                    poderEscolha3 = poder1;
                    pontEscolha3 = pont1;
                }
                i++;
            }
            else if (entrada == "2")
            {
                Console.WriteLine($"Você escolheu {nome2}, com poder {poder2} e pontuação {pont2}");
                if (escolha1 == "")
                {
                    escolha1 = nome2;
                    poderEscolha1 = poder2;
                    pontEscolha1 = pont2;
                }
                else if (escolha2 == "")
                {
                    escolha2 = nome2;
                    poderEscolha2 = poder2;
                    pontEscolha2 = pont2;
                }
                else if (escolha3 == "")
                {
                    escolha3 = nome2;
                    poderEscolha3 = poder2;
                    pontEscolha3 = pont2;
                }
                i++;
            }
            else if (entrada == "3")
            {
                Console.WriteLine($"Você escolheu {nome3}, com poder {poder3} e pontuação {pont3}");
                if (escolha1 == "")
                {
                    escolha1 = nome3;
                    poderEscolha1 = poder3;
                    pontEscolha1 = pont3;
                }
                else if (escolha2 == "")
                {
                    escolha2 = nome3;
                    poderEscolha2 = poder3;
                    pontEscolha2 = pont3;
                }
                else if (escolha3 == "")
                {
                    escolha3 = nome3;
                    poderEscolha3 = poder3;
                    pontEscolha3 = pont3;
                }
                i++;
            }
            else if (entrada == "4")
            {
                Console.WriteLine($"Você escolheu {nome4}, com poder {poder4} e pontuação {pont4}");
                if (escolha1 == "")
                {
                    escolha1 = nome4;
                    poderEscolha1 = poder4;
                    pontEscolha1 = pont4;
                }
                else if (escolha2 == "")
                {
                    escolha2 = nome4;
                    poderEscolha2 = poder4;
                    pontEscolha2 = pont4;
                }
                else if (escolha3 == "")
                {
                    escolha3 = nome4;
                    poderEscolha3 = poder4;
                    pontEscolha3 = pont4;
                }
                i++;
            }
            else if (entrada == "5")
            {
                Console.WriteLine($"Você escolheu {nome5}, com poder {poder5} e pontuação {pont5}");
                if (escolha1 == "")
                {
                    escolha1 = nome5;
                    poderEscolha1 = poder5;
                    pontEscolha1 = pont5;
                }
                else if (escolha2 == "")
                {
                    escolha2 = nome5;
                    poderEscolha2 = poder5;
                    pontEscolha2 = pont5;
                }
                else if (escolha3 == "")
                {
                    escolha3 = nome5;
                    poderEscolha3 = poder5;
                    pontEscolha3 = pont5;
                }
                i++;
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }

    static int ponttotal(int pontEscolha1, int pontEscolha2, int pontEscolha3)
    {
        int total = pontEscolha1 + pontEscolha2 + pontEscolha3;
        return total;
    }

    static void exibir(string escolha1, string escolha2, string escolha3, string poderEscolha1, string poderEscolha2, string poderEscolha3)
    {
        Console.WriteLine("Você escolheu os seguintes heróis:");
        Console.WriteLine($"1ª Escolha: {escolha1} (Poder: {poderEscolha1})");
        Console.WriteLine($"2ª Escolha: {escolha2} (Poder: {poderEscolha2})");
        Console.WriteLine($"3ª Escolha: {escolha3} (Poder: {poderEscolha3})");
        int total = ponttotal(pontEscolha1, pontEscolha2, pontEscolha3);
        Console.WriteLine("Pontuação total da equipe: " + total);
    }
}