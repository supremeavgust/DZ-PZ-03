﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Введите число:");
int n=Convert.ToInt32(Console.ReadLine());
for (int i=0; i < n ; i++)
    Console.WriteLine($"Число {i}" + $" В кубе это: {Math.Pow(i, 3)}");
