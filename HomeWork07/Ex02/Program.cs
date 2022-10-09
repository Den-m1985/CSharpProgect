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
int FindDigit(int[,] array, int x, int y)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = array[x, y];
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



int[,] array = CreateArray(4, 4);
PrintArray(array);
int x = ReadData("Введите координату по х: ");
int y = ReadData("Введите координату по y: ");
if (x >= 0 && x <= 3)
{
    if (y >= 0 && y <= 3)
    {
        Console.Write("Пересение индексов: ");
        Console.Write(FindDigit(array, y, x));  //i по х; j по у.
    }
    else Console.Write("Такого числа в массиве нет");
}
else Console.Write("Такого числа в массиве нет");


