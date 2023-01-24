// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Number()
{
    System.Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int n = Number();
for (int i = 1; i <= n; i++)
{
    System.Console.WriteLine($"{i} ^ 3 = {Math.Pow(i, 3)}");
}