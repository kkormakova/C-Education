// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberThree = int.Parse(Console.ReadLine());
int max = numberOne;
if (max < numberTwo)
{
    max = numberTwo;
}
else if (max < numberThree)
{
    max = numberThree;
}
Console.WriteLine("Максимальное из введенных чисел: " + max);
