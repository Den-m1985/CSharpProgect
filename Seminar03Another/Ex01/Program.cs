


int ReedData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

char ThirdNumberChar(string inputNumber)
{
    char[] simbol = inputNumber.ToCharArray();
    return simbol[2];
}

int ThirdNumberInt(int number)
{
    int lenNum = (int)Math.Log10(number);
    int outNumber = (int)(number / Math.Pow(10, lenNum - 2)) % 10;
    return outNumber;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int number = ReedData("Введите число ");
if (number < 100)
{
    PrintData("Такой цифры нет", "");
}
else
{
    char ThirdSimbol = ThirdNumberChar(number.ToString());
    PrintData("Третье число: ", ThirdSimbol.ToString());

    int ThirdsimbolInt = ThirdNumberInt(number);
    PrintData("Третье число: ", ThirdsimbolInt.ToString());
}