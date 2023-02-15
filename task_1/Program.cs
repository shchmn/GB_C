// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

System.Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

string Func(int n)
{
    if (n == 0) return "";
    else return $"{n} " + Func(n - 1);
}
System.Console.WriteLine(Func(n));