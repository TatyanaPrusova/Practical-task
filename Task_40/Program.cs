// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.WriteLine("Введите три числа");

int Number_1 = Convert.ToInt32(Console.ReadLine());
int Number_2 = Convert.ToInt32(Console.ReadLine());
int Number_3 = Convert.ToInt32(Console.ReadLine());

if((Number_1<Number_2+Number_3)&&(Number_2<Number_1+Number_3)&&(Number_3<Number_1+Number_2))
{
Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}