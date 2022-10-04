//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// Читаем данные с консоли
int ReedData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// Создаем массив
int[] CreateArray(int size)
{
    return new int[size];
}

// печатаем массив
string PrintArray(int[] array)
{
    return "[" + String.Join(", ", array) + "]"; //Скобки "[" для эфектного вывода. Разбирали на семинаре 4.
}

// Находим числа.
int FindCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}


int Length = ReedData("Введите кол-во элементов: ");
int[] size = CreateArray(Length);
for (int i = 0; i < size.Length; i++)
{
    size[i] = ReedData($"Введите число:{i}: ");
}


Console.Write("Массив: ");
Console.WriteLine(PrintArray(size));
Console.Write("Кол-во чисел больше 0: ");
Console.Write(FindCount(size));

