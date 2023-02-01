/* Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите коэффициенты двух линейных уравнений");
Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

string SearchIntersectionOfStraightLines(int k1, int b1, int k2, int b2)
{
    //Расчет будем проводить в декартовой системе координат
    //для расчетов необходимо дополнительно задать область
    //в которой будем рассматривать прямые 
    double xMin = -100;
    double xMax = 100;
    // и шаг с которым будем проводить расчеты
    double step = 0.01;
    double y1 = 0.0;
    double y2 = 0.0;
    string str = "Значение не найдено!";
    for (double x = xMin; x <= xMax; x += step)
    {
        x = Math.Round(x, 3); // округления x использую для красоты вывода
        // округление  y1 и y2 используется в связи стем,
        // что мы в дальнейшем их сравниваем, а числа  
        // формата double хоть на десятый знак поле запятой, но отличаются!
        y1 = Math.Round(k1 * x + b1, 3);
        y2 = Math.Round(k2 * x + b2, 3);
        
        // тест расчетов
        // Console.Write("x = ");
        // Console.Write(x);
        // Console.Write("   y1 = ");
        // Console.Write(y1);
        // Console.Write("   y2 = ");
        // Console.WriteLine(y2);

        if (y1 == y2)
        {
            str = $"Прямые пересекаются в точке с координатами ({x}; {y1}).";
            break;
        }
    }
    return str;
}

Console.WriteLine(SearchIntersectionOfStraightLines(k1, b1, k2, b2));