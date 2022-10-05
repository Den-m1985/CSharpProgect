// 7. Показать числа от -N до N



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


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]+1;
    }
}


void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}



int a = ReadData("Введите отрицательное число: ");
int b = ReadData("Введите положительное число: ");

int length = b-a;
int[] arr = CreateArray(length);
int result = FillArray(arr);
PrintArray(result);


