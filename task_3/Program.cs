// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] arr = new int[4, 4];
Random rnd = new Random();
int count = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(10);
        System.Console.Write(arr[i, j] + "  ");
        
    }
 
    System.Console.WriteLine();
    
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        count += arr[j, i];
    }
    double m = count / 4;
    System.Console.Write(Math.Round(m, 2) + " ");
    count = 0;
}