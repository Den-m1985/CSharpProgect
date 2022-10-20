// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
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
            positiveNumber += array[i];
        }
        else
        {
            negativeNumber += array[i];
        }
    }
    Console.Write("Sum positiveNumber: ");
    Console.WriteLine(positiveNumber);
    Console.Write("Sum negativeNumber: ");
    Console.WriteLine(negativeNumber);

}


int size = 12;
int[] array = CreateArray(size);
Console.WriteLine();
Calculate(array, size);


