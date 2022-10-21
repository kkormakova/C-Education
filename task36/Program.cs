// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер случайного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Console.WriteLine("Наш случайный массив: ");
FillAndPrintArray(numbers);
Console.WriteLine();
int sumEl = 0; //Если не включая 0 элемент массива
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        sumEl = sumEl + numbers[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumEl}");

void FillAndPrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
}