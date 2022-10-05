//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double ReedData(string line)
{
    Console.Write(line);
    double number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

// Находим точки
double FindPointX(double b1, double b2, double k1, double k2)
{
    double x = 0;
    /*
    y = k1 * x + b1, y = k2 * x + b2;
    k2 * x + b2 = k1 * x + b1;
    x*(k2 - k1) = b1 - b2;
    */
    x = (b1 - b2) / (k2 - k1);

    return x;
}

// Находим пересечение.
double FindPointY(double x, double k2, double b2)
{
    double y = 0;
    // Подставляем Х из первого уравнения
    y = k2 * x + b2;

    return y;
}


double b1 = ReedData("Введите координату точки b1: ");
double k1 = ReedData("Введите координату точки k1: ");
double b2 = ReedData("Введите координату точки b2: ");
double k2 = ReedData("Введите координату точки k2: ");


double resultX = FindPointX(b1, b2, k1, k2);
double resultY = FindPointY(resultX, k2, b2);


PrintData("Точка пересечения по X: ", resultX.ToString());
PrintData("Точка пересечения по Y: ", resultY.ToString());
