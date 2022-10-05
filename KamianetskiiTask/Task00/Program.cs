// 0. Вывести квадрат числа

double ReadData(string line)
{
    Console.WriteLine(line);
    double number = double.Parse(Console.ReadLine()??"");
    return number;
}

double Calculate(double x)
{
    double a = Math.Pow(x, 2);
    return a;
}

void PrintData(string prefix, double value)
{
    Console.WriteLine(prefix + value);
}

double x = ReadData("Введите число: ");
double result = Calculate(x);
PrintData("Квадрат числа: ", result);