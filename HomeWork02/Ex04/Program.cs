//Задача 228: Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое
//1 2 3 4 5 6 7-> 4
//10 20 30 40 50 60 70 -> 40

//Немного доработал условие задачи чтоб не прописывать массив вручную.

Console.Clear();
/*
int[] array = new int[7];
int length = array.Length;

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(1, 7);
}
var str = String.Join(" ", array);
int sum = 0;
int average = 0;
for (int i = 0; i < length; i++)
{
    sum = sum + array[i];
    average = sum / length;
}

Console.WriteLine(str);
Console.Write("кол-во цифр в массиве: ");
Console.WriteLine(length);
Console.Write("Среднеарифметическое: ");
Console.Write(average);
*/

// Это решение мне предложил ревьювер:
Console.WriteLine("Введите планируемое количество чисел:");
int count = int.Parse(Console.ReadLine()??"");
int sum = 0;
for (int i = 0; i < count; i++)
{
Console.WriteLine($"Введите {i + 1}-ое число:");
int number = int.Parse(Console.ReadLine()??"");
sum = sum + number;
}
int average = sum / count;
Console.WriteLine(average);
