// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество сторк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов отличное от количества строк");
int columns = Convert.ToInt32(Console.ReadLine());

int minsum = int.MaxValue;
int indexrows = 0;
int [,] matrix = new int [rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(10);
             Console.Write( matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
   

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
   {
        sum = sum + matrix[i,j];
   }

   if (sum<minsum)
   {
    minsum = sum;
    indexrows = i;
    indexrows++;
   }

    }
Console.WriteLine("Строка с наименьшей суммой элементов: " + (indexrows));

Console.ReadLine();