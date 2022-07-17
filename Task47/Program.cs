// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] GetMatrix(int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
            matrix[i, j] += rnd.NextDouble();
        }
    }
    return matrix;
}

void ShowMatrix (double[,] value)
{
    for (int i = 0; i < value.GetLength(0); i++)
    {
        for (int j = 0; j < value.GetLength(1); j++)
        {
            if(j == 0) Console.Write(" | ");
            Console.Write($"{Math.Round(value[i, j], 1), 4} | ");
        }
        Console.WriteLine();
    }
}

double[,] result = GetMatrix(3, 4, -9, 9);
ShowMatrix(result);