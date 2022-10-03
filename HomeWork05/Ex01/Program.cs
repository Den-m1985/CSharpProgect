//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


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

// Находим кол-во четных чисел.
int SearchEven(int[] array)
{
    int size = array.Length;
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] arr = Create(12);
Fill(arr, 100, 999);
Console.WriteLine(Print(arr));
int result = SearchEven(arr);
Console.Write("Кол-во четных чисел: ");
Console.WriteLine(result);
