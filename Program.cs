﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void ShowNums(int n)
// {
//     if (n > 0)
//     {
//         System.Console.Write(n + " ");
//         ShowNums(n - 1);
//     }
// }

// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"N = {n} -> ");
// ShowNums(n);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SumNumsFromTo(int m, int n)
// {

//     if (m != n)
//     {
//         if (m > n)
//         {
//             return SumNumsFromTo(m - 1, n) + m;
//         }

//         else
//         {
//             return SumNumsFromTo(m, n - 1) + n;
//         }
//     }
//     else 
//     {
//         return m;
//     }
// }

// System.Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"M = {m}; N = {n} -> {SumNumsFromTo(m, n)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Ack(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }

//     else if (n == 0)
//     {
//         return Ack(m - 1, 1);
//     }

//     else return Ack(m - 1, Ack(m, n - 1));
// }

// System.Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Ack(m, n)}");