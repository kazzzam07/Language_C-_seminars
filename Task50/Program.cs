﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void OutputElement(int[,] matrix, int pos1, int pos2)
{

    if (pos1 >= 0 && pos2 >= 0 &&
    pos1 <= matrix.GetLength(0) && pos2 <= matrix.GetLength(1))
    {
         Console.Write($"Элемент с позициями {pos1},{pos2} -> {matrix[pos1, pos2]}");
    }
    else Console.Write("Такого элемента в массиве нет");

}

int[,] array2d = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2d);
Console.Write("Введите позицию строки -> ");
int position1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца -> ");
int position2 = Convert.ToInt32(Console.ReadLine());
OutputElement(array2d, position1, position2);