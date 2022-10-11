// 20. Задать номер четверти, показать диапазоны для возможных координат


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int cordinat = ReadData("Введите координату х: ");



if (cordinat == 0) 
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
