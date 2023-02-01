// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] a = new int[10];
Random rnd = new Random();
int count = 0;

for (int i = 1; i < 10; i++)
{
    a[i] = rnd.Next(1, 100);
    System.Console.Write($"{a[i]}; ");
       
}
for (int j = 2; j < a.Length; j += 2)
    {
        count += a[j];
    }
Console.WriteLine("\n" + $"Сумма чисел, стоящих на нечетных позициях = {count}");