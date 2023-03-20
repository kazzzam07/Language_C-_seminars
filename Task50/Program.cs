// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
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

void OutputElement(int[,] matrix, int[] positionElem)
{
    if (positionElem[i] >= 0 && positionElem[j] >= 0 &&
    positionElem[i] <= matrix.GetLength(0) && positionElem[j] <= matrix.GetLength(1))
    {
        int result = 
    }
    else Console.Write("Такого элемента в массиве нет")

}

int[,] array2d = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2d);
Console.Write("Веедите позиции элемента через запятую");
string positionElement = Console.ReadLine();
// positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);


