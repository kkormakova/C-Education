// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99)
{
    string anyNumber = Convert.ToString(number);
    Console.WriteLine("Третья цифра введенного числа = " + anyNumber[2]);
}
else
{
    Console.WriteLine("Третьей цифры в введенном числе нет");
}