//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.WriteLine("Введите число");
int source = Convert.ToInt32(Console.ReadLine());

if (source > 0 && source < 8)
{
    if (source > 5 && source < 8)
    {
        Console.Write("Этот день выходной: ");
        Console.WriteLine(source);

    }
    else
    {
        Console.Write("В этот день иди работай: ");
        Console.WriteLine(source);
    }

}
else
{
    Console.WriteLine("Упссс, что-то пошло не так. Не хватает цифр, их много, или поменяй знак на +");
}

Console.Write("Нажми пробел чтобы выйти");
Console.ReadKey();