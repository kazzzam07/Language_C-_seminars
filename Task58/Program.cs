// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool MatrixCheck(int[,] firstMartrix, int[,] secomdMartrix)
{
    if (firstMartrix.GetLength(1) == secomdMartrix.GetLength(1)) return true;
    else return false;
}

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix)
{
    int[,] resultMatrix = new int[firstMartrix.GetLength(0), secomdMartrix.GetLength(1)];
    for (int i = 0; i < firstMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < secomdMartrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += firstMartrix[i, k] * secomdMartrix[k, j];
            }
        }
    }
    return resultMatrix;
}

int[,] array2d1 = CreateMatrixRndInt(3, 3, 1, 10);
Console.WriteLine("Первая матрица");
PrintMatrix(array2d1);

int[,] array2d2 = CreateMatrixRndInt(3, 3, 1, 10);
Console.WriteLine("Вторая матрица");
PrintMatrix(array2d2);

if (MatrixCheck(array2d1, array2d2)) 
{
int[,] multiplyMatrix = MultiplyMatrix(array2d1, array2d2);
Console.WriteLine($"Произведение матриц");
PrintMatrix(multiplyMatrix);
}
else Console.WriteLine($"Произведение матриц не возможно");
// Console.WriteLine("Произведение матриц");






