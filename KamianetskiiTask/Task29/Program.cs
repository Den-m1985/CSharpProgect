// 29. Написать программу вычисления произведения чисел от 1 до N


int ReadData(string line)
{
    Console.Write(line);
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
    double result = 1;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        result *= array[i];
    }
    Console.Write(result);
}


void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int number = ReadData("Enter integer: ");
int[] array = CreateArray(number);
int[] arr = FullArray(array);
Console.Write("Original array: ");
PrintArray(arr);
Console.WriteLine();
Console.Write("Multiplication number: ");
Caiculate(array);

