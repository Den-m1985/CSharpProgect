// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    Console.Write("[" + String.Join(", ", array) + "]");
    return array;
}


void Calculate(int[] array, int size)
{
    int positiveNumber = 0;
    int negativeNumber = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            positiveNumber++;
        }
        else
        {
            negativeNumber++;
        }
    }
    Console.Write("Count positive number: ");
    Console.WriteLine(positiveNumber);
    Console.Write("Count negative number: ");
    Console.WriteLine(negativeNumber);

}


int size = 12;
Console.WriteLine();
int[] array = CreateArray(size);
Console.WriteLine();
Calculate(array, size);
