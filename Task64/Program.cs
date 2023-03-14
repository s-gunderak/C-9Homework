﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersRec(int n)
{
    if (n < 1) return String.Empty;
    if (n == 1) return $"{n}.";
    else return $"{n}, " + NumbersRec(n - 1);
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"N = {n} -> {NumbersRec(n)}");