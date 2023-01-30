// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; number != 0; i++)
{
    count = count + (number % 10);
    number = number / 10;
}

System.Console.WriteLine(count);