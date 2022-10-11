// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int number = ReadData("Введите день недели: ");

if (number>0 && number < 8)
{
    if (number >0 && number <6)Console.WriteLine($"Этот день: {number}  рабочий");
    else Console.WriteLine($"Этот день: {number} выходной");
}
else Console.WriteLine("Что-то пошло не так");