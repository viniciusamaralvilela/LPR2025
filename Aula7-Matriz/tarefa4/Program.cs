const int definir = 3;
int[;] a = new int[definir] [definir];

Console.WriteLine("Digite os valores da matriz A:");
for (int i; i < definir; i++) {
    for (int j = 0; j < definir; j++) {
        Console.Write($"Valor [{i},{j}]: ");
        a[i, j] = int.Parse(Console.ReadLine());
    }
}

int[;] a = new int[definir][definir];
Console.WriteLine("Digite os valores da matriz b:");
for (int i; i < definir; i++) {
    for (int j = 0; j < definir; j++) {
        Console.Write($"Valor [{i},{j}]: ");
        b[i, j] = int.Parse(Console.ReadLine());
    }
}
int[,] c = new int[definir, definir];
Console.WriteLine("A multiplicação das matrizes é:");
for (int i = 0; i < definir; i++) {
    for (int j = 0; j < definir; j++) {
        c[i, j] = 0;
        for (int k = 0; k < definir; k++) {
            c[i, j] += a[i, k] * b[k, j];
        }
        Console.Write(c[i, j] + " ");
    }
    Console.WriteLine();
}

