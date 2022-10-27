// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine());
double[,] array = FillArray(rows, columns);
PrintArray(array);

double[,] FillArray(int r, int c)
{
    double[,] result = new double[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = new Random().Next(0, 1000);
        }
    }
    return result;
}

void PrintArray(double[,] newArray)
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