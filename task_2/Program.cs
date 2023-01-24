// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Number()
{
    System.Console.WriteLine("Введите целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Number();
int b = a;
if (a < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    while (a > 999)
    {
        a = a / 10;
        System.Console.WriteLine(a);
    }

    int c = a % 10;
    System.Console.WriteLine($"Третья цифра числа {b} - {c}");
}