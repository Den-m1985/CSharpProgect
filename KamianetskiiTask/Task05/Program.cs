// 5. Написать программу вычисления значения функции y = f(a)


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}



void PrintData(string prefix, int value)
{
    Console.WriteLine(prefix + value);
}


int a = ReadData("Введите число: ");

int result = a;

PrintData("Значение функции: ", result);



