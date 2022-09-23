//Задача 228: Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое
//1 2 3 4 5 6 7-> 4
//10 20 30 40 50 60 70 -> 40

//Немного доработал условие задачи чтоб не прописывать массив вручную.

Console.Clear();

int[] array = new int[7];
int Length = array.Length;

for (int i = 0; i < Length; i++)
{
    array[i] = new Random().Next(1, 7);
}
var str = String.Join(" ", array);
int sum = 0;
int average = 0;
for (int i = 0; i < Length; i++)
{
    sum = sum + array[i];
    average = sum / Length;
}

Console.WriteLine(str);
Console.Write("кол-во цифр в массиве: ");
Console.WriteLine(Length);
Console.Write("Среднеарифметическое: ");
Console.Write(average);

