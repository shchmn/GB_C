// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Number()
{
    System.Console.WriteLine("Введите цифру от 1 до 7: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Number();

if ((0 < a) && (a < 6))
{
    System.Console.WriteLine("Это будний день");
}
else if ((5 < a) && (a < 8))
{
    System.Console.WriteLine("Это выходной");
}
else
{
    System.Console.WriteLine("Число введено неверно");
}
