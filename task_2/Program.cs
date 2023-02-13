// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов (больше или меньше количества строк): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
Random rnd = new Random();
int minsum = 1;
int count = 0;
int str = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(100);
        System.Console.Write(arr[i, j] + " ");
        minsum += arr[i, j];
    }
    System.Console.WriteLine();  
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        count += arr[i, j];
    }
    if (count < minsum)
    {
        minsum = count;
        str +=1;
    }
    count = 0;
}
System.Console.WriteLine();
System.Console.WriteLine($"Минимальная сумма элементов {minsum} в строке {str}");