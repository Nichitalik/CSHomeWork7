// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void ShowMatrix (int[,] value)
{
    for (int i = 0; i < value.GetLength(0); i++)
    {
        for (int j = 0; j < value.GetLength(1); j++)
        {
            if(j == 0) Console.Write(" | ");
            Console.Write($"{value[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

void PrintArithmeticMean(int[,] mtrx)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < mtrx.GetLength(1); i++)
    {
        float result = 0;

        for (int j = 0; j < mtrx.GetLength(0); j++)
        {
            result += mtrx[j, i];
        }

        result /= mtrx.GetLength(0);
        System.Console.Write(result);

        if (i < mtrx.GetLength(0))
        {
            System.Console.Write("; ");
        }
    }
}


int [,] matrix = GetMatrix(3, 4, 1, 9);
ShowMatrix(matrix);
PrintArithmeticMean(matrix);