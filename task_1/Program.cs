// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] a = new int[8];
Random rnd = new Random();
int count = 0;

for (int i = 0; i < 8; i++)
{
    a[i] = rnd.Next(100, 1000);
    System.Console.Write($"{a[i]}; ");
    if (a[i] % 2 == 0)
    {
        count += 1;
    }
}
Console.WriteLine("\n" + $"В массиве четных чисел: {count}");