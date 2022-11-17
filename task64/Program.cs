// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до N: ");
int count = 2;
CheckNumber(n, count);

void CheckNumber(int number, int count)
{
    if (count < number)
    {
        if (count % 2 == 0)
        {
            Console.Write($"{count} ");
        }
        CheckNumber(number, count + 1);
    }
}
