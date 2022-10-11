// 19. Определить номер четверти плоскости,
//в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int x = ReadData("Введите координату х: ");
int y = ReadData("Введите координату у: ");


if (x > 0) 
{
    if (y > 0) Console.WriteLine($"Координаты: {x} и {y} находятся в 1й четверти.");
}
if (x < 0)
{
    if (y > 0) Console.WriteLine($"Координаты: {x} и {y} находятся в 2й четверти.");
}
if (x < 0)
{
    if (y < 0) Console.WriteLine($"Координаты: {x} и {y} находятся в 3й четверти.");
}
if (x > 0)
{
    if (y < 0) Console.WriteLine($"Координаты: {x} и {y} находятся в 4й четверти.");
}


