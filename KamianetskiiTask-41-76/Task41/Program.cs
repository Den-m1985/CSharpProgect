// 41. Выяснить являются ли три числа сторонами треугольника


int x1 = 1;
int y1 = 4;
int x2 = 3;
int y2 = 7;
int x3 = 4;
int y3 = 1;


//Считаем площадь треугольника по формуле Герона.
double AreaTriangle(int x1, int x2, int x3, int y1, int y2, int y3)
{
    double s = 0; //Площадь.
    double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //сторона a.
    double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y2 - y3, 2));
    double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y1 - y3, 2));

    double halfArea = (a + b + c) / 2;
    s = Math.Sqrt(halfArea * (halfArea - a) * (halfArea - b) * (halfArea - c));

    return s;
}



double result = AreaTriangle(x1, x2, x3, y1, y2, y3);
Console.WriteLine(result);
