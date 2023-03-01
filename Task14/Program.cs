// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Число -> ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0)
// {
//     if (number % 23 == 0) Console.WriteLine("Кратно");
// }
// else Console.WriteLine ("Не кратно");


Console.WriteLine (MetodMulti(number)? "Кратно":"Не кратно");


bool MetodMulti(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}