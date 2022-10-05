// 2. Даны два числа. Показать большее и меньшее число

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}



void PrintData(string prefix, int value)
{
    Console.WriteLine(prefix + value);
}

int a = ReadData("Введите первое число: ");
int b = ReadData("Введите первое число: ");


int max = 0;
int min = 0;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

PrintData("Число меньшее: ", min);
PrintData("Число большее: ", max);