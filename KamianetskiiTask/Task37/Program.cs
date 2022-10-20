// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]



int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 999);
    }
    Console.Write("[" + String.Join(", ", array) + "]");
    return array;
}


void Calculate(int[] array, int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= 10 && array[i] <=99)
        {
            count++;
        }
        
    }
    Console.Write("Count numbers: ");
    Console.WriteLine(count);
   

}


int size = 123;
Console.WriteLine();
int[] array = CreateArray(size);
Console.WriteLine();
Calculate(array, size);

