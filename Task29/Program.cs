// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd .Next(0, 100);
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}");
        if (i<count-1) Console.Write(",");
    }
Console.Write(" -> ");
}

void PrintArray2(int[] arr)
{
    Console.Write("[");
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}");
        if (i<count-1) Console.Write(",");
    }
    Console.Write("]");
}


FillArray(array);
PrintArray(array);
PrintArray2(array);
