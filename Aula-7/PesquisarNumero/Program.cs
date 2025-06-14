static void main(string[] args)
{
    int[] numeros = new int[10];
    Console.WriteLine("Digite 10 numeros: ");
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Numero {i + 1}: ");
        numeros[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Gostaria de pesquisar qual numero?");
    int numeroPesquisa = int.Parse(Console.ReadLine());
    bool encontrado = false;
    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] == numeroPesquisa)
        {
            Console.WriteLine($"O numero {numeroPesquisa} foi encontrado na posicao {i + 1}");
            encontrado = true;
            break;
        }
    }

}