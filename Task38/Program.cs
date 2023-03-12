// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }

    return arr;
}
 
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double DefferenceMaxMinElement(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
    }
    double def = max - min;
    return def;
}

double[] array = CreateArrayRndDouble(10, 0, 10);
PrintArray(array);
double defferenceMaxMinElement = Math.Round(DefferenceMaxMinElement(array), 1);
Console.Write($"Pазницa между максимальным и минимальным элементов массива -> {defferenceMaxMinElement}");

