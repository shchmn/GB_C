// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a;
int b;
System.Console.WriteLine("Введите первое целое число: ");
string? str = Console.ReadLine();
a = Convert.ToInt32(str);
System.Console.WriteLine("Введите второе целое число: ");
str = Console.ReadLine();
b = Convert.ToInt32(str);
if (a > b)
{
    System.Console.WriteLine("Большее число " + a);
}
else
{
    System.Console.WriteLine("Большее число " + b);
}
