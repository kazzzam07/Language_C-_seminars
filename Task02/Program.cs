// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Input number A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number B");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Больше число - {numberA}, меньшее число - {numberB}");
}
else
{
    Console.WriteLine($"Больше число - {numberB}, меньшее число - {numberA}");
}

