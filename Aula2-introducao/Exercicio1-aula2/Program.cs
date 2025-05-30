 internal class Program 
    {
        static void Main(string[] args)
          {
           //Dê um valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
           const float pi = 3.14159f;
           Console.WriteLine("Atribua um valor para o raio");
           float r = float.Parse(Console.ReadLine());
           float area = (r * r) * pi;
           Console.WriteLine($"O valor da area deste circulo é de {area}");
          }
    }