// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы: ");
int rowFirst = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int columnFirst = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строй второй матрицы: ");
int rowSecond = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столцов второй матрицы: ");
int columnSecond = int.Parse(Console.ReadLine());
if (columnFirst != rowSecond)
{
    Console.WriteLine("Это не согласованные матрицы, произведение их не возможно!");
}
else
{
    int[,] firstMatrix = new int[rowFirst, columnFirst];
    FillArray(firstMatrix);
    Console.WriteLine("Первая матрица: ");
    PrintArray(firstMatrix);
    Console.WriteLine();
    int[,] secondMatrix = new int[rowSecond, columnSecond];
    FillArray(secondMatrix);
    Console.WriteLine("Вторая матрица: ");
    PrintArray(secondMatrix);
    Console.WriteLine();
    int[,] resultMatrix = new int[rowFirst, columnSecond];
    MultMatrix(firstMatrix, secondMatrix, resultMatrix);
    Console.WriteLine("Произведение первой и второй матрицы равно: ");
    PrintArray(resultMatrix);
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
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
void MultMatrix(int[,] first, int[,] second, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < first.GetLength(1); k++)
            {
                sum += first[i, k] * second[k, j];
            }
            result[i, j] = sum;
        }
    }
}