﻿Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n % m == 0)
Console.Write("Кратно");
else
Console.Write($"Не кратно, остаток {n % m}");