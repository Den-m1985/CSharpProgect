// Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int[,] CreateArray(int size)
{
    int[,] array = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
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


int[] Calculate(int[,] array, int size)
{
    int[] sum = new int[size];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}


void PrintArraySum(int[] array, int size)
{
    for (int i = 0; i < size; i++)
    {

        Console.Write(array[i]);
        Console.WriteLine();
    }
}


void FindMin(int[] array, int size)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    Console.WriteLine($"Строка (начиная с 0) с наименьшей суммой: {index}");
}


int size = ReadData("Введите сторону квадрата: ");
int[,] arr = CreateArray(size);
PrintArray(arr);

Console.WriteLine("Суммы по строчкам:");
int[] sum = Calculate(arr, size);
PrintArraySum(sum, size);

FindMin(sum, size);
