// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int Number_1 = Convert.ToInt32(Console.ReadLine());

if(Number_1>7|Number_1<1)
{
    Console.WriteLine("Ошибка");
}
if(Number_1>=1&Number_1<=5)
{
    Console.WriteLine("нет");
}
if(Number_1>=6&Number_1<=7)
{
    Console.WriteLine("да");
}