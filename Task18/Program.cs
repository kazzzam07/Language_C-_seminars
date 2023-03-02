//Зачадча 18 Программа по заданному номеру четверти показывает диапазон

Console.WriteLine("Введите номер четверти");
string numQuarter = Console.ReadLine();
Console.WriteLine(Range(numQuarter));

string Range(string num)
{
    if (num == "1") return "x > 0, y > 0";
    if (num == "2") return "x < 0, y > 0";
    if (num == "3") return "x < 0, y < 0";
    if (num == "4") return "x > 0, y < 0";
    return "Введен некорректный номер";
}