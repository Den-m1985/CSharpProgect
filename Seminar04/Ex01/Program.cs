// Задача 35
//Задайте одномерный массив из 123 случайных чисел
//Найдите кол-во элементов массива, значения которых
//лежат в отрезке(10,99)

//Создаем массив
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
    return "[" + String.Join(", ", array) + "]";
    //Скобки "[" для эфектного вывода.
}

/*"[" + String.Join(", ", array) +"]";
Эту строчку можно записать по другому:
for (int i = 0; i < array.length; i++)
{
    if (i<array.length-1) result = result + array[i] + ", ";      
    else result = result + array[i]
}      */


int Search(int[] array, int findMin, int findMax)
{
    int size = array.Length;
int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] >= findMin && array[i] <= findMax)
    {
        count++;
    }
}
return count;
}


int[] arr = Create(12);
Console.WriteLine(arr);
Fill(arr, 1, 200);
Console.WriteLine(Print(arr));
Console.WriteLine(Search(arr, 10 ,99));

