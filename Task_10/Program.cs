// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int Number_1 = Convert.ToInt32(Console.ReadLine());

int Number_2 = (Number_1%100)/10;


Console.WriteLine(Number_2);