﻿// Задача 60. ...Сформируйте трёхмерный массив из 
//неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив
// добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)


void CreateArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
}



void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
                Console.Write($" ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


//Этот метод показывает масив по слоям.
/*
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Индекс i={i} отвечает за обьем массива т.е. Z");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
                Console.Write($" ({j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
*/

int[,,] array = new int[2, 2, 2];
CreateArray(array);
PrintArray(array);
