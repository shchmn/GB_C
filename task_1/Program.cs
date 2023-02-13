// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(100);
        System.Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
int[] newarr = new int[n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        newarr[j] = arr[i, j];
    }
    Array.Sort(newarr);
    Array.Reverse(newarr);
    foreach (int k in newarr)
    {
        System.Console.Write(k + " ");
    }
    System.Console.WriteLine();
}