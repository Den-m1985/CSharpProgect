//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Введите 3-х значное число");
int source = Convert.ToInt32(Console.ReadLine());

if (source >99 && source < 1000)
{
    //Console.WriteLine("Вторая цифра: {0} ", ThreeNumbers.ToString().ToCharArray()[1]);
    source/= 10;
    int SecondNumber = source % 10;
    Console.WriteLine("Второе число: " + SecondNumber );
    //Console.WriteLine(SecondNumber);
}
else
{
    Console.WriteLine("Упссс, что-то пошло не так. Не хватает цифр, их много, или поменяй знак на +");
}
Console.WriteLine("Нажми пробел чтоб выйти");
Console.ReadKey();