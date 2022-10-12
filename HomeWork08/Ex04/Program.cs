// По желанию
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
// 1  2  3  4
//12 13 14  5
//11 16 15  6
//10  9  8  7



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




int size = 4; //Сторона квадрата (массива).
int[,] arr = CreateArray(size);
PrintArray(arr);


int[] sum = Calculate(arr, size);




