using System.Formats.Asn1;

namespace Program
{
    class Program
    {
        public struct Produto
        {
            public string nome;
            public int codigo;
            public double valor;
            public int quantidade;
        };

        static void Main(string[] args)
        {
            Produto[] inserir = new Produto[3];
            double soma = 0;
            for (int i = 0; i < inserir.Length; i++)
            {
                Console.WriteLine("Digite o nome do produto");
                inserir[i].nome = Console.ReadLine();
                Console.WriteLine("Digite o código do produto");
                inserir[i].codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do produto");
                inserir[i].valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade desejada");
                inserir[i].quantidade = int.Parse(Console.ReadLine());
                soma += inserir[i].valor * inserir[i].quantidade;
            }
            Console.WriteLine($"O valor total em estoque é:" + soma);

            for (int i = 0; i < inserir.Length; i++)
            {
                Console.WriteLine($"A quantidade é:" + inserir[i].quantidade);
                Console.WriteLine("Do produto:" + inserir[i].nome);
                Console.WriteLine($"O valor unitario:" + inserir[i].valor);   
            }
        }
    }
}

