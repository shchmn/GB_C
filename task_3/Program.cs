// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] a = new int[8];
Random rnd = new Random();

for (int i = 0; i < 8; i++)
{
    a[i] = rnd.Next(100);
    System.Console.Write($"{a[i]}; ");
}