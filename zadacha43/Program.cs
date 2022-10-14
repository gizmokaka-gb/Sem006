// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2

Console.WriteLine("введи k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введи b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введи k2");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введи b2");
double b2 = double.Parse(Console.ReadLine()!);


var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y})");