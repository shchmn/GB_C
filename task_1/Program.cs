// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];
Random rnd = new Random();
System.Console.WriteLine(arr.Length);
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = Math.Round((rnd.NextDouble() * 100), 2);
        System.Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();
}

