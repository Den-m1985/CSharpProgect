/*
Генерировать случайное число, если его нет в последовательности — добавлять,
если есть — повторить генерацию случайного числа и т д

При таком подходе есть проблема — ГПСЧ будет повторять числа,
по мере уменьшения общей выборки, что мы можем наблюдать:

для массива из 10 элементов на 10 попытах заполнение выглядит так
Потребовалось шагов: 11
Потребовалось шагов: 11
Потребовалось шагов: 10
Потребовалось шагов: 10
Потребовалось шагов: 12
Потребовалось шагов: 10
Потребовалось шагов: 10
Потребовалось шагов: 12
Потребовалось шагов: 11
Потребовалось шагов: 10
для массива из 50 элементов на 10 попытах заполнение выглядит так:
Потребовалось шагов: 89
Потребовалось шагов: 72
Потребовалось шагов: 66
Потребовалось шагов: 67
Потребовалось шагов: 72 
Потребовалось шагов: 67 
Потребовалось шагов: 78 
Потребовалось шагов: 72 
Потребовалось шагов: 75 
Потребовалось шагов: 69
для массива из 80 элементов на 10 попытах заполнение выглядит так:
Потребовалось шагов: 211
Потребовалось шагов: 178
Потребовалось шагов: 211 
Потребовалось шагов: 160 
Потребовалось шагов: 229 
Потребовалось шагов: 192 
Потребовалось шагов: 200 
Потребовалось шагов: 198 
Потребовалось шагов: 222 
Потребовалось шагов: 213
для массива из 90 элементов на 10 попытах заполнение выглядит так:
Потребовалось шагов: 373
Потребовалось шагов: 340
Потребовалось шагов: 377 
Потребовалось шагов: 276 
Потребовалось шагов: 358 
Потребовалось шагов: 455 
Потребовалось шагов: 408 
Потребовалось шагов: 338 
Потребовалось шагов: 391 
Потребовалось шагов: 472
Как вы понимаете, массив из 91 элемента не заполнится никогда и,
фактически, ваша программа уйдёт в бесконечный цикл и "зависнет".
*/


// Надо его додумать. Не заполняет числами.
int[] GetUniqueSequencesWithRandomPos(int count, int startValue, int length)
{
    //int step = 0; // логика подсчета шагов
    int[] set = new int[count];
    int index = 0;
    int size = set.Length;
    while (index < size)
    {
        int value = 0;
        while (Array.IndexOf(set, value) != -1)  //!= -1 Означает, что такого элемента нет.
        {
            value = Random.Shared.Next(startValue, startValue + length);
            //step++;
        }
        set[index++] = value;
    }
    //Console.Write(set);
    return set;
}

int[] result = GetUniqueSequencesWithRandomPos(10, 10, 90);
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}


Console.WriteLine();
Console.WriteLine();


//Второй способ.
int[] GetUniqueSequencesWithMix(int count, int startValue = 10)
{
    int[] set = new int[count];
    int size = set.Length;
    for (int i = 0; i < size; i++)
    {
        set[i] = startValue + i;
        Console.Write(set[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < size - 1; i++)
    {
        int pos = Random.Shared.Next(i + 1, size);
        (set[i], set[pos]) = (set[pos], set[i]);
        Console.Write(set[i] + " ");
    }
    return set;
}
int[] result2 = GetUniqueSequencesWithMix(10);
//Console.Write(result2 + " ");  //Не работает

Console.WriteLine();
Console.WriteLine();

//3 способ.
int k = 0;
int temp = 0;
int flagItem = 0;
int[] set3 = new int[10];
int size = set3.Length;
while (k < size)
{
    int flag = 0;
    temp = new Random().Next(10, 99);
    for (int i = 0; i < size; i++)
    {
        if (set3[i] == temp)
        {
            flagItem++;
            flag++;
        }
    }
    if (flag == 0)
    {
        set3[k] = temp;
        Console.Write(set3[k] + " ");
        k++;
    }
}
Console.WriteLine();
Console.WriteLine("Кол-во попыток:" + flagItem);




