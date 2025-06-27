using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Program
    {
        public struct Heroi
        {
            public string nome;
            public string poder;
            public int pontuacao;
        }
        static Heroi[] inserir = new Heroi[5];
        static Heroi[] equipe = new Heroi[3];
        static public int pontuacao;
        static void Main()
        {
            menu();
            cadastrar();
            selecao();
            exibir();
            pont();
        }
        static void menu()
        {
            Console.WriteLine("Bem-Vindo ao menu!! Escolha o que voc~e quer checar");
            Console.WriteLine("Digite o numero que antecede a opcção para validar sua escolha");
            Console.WriteLine("1 - Cadastre seu heroi");
            Console.WriteLine("2 - Seleção da equipe");
            Console.WriteLine("3 - Exibir equipe");
            Console.WriteLine("4 - Pontuação da equipe");
            Console.WriteLine("5 - Fechar programa");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    cadastrar();
                    break;
                case 2:
                    selecao();
                    break;
                case 3:
                    exibir();
                    break;
                case 4:
                    int resultado = pont();
                    Console.WriteLine("Pontuação total da equipe: " + resultado);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Digite um numero certo");
                    break;
            }

        }
        static void cadastrar()
        {
            Console.WriteLine("Digite 0 caso queira voltar ao menu!! Caso não queira, digite qualquer coisa diferente de zero");
            int v = int.Parse(Console.ReadLine());
            while (v == 0)
            {
                menu();
            }
            Console.WriteLine("Cadastre 5 herois");
            for (int i = 0; i < inserir.Length; i++)
            {
                Console.WriteLine($"\nCadastro do herói #{i + 1}:");
                Console.WriteLine("Digite o nome do personagem");
                inserir[i].nome = Console.ReadLine();
                Console.WriteLine("Digite o poder do personagem");
                inserir[i].poder = Console.ReadLine();
                Console.WriteLine("Digite a pontuação do personagem");
                inserir[i].pontuacao = int.Parse(Console.ReadLine());
            }

        }
        static void selecao()
        {

            Console.WriteLine("Digite 0 caso queira voltar ao menu!! Caso não queira, digite qualquer coisa diferente de zero");
            int v = int.Parse(Console.ReadLine());
            while (v == 0)
            {
                menu();
            }
            Console.WriteLine("Escolha três personagens para montar a sua equipe");
            for (int i = 0; i < inserir.Length; i++)
            {
                Console.WriteLine($"Personagem: {i + 1}");
                Console.WriteLine(inserir[i].nome);
                Console.WriteLine(inserir[i].poder);
                Console.WriteLine(inserir[i].pontuacao);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Escolha o heroi");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha > 0 && escolha < inserir.Length)
                {
                    equipe[i] = inserir[escolha - 1];
                }
            }

        }
        static void exibir()
        {

            Console.WriteLine("Digite 0 caso queira voltar ao menu!! Caso não queira, digite qualquer coisa diferente de zero");
            int v = int.Parse(Console.ReadLine());
            while (v == 0)
            {
                menu();
            }
            for (int i = 0; i < equipe.Length; i++)
            {
                Console.WriteLine(equipe[i].nome);
                Console.WriteLine(equipe[i].poder);
                Console.WriteLine(equipe[i].pontuacao);
            }
        }
        static public int pont()
        {
            for (int i = 0; i < equipe.Length; i++)
            {
                pontuacao += equipe[i].pontuacao;
            }
            return pontuacao;
        }
    }
}
