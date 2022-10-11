// Задача 58: Задайте две матрицы.
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
/*
int[,] a = {{2,4},
          {3,2}};
int[,] b = {{3,4},
           {3,3}};
           
// a[0,0]*b[0,0] + a[0,1]*b[1,0]  |  a[0,0]*b[0,1] + a[0,1]*b[1,1]

// a[1,0]*b[0,0] + a[1,1]*b[1,0]  |  a[1,0]*b[0,1] + a[1,1]*b[1,1]
*/


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


void Calculate(int[,] array1, int[,] array2, int size)
{
    int[,] matrixSum = new int[size, size];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                matrixSum[i, j] = matrixSum[i, j] + array1[i, k] * array2[k, j];
            }
            Console.Write(matrixSum[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int length = ReadData("Введите сторону массива: ");
int[,] arr1 = CreateArray(length);
int[,] arr2 = CreateArray(length);

Console.WriteLine("Матрица 1:");
PrintArray(arr1);
Console.WriteLine("Матрица 2:");
PrintArray(arr2);

Console.WriteLine("Произведение матриц:");
Calculate(arr1, arr2, length);
