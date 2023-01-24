// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Number()
{
    System.Console.WriteLine("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Number();
int b = a / 10;
int c = b % 10;

System.Console.WriteLine($"Вторая цифра числа {a} - {c}");