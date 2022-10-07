// 12. Удалить вторую цифру трёхзначного числа
//Смотря что считать 2 чифрой.


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int Calculate(int a, int b)
{
    int m = 1;
    while (b > 1)
    {
        m *= 10;
        b--;
    }
    int t = a % m + (a / (m * 10)) * m;
    return t;
}


void PrintData(string prefix, int value)
{
    Console.WriteLine(prefix + value);
}


int a = ReadData("Введите число: ");
int s = ReadData("Введите позицию которую хотите удалить: ");

PrintData($"Число без - {s} позиции справа: ", Calculate(a, s));
