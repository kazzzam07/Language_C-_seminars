// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите натуральное число -> ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int count = Convert.ToString(num).Length;
    int advance = 0;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        advance = num - num % 10;
        sum = sum + (num - advance);
        num = num / 10;
    }
    return sum;
}

int sumNum = SumNumbers(number);
Console.WriteLine($"Cуммa цифр в числе {number} -> {sumNum}");




