﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5     7    -2    -0,2
//   1   3,3     8    -9,9
//   8   7,8  -7,1       9

Console.Write("Введите количество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());

double[,] array2D = new double[linesVol, columnsVol];

void FillMatrixRandomNumbers(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}  ");
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine();
FillMatrixRandomNumbers(array2D);
PrintMatrix(array2D);