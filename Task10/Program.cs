// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Трехзначное число -> ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 & number < 1000)
{
    int secDig = SecondDigit(number);
    Console.WriteLine($"Вторая цифра -> {secDig}");
}
else Console.WriteLine("Не трехзначное число");


int SecondDigit(int num)
{
    num = num / 10;
    num = num % 10;
    return num;
}
