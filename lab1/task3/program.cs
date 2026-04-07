using System;

Console.Write("Введите первое число (A): ");
double a = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число (B): ");
double b = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Результат сложения: {a} + {b} = {a + b}");