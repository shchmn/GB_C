// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a;
System.Console.WriteLine("Введите целое число: ");
string? str = Console.ReadLine();
a = Convert.ToInt32(str);

if (a % 2 == 0)
{
    System.Console.WriteLine("Число четное");
}
else
{
    System.Console.WriteLine("Число нечетное");
}
