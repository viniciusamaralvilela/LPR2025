using MathNet.Numerics.LinearAlgebra;

int[,] A = new int[,] {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

for(int i = 0; i < A.GetLength(0); i++) {
    for(int j = 0; j < A.GetLength(1); j++) {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
int[,] B = new int[,] {
    {9, 8, 7},
    {6, 5, 4},
    {3, 2, 1}
};
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
int c = A * B;
Console.WriteLine("Resultado da multiplicação:");
for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
    {
        Console.Write(c[i, j] + " ");
    }
    Console.WriteLine();
}


