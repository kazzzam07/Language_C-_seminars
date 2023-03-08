// Задача26: Напишите программу которая принимает на вход число
// и выдвет количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"количество цифр в числе {number} -> {CountDigit(number)}");


int CountDigit(int num)
{
    int count = 0;
    do
    {
        num = num / 10;
        count++;
    }
    while (num != 0);
    return count;
}

