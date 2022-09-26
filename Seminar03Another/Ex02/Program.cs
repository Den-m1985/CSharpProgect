/* Напишите программу, которая принимает на вход координаты точки (Х и Y),
причем Х и Y не равены нулю и выдает номер четверти плоскости, в которой находится эта точка
Например:
х=34; у=-30 четверть 4
х=2; у=4   1
и т.д.
*/

int ReedData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int QuterTest(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return -1;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int coordX = ReedData("Введите координату Х не равную 0: ");
int coordY = ReedData("Введите координату Y не равную 0: ");

int quterAnswer = QuterTest(coordX, coordY);

PrintData("Номер четверти: ", quterAnswer.ToString());
