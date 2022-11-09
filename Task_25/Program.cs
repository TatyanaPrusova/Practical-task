// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int numB = Convert.ToInt32(Console.ReadLine());

int Pow(int numA, int numB)
{
    int resalt = numA;
    for (int i = 1; i<numB;i++)
    {
        resalt*=numA;
    }
    return resalt;
}
Console.WriteLine("Ответ"+Pow(numA,numB));