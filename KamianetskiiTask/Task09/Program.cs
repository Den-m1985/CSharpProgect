﻿// 9. Показать последнюю цифру трёхзначного числа
//Смотря как считать? слева считать или справа?


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int Calculate(int a)
{
    int b = 0;
    b = a % 10;
    return b;
}


void PrintData(string prefix, int value)
{
    Console.WriteLine(prefix + value);
}


int a = ReadData("Введите 3х значное число: ");

if (a > 99 && a < 1000) PrintData("Последняя цифра: ", Calculate(a));
else Console.WriteLine("Что-то пошло не так");

