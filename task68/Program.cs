// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
if (m < 0 || n < 0)
{
    Console.WriteLine("Не верно! Введите 2 неотрицательных числа!");
}
else
{
    int resultAkkerman = FunctionAkkerman(m, n);
    Console.WriteLine($"Функция Аккермана = {resultAkkerman}");
}

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}
