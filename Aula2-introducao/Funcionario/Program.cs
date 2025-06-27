internal class Program 
    {
        static void Main(string[] args)
          {
           //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcule o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
           Console.WriteLine("Qual o nome do funcionario?");
           string nome = Console.ReadLine();
           Console.WriteLine("Quantas horas ele/ela trabalhou?");
           float hr = float.Parse (Console.ReadLine());
           Console.WriteLine("Qual o valor por hora?");
           float vh = float.Parse (Console.ReadLine());
           float salario = vh * hr;
           Console.WriteLine($"O salario do/da {nome} neste mes foi de {salario} reais.");

          }
    }