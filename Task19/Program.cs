// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>9999&&number<100000) 
{
    if(number == ReversNumber(number)) Console.WriteLine ("Число является палиндромом");
    else Console.WriteLine ("Число не является палиндромом");
}
else
{
  Console.WriteLine ("Число не пятизначное");  
}


int ReversNumber(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res * 10 + num % 10;
        num /= 10;
    }
    return res;
  }

// Console.WriteLine (ReversNumber(number));