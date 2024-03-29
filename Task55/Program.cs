﻿// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
bool IsSquareMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

// void TransposeMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0) - 1; i++)
//     {
//         for (int j = 0; j < i; j++)
//         {
//             int temp = matrix[j, i];
//             matrix[j, i] = matrix[i, j];
//             matrix[i, j] = temp;
//         }
//     }
// }

void TransposeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[j, i];
            matrix[j, i] = matrix[i, j];
            matrix[i, j] = temp;
        }
    }
}

int[,] array = CreateMatrixRndInt(4, 4, 0, 20);
PrintMatrix(array);
Console.WriteLine();
if (IsSquareMatrix(array))
{
    TransposeMatrix(array);
    PrintMatrix(array);
}
else Console.WriteLine("Введена не квадртаная матрица");

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j],4} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CreateNewArray(int[,] arr)
// {
//     int[,] matrix = new int[arr.GetLength(1), arr.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = arr[j, i];
//         }
//     }
//     return matrix;
// }

// int[,] matrix = CreateMatrixRndInt(2, 4, 0, 11);
// PrintArray(matrix);
//     int[,] newMatrix = CreateNewArray(matrix);
//     Console.WriteLine();
    PrintArray(newMatrix);