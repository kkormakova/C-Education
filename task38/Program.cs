// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер случайного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
Console.WriteLine("Наш случайный массив: ");
FillAndPrintArray(numbers);
Console.WriteLine();
double min = numbers[0];
double max = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"Максимальный элемент массива = {max}");
Console.WriteLine($"Минимальный элемент массива = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");


void FillAndPrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
}