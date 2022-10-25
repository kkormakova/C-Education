// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine());
PointCrossPrint(b1, b2, k1, k2);

void PointCrossPrint(int p1, int p2, int d1, int d2)
{
    double x = -(p1 - p2) / (d1 - d2);
    double y = d1 * x + p1;
    Console.WriteLine($"Точка пересечения прямой b и k => ({x} ; {y})");
}