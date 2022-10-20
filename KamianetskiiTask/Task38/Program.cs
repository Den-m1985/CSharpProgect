// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции


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
    int negativeNumber = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 != 0)
        {
            negativeNumber += array[i];
        }
    }
    Console.Write("Sum negative number: ");
    Console.WriteLine(negativeNumber);
}


int size = 6;
Console.WriteLine();
int[] array = CreateArray(size);
Console.WriteLine();
Calculate(array, size);

