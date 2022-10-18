// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
if (n == 0)
{
    Console.WriteLine("Сумма цифр введенного числа = 0");
}
else
{
    while (n > 0)
    {
        int digit = n % 10;
        sum = sum + digit;
        n = n / 10;
    }
    Console.WriteLine($"Сумма цифр введенного числа = {sum}");
}