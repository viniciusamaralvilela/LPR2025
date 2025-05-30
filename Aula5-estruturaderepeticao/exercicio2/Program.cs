internal class Program
{
    static void Main(string[] args)
    {
        //utilizamos o do while para verificar pelo menos uma vez. Ele vai executar o bloco de código e depois verificar a condição. O DO sera executado enquanto tiver dentro da condição do while. Por exemplo, mandei fazer a verificação para ver se é maior ou menor, se ele for diferente como edta escrito no while, ele repete o DO
        
        int contador = 0;
        Console.WriteLine("Digite um numero");
        int num = Convert.ToInt32(Console.ReadLine());
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1, 101);
        do
        {
            if (num < valorInteiro)
            {
                Console.WriteLine("Você chutou baixo");
            }
            else
            {
                Console.WriteLine("Você chutou alto");
             
            }

                contador++;
                Console.WriteLine("Digite outro número");
                num = Convert.ToInt32(Console.ReadLine()); //atualiza o numero
        }
        while(num != valorInteiro);
        Console.WriteLine("Você acertou em " + contador + " tentativas");
    }
}


