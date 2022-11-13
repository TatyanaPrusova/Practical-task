// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


   int[] array = GetArray (10);
   int[] GetArray(int size)
   {
    int[] array = new int [size];
    for(int i=0; i<array.Length; i++)
   {
     array[i] = new Random().Next(100, 1000); 
   }
   return array;
   }
   
Console.WriteLine(String.Join(", ",array));
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array [i]%2==0)
    {
        count++;
    }
}
System.Console.WriteLine($"{count}");