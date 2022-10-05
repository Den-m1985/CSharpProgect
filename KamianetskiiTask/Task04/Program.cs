//  4. Найти максимальное из трех чисел


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int Calculate(int a, int b, int c)
{
    int max = a;
    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }

    return max;
}


void PrintData(string prefix, int value)
{
    Console.WriteLine(prefix + value);
}


int a = ReadData("Введите число: ");
int b = ReadData("Введите число: ");
int c = ReadData("Введите число: ");

int result = Calculate(a, b, c);

PrintData("Максимальное число: ", result);

