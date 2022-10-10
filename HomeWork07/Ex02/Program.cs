// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


int[,] CreateArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


//Находим число
int FindDigit(int[,] array, int a, int b)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = array[a, b];
        }
    }
    return result;
}


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int a = 3; //Размеры массива.
int b = 4;
int[,] array = CreateArray(a, b); //Массив 3х4.
PrintArray(array);
int x = ReadData("Введите координату по х: ");
int y = ReadData("Введите координату по y: ");
if (x >= 0 && x < b)
{
    if (y >= 0 && y < a)
    {
        Console.Write("Пересение индексов: ");
        Console.Write(FindDigit(array, y, x));  //i по y; j по x.
    }
    else Console.Write("Такого числа в массиве нет");
}
else Console.Write("Такого числа в массиве нет");


