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


void FillArray(int[] array, int a)
{
    for (int i = 0; i < array.Length; i++)
    {
       
        array[i] = (a-1) +1;
        a ++;
       
        //array[i] = a.Next(1);
    }
}


void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



int a = ReadData("Введите отрицательное число: ");
int b = ReadData("Введите положительное число: ");

int length = b-a+1;   //+1 Нужен для отображения полного списка чисел.
int[] arr = CreateArray(length);
PrintArray(arr);
FillArray(arr,a);
PrintArray(arr);

