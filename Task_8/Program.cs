// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int Number_1 = Convert.ToInt32(Console.ReadLine());

int numberNeg = 1;

  while(numberNeg<=Number_1)
{
     if(numberNeg % 2 == 0)

    
    Console.WriteLine(numberNeg);
    numberNeg++;
}
 
