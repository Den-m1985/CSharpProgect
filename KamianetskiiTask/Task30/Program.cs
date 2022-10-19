// 30. Показать кубы чисел, заканчивающихся на четную цифру




double[] CreateArray(int number)
{
    double[] array = new double[number];
    return array;
}


double[] FullArray(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = i + 1;
    }
    return array;
}


double[] Caiculate(double[] array)
{
    int size = array.Length;
    int k = 0;
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[k] = Math.Pow(array[i], 3);
        k++;
    }
    return result;
}


void CaiculateEven(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            Console.Write(array[i] + "\t");
        }
    }
}


void PrintArray(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

int number = 10;   // Array length.
double[] array = CreateArray(number);
double[] arr = FullArray(array);
Console.Write("Original array: ");
PrintArray(arr);
Console.WriteLine();
Console.Write("    Cub number: ");
double[] arr2 = Caiculate(arr);
PrintArray(arr2);
Console.WriteLine();
Console.Write("   Even number: ");
CaiculateEven(arr2);

