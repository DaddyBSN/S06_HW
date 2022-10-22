// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.WriteLine("Введи количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введи количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(1, 9);
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

void PrintMatrixSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i + 1) % 2 == 0 && j % 2 == 1)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrixSquare(matrix);