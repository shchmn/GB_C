// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int a;
int b;
System.Console.WriteLine("Введите целое число: ");
string? str = Console.ReadLine();
a = Convert.ToInt32(str);
b = 2;
while (a >= b)
{
    System.Console.Write(b + " ");
    b += 2;
}

