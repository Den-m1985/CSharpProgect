// 23. Показать таблицу квадратов чисел от 1 до N


int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int[] CreateArray(int number)
{
    int[] array = new int[number];
    return array;
}


int[] FullArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = i + 1;
    }
    return array;
}


void Caiculate(int[] array)
{
    double result = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        result = Math.Pow(array[i], 2);
        Console.Write(result + "\t");
    }
}


void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

int number = ReadData("Enter integer: ");
int[] array = CreateArray(number);
int[] arr = FullArray(array);
Console.Write("Original array: ");
PrintArray(arr);
Console.WriteLine();
Console.Write("Square number: ");
Caiculate(array);

