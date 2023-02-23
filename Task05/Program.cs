Console.WriteLine("Введите натуральное число");

int number = Convert.ToInt32(Console.ReadLine());

if(number > 0)
{
    int count = -number;
    while(count <= number)
    {
        Console.Write(count + " ");
        count = count + 1;
    }
}
else
{
    Console.WriteLine("Введено ненатуральное число");
}