// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

System.Console.WriteLine("Введите первое целое число: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;

Func(n, m);
void Func(int n, int m)
{
    if (m > n) return;
    else count += m;
    Func(n, m + 1);
}
System.Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {count}");