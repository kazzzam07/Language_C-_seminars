// Array.Sort(array);
// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// int[,] Create2DimArray(int hight, int length, int min, int max)
// {
//     int[,] int2DArray = new int[hight, length];

//     for (int i = 0; i < hight; i++)
//     {
//         for (int j = 0; j < length; j++)
//         {
//             int2DArray[i, j] = new Random().Next(min, max);
//         }
//     }

//     return int2DArray;
// }

// void Print2DArray(int[,] int2DArray)
// {

//     for (int i = 0; i < int2DArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < int2DArray.GetLength(1); j++)
//         {
//             Console.Write($"{int2DArray[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// //Вспомогательные методы

// bool isInArray(int value, int[,] int2DArray) //  проверка если элемент в массиве
// {
//     foreach (int item in int2DArray)
//     {
//         if (item == value) return true;
//     }
//     return false;
// }

// int countArrayElement(int value, int[,]int2DArray)//сколько элементов в массиве
// {
//     int counter = 0;
//     foreach (int item in int2DArray)
//     {
//         if (value == item) counter++;
//     }
//     return counter;
// }


// int[,] GetFrequencyArray(int[,] int2DArray)
// {
//     int[,] frequencyArray = new int[int2DArray.Length, 2];
//     int element = 0;

//     // для проверки, если в исходном массиве появиться "0"
//     int zeroElement = 0;

//     foreach (int item in int2DArray)
//     {
//         // изначально frequencyArray состоит из 0, поэтому исключаем еще и "item = 0"
//         // обработаем их дальше в else if
//         if (!isInArray(item, frequencyArray) && item != 0)
//         {
//             frequencyArray[element, 0] = item;
//             frequencyArray[element, 1] = countArrayElement(item, int2DArray);
//         }
//         else if(item == 0 && zeroElement == 0)
//         {
//             frequencyArray[element, 1] = countArrayElement(item, int2DArray);
//             zeroElement++;
//         }
//         element++; 
//     }

//     return frequencyArray;
// }

// void PrintFrequencyArray(int[,] frequencyArray) // вывод частотного массива на консоль
// {
//     for (int i = 0; i < frequencyArray.GetLength(0); i++)
//     {
//         if(frequencyArray[i,1] != 0)
//             Console.WriteLine($"{frequencyArray[i,0]} встречается {frequencyArray[i,1]} раз");
//     }
// }

// int[,] myArray = Create2DimArray(3, 5, -2, 3);
// Print2DArray(myArray);
// int[,] myFrArray = GetFrequencyArray(myArray);
// PrintFrequencyArray(myFrArray);

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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i],3} ");
    }
    Console.WriteLine();
}

void PrintFrequencyDictionary(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine($"{matrix[i,0]} встречается {matrix[i,1]} раз(а)");
    }
}

int[] ConvertMatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

int CountUniqueElements(int[] array)
{
    int value = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (value != array[i])
        {
            value = array[i];
            count++;
        }
    }
    return count;
}

int[,] FrequencyDictionary(int[] array)
{
    int[,] dictionary = new int[CountUniqueElements(array), 2];
    int value = array[0];
    int count = 1;
    int numberElem = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (value == array[i]) count++;
        else
        {
            dictionary[numberElem, 0] = value;
            dictionary[numberElem, 1] = count;
            value = array[i];
            count = 1;
            numberElem++;
        }
    }
    dictionary[numberElem, 0] = value;
    dictionary[numberElem, 1] = count;
    return dictionary;
}

int[,] arr2d = CreateMatrixRndInt(3, 3, 0, 5);
Console.WriteLine("Исходная матрица:");
PrintMatrix(arr2d);
Console.WriteLine();
int[] arr = ConvertMatrixToArray(arr2d);
Console.WriteLine("Матрица в виде одномерного массива:");
PrintArray(arr);
Console.WriteLine();
Array.Sort(arr);
Console.WriteLine("Матрица в виде отсортированного массива:");
PrintArray(arr);
Console.WriteLine();
int[,] frequencyDictionary = FrequencyDictionary(arr);
PrintFrequencyDictionary(frequencyDictionary);