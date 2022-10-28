// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество столбцов для создания двумерного массива: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк для создания двумерного массива: ");
int rows = int.Parse(Console.ReadLine());
int[,] array = FillArray(rows, columns);
PrintArray(array);
Console.WriteLine();
int result = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"Среднее арифметическое столбца {j} = {sum / array.GetLength(0)} ");
}

int[,] FillArray(int r, int c)
{
    int[,] result = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = new Random().Next(0, 1000);
        }
    }
    return result;
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }
}