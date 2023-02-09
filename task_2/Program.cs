// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int Number()
{
    System.Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int b1 = Number();
int b2 = Number();
int k1 = Number();
int k2 = Number();

if ((k1 - k2) != 0)
{
    double z = ((double)(b2 - b1) / (k1 - k2));
    double x = Math.Round(z, 2);
    double z1 = k1 * x + b1;
    double z2 = k2 * x + b2;
    double y1 = Math.Round(z1, 3);
    double y2 = Math.Round(z2, 3);

    if (y1 != y2)
    {
        System.Console.WriteLine(y1);
        System.Console.WriteLine(y2);
        System.Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        System.Console.WriteLine("Точка пересечания прямых - (" + x + ";" + y2 + ")");
    }
}
else
{
    System.Console.WriteLine("Прямые не пересекаются");
}

