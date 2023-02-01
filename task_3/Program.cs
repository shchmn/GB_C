// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.

System.Console.Write("Введите числа через пробел: ");
string str = Console.ReadLine();
var arr = str.Split();
double[] a = new double[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    a[i] = Convert.ToDouble(arr[i]);
}

foreach (var item in a)
{
    System.Console.Write(item + " ");
}
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным числом массива = {a.Max() - a.Min()}");
