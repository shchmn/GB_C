﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] arr = new int[3, 3];
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
 
    System.Console.Write(count + " ");
    count = 0;
}