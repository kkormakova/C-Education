// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк для создания прямоугольного двумерного массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для создания прямоугольного двумерного массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = FillArray(rows, columns);
PrintArray(array);
Console.WriteLine();
int minSumLine = 0;
int sumLine = FindSumLine(array, minSumLine);
for (int i = 0; i < array.GetLength(0); i++)
{
    int temp = FindSumLine(array, i);
    if (sumLine > temp)
    {
        sumLine = temp;
        minSumLine = i;
    }
}
Console.WriteLine($"Строка {minSumLine + 1} с наименьшей суммой элементов");

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
int FindSumLine(int[,] arr, int i)
{
    int sumLine = arr[i, 0];
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        sumLine += arr[i, j];
    }
    return sumLine;
}