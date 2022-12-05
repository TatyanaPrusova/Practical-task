﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());


void SumNumber (int M, int N, int sum)
{
    if (M > N)
    {
       Console.WriteLine($"{sum}");
       return;
    
    }
    sum = sum + (M++);
    SumNumber ( M, N, sum);
}
SumNumber(M,N,0);