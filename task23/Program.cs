// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до N: ");
for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"Куб числа {i} = {i * i * i}");
}