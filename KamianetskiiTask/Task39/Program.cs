// 39. Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.Write("[" + String.Join(", ", array) + "]");
    return array;
}


void Calculate(int[] array, int size)
{
    int multiplication = 0;
    for (int i = 0; i < size / 2; i++)
    {
        multiplication = array[i] * array[size - i - 1];
        Console.Write(multiplication + " ");
    }
}


int size = 6;
Console.WriteLine();
int[] array = CreateArray(size);
Console.WriteLine();
Calculate(array, size);

