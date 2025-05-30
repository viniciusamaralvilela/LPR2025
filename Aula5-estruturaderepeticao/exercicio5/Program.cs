internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o numero de horas por dia do seu treinamento");
        double horas = Convert.ToDouble(Console.ReadLine());
        bool quebra = true; //quebra para nao ficar repetindo toda hora;
        while (quebra) //do while pois ele repete uma vez. 
        {
            double dias = 1000 / horas;
            Console.WriteLine("Você precisa treinar " + dias + " dias para atingir a meta");
            double semanas = dias / 5;
            Console.WriteLine("Você precisa treinar " + semanas + " semanas para atingir a meta");
            double meses = semanas / 4.5;
            Console.WriteLine("Você precisa treinar " + meses + " meses para atingir a meta");
            quebra = false;
        }

    }
}

