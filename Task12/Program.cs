// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Первое число -> ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число -> ");
int number2 = Convert.ToInt32(Console.ReadLine());

// int div = number1 % number2;
// if (div == 0) Console.WriteLine("Кратно");
// else Console.WriteLine($"Остаток от деления -> {div}");

int numMulti = MultiNumbers(number1, number2);

// string result = numMulti == 0 ? "Кратно" : $"Остаток от деления -> {numMulti}";
// Console.WriteLine(result);

Console.WriteLine(numMulti == 0 ? "Кратно" : $"Остаток от деления -> {numMulti}");


int MultiNumbers(int num1, int num2)
{
    return num1 % num2;
}