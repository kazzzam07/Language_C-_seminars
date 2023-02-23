// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Input number A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number B");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number C");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB>max) max=numberB;
if (numberC>max) max=numberC;

Console.WriteLine($"Max numbers = {max}");


