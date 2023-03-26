﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



int PowNumber(int numA, int numB)
{
if (numB == 0) return 1;
return numA * PowNumber(numA, numB - 1);
}

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = PowNumber(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");

// double PowNumber(int numA, int NumB)
// {
// if (NumB < 0)
// {
// return 1 / (numA / PowNumber(numA, NumB + 1));
// }
// else if (NumB > 0)
// {
// return numA * PowNumber(numA, NumB - 1);
// }
// else return 1;
// }

// Console.Write("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.Write(PowNumber(numberA,numberB));