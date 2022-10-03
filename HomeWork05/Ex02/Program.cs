//Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


// Создаем длину массива
int[] Create(int len)
{
    return new int[len];
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
string Print(int[] array)
{
    return "[" + String.Join(", ", array) + "]"; //Скобки "[" для эфектного вывода. Разбирали на семинаре 4.
}

// Находим кол-во нечетных чисел.
int SearchOddDigit(int[] array)
{
    int size = array.Length;
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {

        }
        else
        {
            count += 1;
        }
    }
    return count;
}

// Находим сумму нечетных чисел.
int FindSum(int[] array)
{
    int size = array.Length;
    int sum = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {

        }
        else
        {
            sum = sum + array[i];
        }
    }

    return sum;
}

int[] arr = Create(12);
Fill(arr, 100, 999);
Console.WriteLine(Print(arr));
int result = SearchOddDigit(arr);
Console.Write("Ково нечетных чисел: ");
Console.WriteLine((result));
//FindSum(result);
Console.Write("Сумма нечетных чисел: ");
Console.WriteLine(FindSum(arr));