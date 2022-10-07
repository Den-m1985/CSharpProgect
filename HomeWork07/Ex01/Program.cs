// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


double[,] CreateArray (int a, int b)
{
    double [,] array = new double [a,b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i,j] = new Random().NextDouble()*10-5;
            //Console.Write("{0,6:F2}",ar[i,j]);
        }
    //Console.WriteLine();
    }
    return array;
}


// выводим двухмерный массив в консоль с табуляцией по столбцам
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Console.Write($"{array[i, j]} \t");
            Console.Write("{0,6:F1}",array[i,j]);
        }
        Console.WriteLine();
    }
}


double[,] result = CreateArray(3,4);
PrintArray(result);
//Console.Write("{0,6:F2}",Array1(2,3));
