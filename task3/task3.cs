// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

Console.Write("Введите число M:  ");
int m = Int32.Parse(Console.ReadLine());
Console.Write("Введите число N:  ");
int n = Int32.Parse(Console.ReadLine());

int funcAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return funcAkkerman(m - 1, 1);
    }
    return funcAkkerman(m - 1, funcAkkerman(m, n - 1));
}

Console.WriteLine(funcAkkerman(m, n));