// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество сторк 1-й матрицы");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 1-й матрицы (и строк 2-й)");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 2-й матрицы");
int c = Convert.ToInt32(Console.ReadLine());

int[,] fistMatrix = new int[a,b];
GetArray(fistMatrix);
Console.WriteLine("Первая матрица: ");
PrintArray(fistMatrix);

int[,] secondMatrix = new int[a,b];
GetArray(secondMatrix);
Console.WriteLine("Вторая матрица: ");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[a,c];

MultiplyMatrix(fistMatrix, secondMatrix, resultMatrix);
Console.WriteLine("Результирующая матрица: ");
PrintArray(resultMatrix);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(10);
        }
    }
}

void MultiplyMatrix(int[,] fistMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < resultMatrix.GetLength(1); k++)
            {
                sum += fistMatrix[i,k] * secondMatrix[k,j]; 
            }
            resultMatrix[i,j] = sum;
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
