// 20. Задать номер четверти, показать диапазоны для возможных координат


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int cordinat = ReadData("Введите номер четверти: ");



if (cordinat == 1) Console.WriteLine($"номер четверти: {cordinat} соответствует x>0, y>0.");
if (cordinat == 2) Console.WriteLine($"номер четверти: {cordinat} соответствует x<0, y>0.");
if (cordinat == 3) Console.WriteLine($"номер четверти: {cordinat} соответствует x<0, y<0.");
if (cordinat == 4) Console.WriteLine($"номер четверти: {cordinat} соответствует x>0, y<0.");

