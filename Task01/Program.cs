Console.WriteLine("Является ли первое число квадратом второго");
Console.WriteLine("Введите первое число");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB*numberB)
{
    Console.WriteLine("Является");
}
else 
{
   Console.WriteLine("Не является"); 
}