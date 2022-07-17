// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


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

void PrintMatrixElement(int[,] mtrx, int m, int n)
{
    if (m !< 0 || n !< 0 || m < mtrx.GetLength(0) || n < mtrx.GetLength(1)) Console.WriteLine(mtrx[m, n]);
    else Console.WriteLine("такого числа в массиве нет");
}

int [,] matrix = GetMatrix(3, 4, -9, 9);
ShowMatrix(matrix);
PrintMatrixElement(matrix, 2, 1);