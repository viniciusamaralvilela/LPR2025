internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine("O numero eh par");
        }
        else
        {
            Console.WriteLine("O numero eh impar");
        }
    }
}

