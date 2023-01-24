// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Number()
{
    System.Console.WriteLine("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Number();
int first_num = a / 10000;
int last_num = a % 10;
int second_num = (a / 1000) % 10;
int forth_num = (a / 10) % 10;
if ((first_num == last_num) && (second_num == forth_num))
{
    System.Console.WriteLine($"Число {a} является палиндромом");
}
else
{
    System.Console.WriteLine($"Число {a} не является палиндромом");
}
