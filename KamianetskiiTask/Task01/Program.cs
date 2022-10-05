// 1. По двум заданным числам проверять является ли первое квадратом второго

double ReadData(string line)
{
    Console.Write(line);
    double number = double.Parse(Console.ReadLine() ?? "");
    return number;
}

void Calculate(double a, double b)
{
    double x = a * a;
    if (x == b)
    {
        Console.WriteLine("Первое число является квадратом второго");
        Console.WriteLine($"{a}, {b} -> да");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго");
        Console.WriteLine($"{a}, {b} -> нет");
    }
}

double x = ReadData("Введите первое число: ");
double y = ReadData("Введите второе число: ");
Calculate(x, y);


