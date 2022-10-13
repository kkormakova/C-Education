// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x координату точки А: ");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y координату точки А: ");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z координату точки А: ");
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x координату точки B: ");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y координату точки B: ");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z координату точки B: ");
int bz = int.Parse(Console.ReadLine());
double result = Math.Round(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)), 2);
Console.WriteLine("Расстояние между точками A и B в 3D пространстве = " + result);
