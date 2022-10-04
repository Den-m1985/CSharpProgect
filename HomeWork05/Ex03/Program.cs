//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


// Создаем длину массива
double[] Create(int len)
{
    return new double[len];
}

// Заполняем массив
void Fill(double[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

// печатаем массив
string Print(double[] array)
{
    return "[" + String.Join(", ", array) + "]"; //Скобки "[" для эфектного вывода. Разбирали на семинаре 4.
}

// Находим max.
double FindMax(double[] array)
{
    int size = array.Length;
    double max = array[0];

    for (int i = 0; i < size; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

// Находим min.
double FindMin(double[] array)
{
    int size = array.Length;
    double min = array[0];

    for (int i = 0; i < size; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


double[] arr = Create(5);
Fill(arr, -10, 100);
Console.WriteLine(Print(arr));
double max = FindMax(arr);
double min = FindMin(arr);
double result = max - min;
Console.Write("max: ");
Console.WriteLine(max);
Console.Write("min: ");
Console.WriteLine(min);
Console.Write("Разница между max и min: ");
Console.WriteLine(result);

