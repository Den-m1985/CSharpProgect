// 3. По заданному номеру дня недели вывести его название


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int a = ReadData("Введите число недели: ");


if (1 == a)
{
    Console.WriteLine("Понедельник");
}
if (2 == a)
{
    Console.WriteLine("Вторник");
}
if (3 == a)
{
    Console.WriteLine("Среда");
}
if (4 == a)
{
    Console.WriteLine("Четверг");
}
if (5 == a)
{
    Console.WriteLine("Пятница");
}
if (6 == a)
{
    Console.WriteLine("Суббота");
}
if (7 == a)
{
    Console.WriteLine("Воскресенье");
}