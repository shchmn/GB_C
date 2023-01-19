// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a;
int b;
int d;
System.Console.WriteLine("Введите первое целое число: ");
string? str = Console.ReadLine();
a = Convert.ToInt32(str);
System.Console.WriteLine("Введите второе целое число: ");
str = Console.ReadLine();
b = Convert.ToInt32(str);
System.Console.WriteLine("Введите третье целое число: ");
str = Console.ReadLine();
d = Convert.ToInt32(str);
if ((a > b) && (a > d))
{
    System.Console.WriteLine("Большее число " + a);
}

else if ((b > a) && (b > d))
{
    System.Console.WriteLine("Большее число " + b);
}
else
{
    System.Console.WriteLine("Большее число " + d);
}
