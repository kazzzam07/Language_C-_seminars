// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите натуральное число A -> ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B -> ");
int numberB = Convert.ToInt32(Console.ReadLine());

int ExponentiationNum(int numA, int numB)
{
    int exp = 1;
    for (int i = 1; i <= numB; i++)
    {
        exp = exp * numA;
    }
    return exp;
}

int exponentiationNum = ExponentiationNum(numberA, numberB);
Console.WriteLine($"Число {numberA} в натуральной степени числа {numberB} -> {exponentiationNum}");