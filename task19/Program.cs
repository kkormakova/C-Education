// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Первый способ
// Console.Write("Введите пятизначное число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 9999 && number < 100000)
// {
//     string numberCheck = Convert.ToString(number);
//     if (numberCheck[0] == numberCheck[4] && numberCheck[1] == numberCheck[3])
//     {
//         Console.WriteLine("Введенное число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Введенное число не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine("Вы ввели не пятизначное число!");
// }

//Второй способ
Console.Write("Введите пятизначное число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberB > 9999 && numberB < 100000)
{
    int num1 = numberB / 10000 % 10;
    int num2 = numberB / 1000 % 10;
    int rev2 = numberB / 10 % 10;
    int rev1 = numberB % 10;
    if (num1 == rev1 && num2 == rev2)
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не палиндром");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число!");
}