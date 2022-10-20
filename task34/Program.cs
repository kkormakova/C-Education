// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер случайного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Console.WriteLine("Наш случайный массив: ");
FillAndPrintArray(numbers);
Console.WriteLine();
int count = 0;
foreach (int el in numbers)
{
    if (el % 2 == 0) count++;
}
Console.WriteLine($"Количество четных чисел в массиве = {count}");

void FillAndPrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}