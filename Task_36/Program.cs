// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


   int[] array = GetArray (5);
   int[] GetArray(int size)
   {
    int[] array = new int [size];
    for(int i=0; i<array.Length; i++)
   {
     array[i] = new Random().Next(-10, 10); 
   }
   return array;
   }
   
Console.WriteLine(String.Join(", ",array));
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    if (i%2>0)
    {
        sum= array [i]+ sum;
    }
}
System.Console.WriteLine($"{sum}");