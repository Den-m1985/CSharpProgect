// 6. Выяснить является ли число чётным



int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int a = ReadData("Введите число: ");

if (a % 2 == 0)
{
    Console.WriteLine(a);
    Console.WriteLine("Число четное"); ;
}
else
{
    Console.WriteLine(a);
    Console.WriteLine("Число не четное");
}
