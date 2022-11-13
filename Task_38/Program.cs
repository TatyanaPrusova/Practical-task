// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76 


   int[] array = GetArray (5);
   int[] GetArray(int size)
   {
    int[] array = new int [size];
    for(int i=0; i<array.Length; i++)
   {
     array[i] = new Random().Next(0, 100); 
   }
   return array;
   }
   
Console.WriteLine(String.Join(", ",array));
int max = 0;
int min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(array[i]>max)
    {
        max=array[i];
    }
    if(array[i]<min)
    {
        min=array[i];
    }

}

System.Console.WriteLine($"max = {max}");
System.Console.WriteLine($"min = {min}");
System.Console.WriteLine($"разница = {max-min}");
