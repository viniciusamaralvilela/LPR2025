using System;
using System.Collections.Generic;
namespace Program
{
    class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            numeros.Add(4);
            numeros.Insert(3, 7);
            bool contemoito = numeros.Contains(8);
            Console.WriteLine($"Contém o oito?" + contemoito);
            int maiorquatro = 0;
            int ntres = 0;
            foreach (int n in numeros)
            {
                if (n > 4)
                {
                    Console.WriteLine(numeros);
                    maiorquatro++;

                }
                if (n == 3)
                {
                    ntres++;
                }
            }
            Console.WriteLine(maiorquatro + " " + "são maiores do que 4");
            Console.WriteLine($"Aparece o numero 3" + " " + ntres + " " + "vezes");
            numeros.Remove(2);
            numeros.Remove(4);
            numeros.Remove(4);
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
