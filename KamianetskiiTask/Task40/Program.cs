// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом



double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 10 - 5;
        array[i] = Math.Round(array[i], 3);
    }
    Console.Write("[" + String.Join(", ", array) + "]");
    return array;
}


void Calculate(double[] array, int size)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] < min) min = array[i];
        else max = array[i];
    }
    Console.WriteLine($"max: {max}");
    Console.WriteLine($"min: {min}");
    Console.WriteLine($"max - min: {max - min}");
}


int size = 6;
Console.WriteLine();
double[] array = CreateArray(size);
//double[] array = Math.Round(double array, 2);
Console.WriteLine();
Calculate(array, size);

