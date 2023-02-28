// Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");

int delSecondNum = DelSecondNum(number);
Console.WriteLine($"Двухзначное число -> {delSecondNum}");

// int firstDigit = number / 100;
// int thidDigit = number % 10;
// Console.WriteLine($"Двухзначное число -> {firstDigit}{secondDigit}");


int DelSecondNum(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}