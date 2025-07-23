using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main()
        {
            List<string> nome = new();
            Console.WriteLine("Digite quantos nomes você deseja digitar");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                nome.Add(Console.ReadLine());
            }

            string[] tamanho = nome.ToArray();
            string[] mostrar = new string[quant];

            int tam = 1; 
            int pos = 0; 

            while (pos < quant) 
            {
                for (int i = 0; i < quant; i++)
                {
                    if (tamanho[i].Length == tam)
                    {
                        mostrar[pos] = tamanho[i];
                        pos++;
                    }
                }
                tam++; 
            }

            Console.WriteLine("\nNomes ordenados por comprimento:");
            for (int i = 0; i < quant; i++)
            {
                Console.Write(mostrar[i] + ",");
            }
        }
    }
}
