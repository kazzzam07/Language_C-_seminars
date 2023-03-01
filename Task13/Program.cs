// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next();
Console.WriteLine($"Число -> {number}");

if (number < 100) Console.WriteLine("третьей цифры нет");
else
{
    while (number >= 999)
    {
        number = number / 10;
    }
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine($"Thirt digit -> {thirdDigit}");
}

int ThirdDigit(int num)
{
    return num % 10;
}