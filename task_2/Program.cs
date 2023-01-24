// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Number()
{
    System.Console.Write("-->");
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double xa = Number();
double ya = Number();
double za = Number();

double xb = Number();
double yb = Number();
double zb = Number();

double result = Math.Pow(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2), 0.5);

System.Console.WriteLine(result);