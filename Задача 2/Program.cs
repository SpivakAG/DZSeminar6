// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

string[] pointNames = new string[4] { "b1", "k1", "b2", "k2" };

Console.WriteLine("Программа находит точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
double b1 = input(pointNames[0]);
double k1 = input(pointNames[1]);
double b2 = input(pointNames[2]);
double k2 = input(pointNames[3]);

if (k1 == k2) Console.WriteLine("Прямые параллельны и не пересекаются");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"X={x}; Y={y}");
}

double input(string pointName)
{
    Console.WriteLine($"Введите значение точки {pointName}");
    double point = Convert.ToInt32(Console.ReadLine());
    return point;
}