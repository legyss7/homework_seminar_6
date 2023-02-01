/* Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите коэффициенты двух линейных уравнений");
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

string SearchIntersectionOfStraightLines(double k1, double b1, double k2, double b2)
{
    string str = "Прямые не пересекаются!";
    if (Math.Round(k1, 3) != Math.Round(k2, 3))
    {
        double x = Math.Round((b2 - b1) / (k1 - k2), 3);
        double y = Math.Round(k1 * x + b1, 3);
        str = $"Прямые пересекаются в точке с координатами ({x}; {y}).";
    }
    return str;
}

Console.WriteLine(SearchIntersectionOfStraightLines(k1, b1, k2, b2));
