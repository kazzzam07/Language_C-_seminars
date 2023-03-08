// Задача 24: Напишите программу, которая принимает на входчисло (А)
// и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNum = SumNumbers(number);

Console.WriteLine($" Сумма чисел от 1 до {number} -> {sumNum}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
