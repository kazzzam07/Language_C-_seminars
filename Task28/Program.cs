// Задача 24: Напишите программу, которая принимает на входчисло (N)
// и выдает произведение чисел от 1 до N
// 5 -> 120
// 4 -> 24

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) Console.WriteLine($" Произведение чисел от 1 до {number} -> {CompNumbers(number)}");

int CompNumbers(int num)
{
    int comp = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            comp = comp * i;
        }
    }
    return comp;
}

