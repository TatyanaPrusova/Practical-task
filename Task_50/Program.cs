// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
{
Console.WriteLine("Введите номер строки");
 int numrow = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите номер столбца");
 int numcolumns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [5, 6];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
{
    matrix[i,j]=new Random().Next(100);
    Console.Write( matrix[i,j]+" ");
}
Console.WriteLine();
}

if(numrow < 0 | numrow > matrix.GetLength(0)-1 | numcolumns < 0 | numcolumns > matrix.GetLength(1)-1)
{
    Console.WriteLine( "Такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента массива = {matrix[numrow, numcolumns]}");
}
}

