// 34. Написать программу замену элементов массива на противоположные


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


void Calculate(int[] array, int size)
{

    for (int i = 0; i < size; i++)
    {
        array[i] = array[i] * -1;
    }

    Console.Write("[" + String.Join(", ", array) + "]");
}


int size = 12;
int[] array = CreateArray(size);
Console.WriteLine();
Calculate(array, size);
