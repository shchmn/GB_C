// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет

System.Console.WriteLine("Введите номер строки: ");
int m = (Convert.ToInt32(Console.ReadLine())) - 1;
System.Console.WriteLine("Введите номер столбца: ");
int n = (Convert.ToInt32(Console.ReadLine())) - 1;
System.Console.WriteLine();

int[,] arr = new int[5, 6];
Random rnd = new Random();
int count = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(100);
        System.Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();  
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if ((i == m) && (j == n))
            {
                count += 1;
            }        
    }
}
System.Console.WriteLine();
if (count == 1)
{
    System.Console.WriteLine($"В данном массиве на позиции ({m + 1},{n + 1}) стоит число {arr[m, n]}");
}
else
{
    System.Console.WriteLine($"Числа с позицией ({m + 1},{n + 1}) в данном массиве нет");
}
    
