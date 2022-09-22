// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int Numbers = Convert.ToInt32(Console.ReadLine());

if (Numbers >= 100 && Numbers <= 99999)
{
    Console.WriteLine("Третья цифра: {0} ", Numbers.ToString().ToCharArray()[2]);
}
else
{
    Console.WriteLine("Упссс, что-то пошло не так. Не хватает цифр, их много, или поменяй знак на +");
}

Console.Write("Нажми пробел чтобы выйти");
Console.ReadKey();
