// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Number()
{
    System.Console.WriteLine("Введите целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Number();
int b = Number();
System.Console.WriteLine($"{a} в степени {b} равно {Math.Pow(a, b)}");

