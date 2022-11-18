﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
Console.WriteLine($"Точки пересечения {x}; {k1*x+b1}");

// y=k1x+b1
// y=k2x+b2
// k1x+b1=k2x+b2
// b2-b1=k1x-k2x 
// b2-b1=x(k1-k2)
// x=(b2-b1)/(k1-k2)