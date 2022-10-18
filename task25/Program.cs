// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число, которое нужно возвести в степень: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень, в которую нужно возвести число: ");
int b = int.Parse(Console.ReadLine());
double result = 1;
for (int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine($"{a} в степени {b} = {result}");