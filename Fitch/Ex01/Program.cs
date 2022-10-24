
//Здесь собраны примеры ввода массива с клавиатуры.



//void one_dimensional_arrays() // одномерный массив из 5 элементов, который заполняется пользователем
//{
/*
int[] A = new int[5]; // потом выделяю под него память для 5 элементов
for (int i = 0; i < 5; i++)                 //с помощью цикла for я заполняю массив с клавиатуры
{
    A[i] = int.Parse(Console.ReadLine()??""); Array.Sort(A);
    Console.WriteLine("Введите пять целых чисел через пробел:");
    //int[] one = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

    // найду максимальный элемент с помощью метода расширения Max 
    Array.Sort(A);
    int maxA = A[A.Length - 1];
    Console.WriteLine("Maximal element:" + A);
}*/
/*
int minA = A[5];
for (int i = 0; i < 5; i++)
{
    if (minA > A[i])
    {
        minA = A[i];
    }
    Console.WriteLine("Minimal element:" + A);
    Console.ReadLine();
}*/
//}


/*
static void one_dimensional_arrays_menu() //Меню для работы уже с одномерным массивом
{
    Console.WriteLine("One-dimensional array. Click on the corresponding number: 1. Fill the array");
    string selectoin = Console.ReadLine();
    switch (selectoin)
    {
        case "1":
            one_dimensional_array();
            break;
    }
}
*/


/*
Console.WriteLine("Enter five array elements"); //вывожу сообщение, чтобы пользователь ввел                  
            int[] A = new int[5];          
            for (int i = 0; i < 5; i++) //цикл позволяет ввести с клавиатуры с 0 до 5 элементов массива
            {
                A[i] = int.Parse(Console.ReadLine()); //ввод с клавиатуры                               
            }
*/


/*
Console.Clear();
double sum = 0;
int amount = 0;
int amTotal = 7; // Сколько чисел вводить
Console.WriteLine($"Введите {amTotal} любых чисел. После ввода каждого числа нажмите Enter.");
Console.WriteLine("Примеры написания числа: 1; 34; -8; 27,5; -347,24");
Console.WriteLine("Введены числа: ");
while (amount < amTotal)
{
    double number = double.Parse(Console.ReadLine());
    sum = sum + number;
    amount++;
}
Console.WriteLine($"Среднее арифметическое этих чисел: {sum / amTotal}");
*/


int[] array = new int[5];
for (int i = 0; i < 5; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write(string.Join(" ", array));
