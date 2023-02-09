// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.Write("Введите числа через пробел: ");
string str = Console.ReadLine();
var arr = str.Split();
int[] a = new int[arr.Length];
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    a[i] = Convert.ToInt32(arr[i]);
}

for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0)
    {
        count += 1;
    }
}
Console.WriteLine("\n" + $"В массиве положительных чисел: {count}");