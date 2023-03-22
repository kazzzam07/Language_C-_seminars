// // Задача 52. Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

// double ArithmeticMean(int[,] matrix)
// {
//     double arithmeticMean = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             arithmeticMean += matrix[j, i];
//         }
//         arithmeticMean = Math.Round(arithmeticMean / matrix.GetLength(0), 1);
//     }
//     return arithmeticMean;
// }

// void ArithmeticMeanEachColumns(int[,] matrix)
// {
//     Console.WriteLine($"Cреднее арифметическое:");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.WriteLine($"столбца № {i + 1} -> {ArithmeticMean}");
//     }
// }

//  с рекурсией не понял где конвертацию делать


void ArithmeticMean (int[,] matrix)
{
Console.WriteLine($"Cреднее арифметическое:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    arithmeticMean += matrix[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / matrix.GetLength(0), 1);
  Console.WriteLine($"столбца № {i+1} -> {arithmeticMean}");
}
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);
ArithmeticMean(array2d);
// ArithmeticMeanEachColumns(array2d);

