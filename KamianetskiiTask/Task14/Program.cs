// 14. Найти третью цифру числа или сообщить, что её нет


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int Calculate(int a)
{
    int b = 0;
    b = (a/100) % 10;
    return b;
}


int ThirdNumberInt(int number)
{
    int lenNum = (int)Math.Log10(number);
    int outNumber = (int)(number / Math.Pow(10, lenNum - 2)) % 10;
    return outNumber;
}


void PrintData(string prefix, int value)
{
    Console.WriteLine(prefix + value);
}


int a = ReadData("Введите число: ");

PrintData("Третья цифра справа: ", Calculate(a));
PrintData("Третья цифра слева: ", ThirdNumberInt(a));


