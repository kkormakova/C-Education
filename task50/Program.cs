// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Console.WriteLine("Введите количество столбцов для создания двумерного массива: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк для создания двумерного массива: ");
int rows = int.Parse(Console.ReadLine());
int[,] array = FillArray(rows, columns);
Console.WriteLine("Введите строку искомого элемента: ");
int elRow = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец искомого элемента: ");
int elCol = int.Parse(Console.ReadLine());
if (elRow > rows || elCol > columns)
{
    Console.WriteLine("Такого элемента не существует!");
}
else
{
    PrintArray(array);
    Console.WriteLine($"Значение искомого элемента = {array[elRow, elCol]}");
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