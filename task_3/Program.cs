// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

System.Console.WriteLine("Введите количество строк для первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов для первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество строк для второй матрицы: ");
int f = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов для второй матрицы: ");
int d = Convert.ToInt32(Console.ReadLine());
int[,] farr = new int[m, n];
Random rnd = new Random();
int[,] sarr = new int[f, d];
int[,] tarr = new int[m, d];

for (int i = 0; i < farr.GetLength(0); i++)
{
    for (int j = 0; j < farr.GetLength(1); j++)
    {
        farr[i, j] = rnd.Next(10);
        System.Console.Write(farr[i, j] + "  ");
        
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
for (int i = 0; i < sarr.GetLength(0); i++)
{
    for (int j = 0; j < sarr.GetLength(1); j++)
    {
        sarr[i, j] = rnd.Next(10);
        System.Console.Write(sarr[i, j] + "  ");
        
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
if (n == f)
{
    for (int i = 0; i < farr.GetLength(0); i++)
    {
        for (int j = 0; j < sarr.GetLength(0); j++)
        {
            tarr[i, j] = farr[i, j] * sarr[j, i];
            System.Console.Write(tarr[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}
else
{
    System.Console.WriteLine("Перемножение данных матриц невозможно");
}