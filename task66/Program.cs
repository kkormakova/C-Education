// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
temp = 0;
FindSum(m, n, temp);

void FindSum(int m, int n, int sum)
{
    sum += n;
    if (n <= m)
    {
        Console.Write($"Сумма чисел от M до N = {sum}");
        return;
    }
    FindSum(m, n - 1, sum);
}