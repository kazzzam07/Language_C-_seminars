// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
 
void InputNumbers (int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i+1} число ");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int AmountPositiveNumbers (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0) count++;
    }
    return count;
}

Console.Write("Введиде количество чисел -> ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[m];

InputNumbers(m);
Console.WriteLine();
PrintArray(arrayNumbers);
int amountPositiveNumbers = AmountPositiveNumbers(arrayNumbers);
Console.Write($"Колличество положительных чисел -> {amountPositiveNumbers}");