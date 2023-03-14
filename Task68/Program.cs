﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int A(int m, int n)
{
    if (m > 0 & n > 0)
    {
        return A(m - 1, A(m, n - 1));
    }
    else
    {
        if (m != 0 & n == 0)
        {
            return A(m - 1, 1);
        }
        else
        {
            return n + 1;
        }
    }
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(A(m, n));