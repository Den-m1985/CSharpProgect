
void FillArray(int [] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection [index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int possition = 0;
    while (possition < count)
    {
        Console.Write($"{col[possition]} ");
        possition++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int possition = -1;    // Почему -1? Показывает, что предуемое значение не найдено, если ставить 0, то любое число вне массива будет 0.

    while (index < count)
    {
        if (collection[index] == find)
        {
         possition = index;  
         break;       //Останавливает счетчик если нашел нужное число
        }
        index++;
    }
    return possition;
}

int [] array = new int [15];     // Задаем длину массива
FillArray(array);
PrintArray(array);
Console.WriteLine();    // Нужно чтоб разделить массив от счетчика

int pos = IndexOf(array, 4);    // Здесь указываем число, которое необходимо найти
Console.WriteLine (pos);
