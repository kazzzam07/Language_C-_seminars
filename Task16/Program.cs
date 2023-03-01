// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Первое число -> ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число -> ");
int number2 = Convert.ToInt32(Console.ReadLine());

// int square1 = number1 * number1;
// int square2 = number2 * number2;

// if (number1 == square2) Console.WriteLine("+");
// if (number2 == square1) Console.WriteLine("+");
// else Console.WriteLine("-");

Console.WriteLine (SquareMetod(number1, number2)? "+":"-");

bool SquareMetod (int num1, int num2)
{
    return num1 == num2*num2 || num2 == num1*num1;
}