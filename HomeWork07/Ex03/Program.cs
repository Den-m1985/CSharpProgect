// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
void FindDigit(int[,] array)
{
    double[] a = new double[4];
    //int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //sum = sum + array[i, 1];
            a[j] = a[j] + array[i, j];
            //result = array.GetAvarageForColomn(1)
        }
    }
    //result = a[i] / 3;

    for (int i = 0; i < 4; i++)
    {
        //result = a[i] / 3;
        //Console.Write((a[i] / 3)  + "\t");
        Console.Write("{0,2:F2}",(a[i] / 3)  + "\t");
    }
    //return result;
}


int[,] array = CreateArray(3, 4);
PrintArray(array);
Console.WriteLine();
//int[,] ar = CreateArray(3, 1);
//PrintArray(ar);


Console.Write("Средне арифметическое по слобцам: ");
FindDigit(array);


//return "[" + String.Join(", ", array) + "]";
