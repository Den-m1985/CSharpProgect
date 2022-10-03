//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


// Создаем длину массива
double [] Create(double len)
{
    return new double[len];
}

// Заполняем массив
void Fill(int[] array, int min, int max)
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

// Находим разницу чисел.
double SearchSubstraction(double[] array)
{
    int size = array.Length;
    double min = 0;
    double max = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] > max)
        {
           max = array[i];
        }
    }
    for (int i = 0; i < size; i++)
    {
        if (array[i] < max)
        {
           min = array[i];
        }
    }
    double numberSubtraction = max - min;
    return numberSubtraction;
}



double[] arr = Create(12);
Fill(arr, 0, 999);
Console.WriteLine(Print(arr));
double result = SearchSubstraction(arr);
Console.Write("Разница между max и min: ");
Console.WriteLine((result));
//FindSum(result);

