// Задача30: напишите программу, которая выводит массив из 8 элементов,
// заполненый нулями и единицами в лучайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd .Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i] },");
    }
}

FillArray(array);
PrintArray(array);