// По желанию
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
// 1  2  3  4
//12 13 14  5
//11 16 15  6
//10  9  8  7


int[,] Spiral(int size)
{
    int[,] array = new int[size, size];
    int number = 0;
    // 1 step  1-4
    for (int j = 0; j < size; j++)
    {
        array[0, j] = (number += 1);
    }
    // 2 step  5-7
    for (int i = 1; i < size; i++)
    {
        array[i, size - 1] = (number += 1);
    }
    // 3 step  8-10
    for (int j = size - 2; j >= 0; j--)
    {
        array[size - 1, j] = (number += 1);
    }
    // 4 step  11-12
    for (int i = size - 2; i > 0; i--)
    {
        array[i, 0] = (number += 1);
    }
    // 5 step  13-14
    for (int j = 1; j < 3; j++)
    {
        array[1, j] = (number += 1);
    }
    // 6 step  15    Здесь можно пройти циклом
    array[2, 2] = 15;
    //for (int i = 2; i < 3; i++)
    //{
    //    array[i, size - 2] = (number += 1);
    //}
    // 7 step  16
    array[2, 1] = 16;
    //for (int j = 1; j > 0; j--)
    //{
    //    array[size - 2, j] = (number += 1);
    //}
    return array;
}


void PrintArray(int[,] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int size = 4;
int[,] result = Spiral(size);
PrintArray(result, size);

