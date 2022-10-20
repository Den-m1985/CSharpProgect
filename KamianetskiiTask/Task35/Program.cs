// 35. Определить, присутствует ли в заданном массиве, некоторое число 



int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    Console.Write("[" + String.Join(", ", array) + "]");
    return array;
}


void Calculate(int[] array, int size, int number)
{
    int count =0;
    for (int i = 0; i < size; i++)
    {
        if (number == array[i]) count ++;
    }

    if (count == 0) Console.Write($"Random number {number} is not present in thise array");
    else Console.Write($"Random number {number} is present in thise array");
}


int size = 12;
Console.WriteLine();
int[] array = CreateArray(size);
Console.WriteLine();
int number = new Random().Next(-10, 10);
Calculate(array, size, number);
Console.WriteLine();



