// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int source = Convert.ToInt32(Console.ReadLine());
int number = 0;
int thirdNumber = 0;
if (source > 99 && source <= 99999)
{
    if (source > 99)
    {
        number = source;
    }
    if (source > 999)
    {
        number = source / 10 % 10;
    }
    if (source > 9999)
    {
        number = source / 100 % 10;
    }
    if (source > 99999)
    {
        number = source / 1000 % 10;
    }
    else
    {
        thirdNumber = number % 10;
        Console.Write("Третье число ");
        Console.WriteLine(thirdNumber);
    }

    //Console.WriteLine("Третья цифра: {0} ", source.ToString().ToCharArray()[2]);
}
else
{
    Console.WriteLine("Упссс, что-то пошло не так. Не хватает цифр, их много, или поменяй знак на +");
}


Console.Write("Нажми пробел чтобы выйти");
Console.ReadKey();
