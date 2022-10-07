// 8. Показать четные числа от 1 до N


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int[] CreateArray(int length)
{
    return new int[length];
}


int RandomDigit(int min, int max)
{
    return new Random().Next(min, max);
}


int[] FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = RandomDigit(min, max);
    }
    array[0] = 1;
    return array;
}


string PrintArray(int[] array)
{
    return "[" + String.Join(", ", array) + "]"; //Скобки "[" для эфектного вывода. Разбирали на семинаре 4.
}


int Calculate(int[] array)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] FillArrayEvent(int[] array, int count)
{
    int index = 0;
    int[] arrayEvent = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            arrayEvent[index] = array[i];
            index += 1;
        }

    }
    return arrayEvent;
}


int number = ReadData("Введите число: ");
int size = number;
int[] array = CreateArray(size);
FillArray(array, 1, number);
Console.WriteLine(PrintArray(array));
int count = Calculate(array);
Console.Write("Кол-во четных чисел: ");
Console.WriteLine(count);
int[] arrayEvent = FillArrayEvent(array, count);
Console.WriteLine(PrintArray(arrayEvent));
