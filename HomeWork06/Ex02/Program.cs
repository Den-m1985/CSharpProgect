//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int ReedData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

// Находим точки
double FindPoint(int x, int b, int k)
{
    double y = 0;
    return y = k * x + b;;
}

// Находим пересечение.
double FindXross(int x, int b, int k)
{
    double y = 0;
    return y = k * x + b;;
}

int b1 = ReedData("Введите координату точки b1: ");
int k1 = ReedData("Введите координату точки k1: ");
int b2 = ReedData("Введите координату точки b2: ");
int k2 = ReedData("Введите координату точки k2: ");

int x1 = 1;
int x2 = 2;

double result1 = FindPoint(x1, b1, k1);
double result2 = FindPoint(x2, b1, k1);
double result3 = FindPoint(x1, b2, k2);
double result4 = FindPoint(x2, b2, k2);


PrintData("Точка пересечения: ", result1.ToString());