﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число для проверки: ");
int testNumber = int.Parse(Console.ReadLine());
if (testNumber % 2 == 0)
{
    Console.WriteLine("Введенное число четное");
}
else
{
    Console.WriteLine("Введенное число нечетное");
}