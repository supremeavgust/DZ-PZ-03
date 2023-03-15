// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да


Console.Clear();
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
//int n = new Random().Next(10000, 100000);
Console.WriteLine($"Число: {n}");
int n1 = n / 10000;
int n2 = n / 1000 % 10;
int n3 = n % 100 / 10;
int n4 = n % 10;
if (n2 == n3 && n1 == n4)
    Console.WriteLine("Это число является палиндромом");
else
    Console.WriteLine("Это чиcло не является палиндроном");
