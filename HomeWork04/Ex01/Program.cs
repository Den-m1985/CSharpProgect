/*
Есть магазин "Еда"
В магазине есть охранник
Охранник ведёт запись всех, кто заходит в магазин
Охранник ведёт запись всех, кто выходит из магазина

Зайти и выйти можно в целый час.

Выяснить в какой промежуток времени было больше всего
посетителей

Данные вводятся парами: приход-уход
Максимум 100 покупателей

Входные данные
10-12
11-13
9-12

Ответ
11-12
*/

int ReedData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int TimeRange(string hours)
{
    
    return hours;
}