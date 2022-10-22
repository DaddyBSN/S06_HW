// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.WriteLine("Введи количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введи количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = i + j;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);