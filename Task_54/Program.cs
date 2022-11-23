// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество сторк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] GetArray (int m, int n, int min, int max)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i,j] = new Random().Next(min, max+1);
        }
    }
    return result;
}


void ChangeRous (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1)-1; j++)
   {
    for (int z = 0; z < matrix.GetLength(1)-1; z++)
    {
        
    
        if (matrix [i,z] < matrix [i,z+1])
         {
            
            int temp = matrix [i,z];
            matrix [i,z] = matrix [i,z+1];
            matrix [i,z+1] = temp;
         }
    }
     
   }
    }
}

void PrintArray (int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j]);
        }
        Console.WriteLine();
    }
}
int[,] array = GetArray(rows, columns,2,9);

PrintArray(array);
Console.WriteLine("____________________");
ChangeRous(array);
PrintArray(array);