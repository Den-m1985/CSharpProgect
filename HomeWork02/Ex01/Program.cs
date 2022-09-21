//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Введите 3-х значное число");
int ThreeNumbers = Convert.ToInt32(Console.ReadLine());

if (ThreeNumbers >= 100 && ThreeNumbers <= 999)
{
    ThreeNumbers/= 10;
    int SecondNumber = ThreeNumbers % 10;
    Console.Write("Второе число ");
    Console.WriteLine(SecondNumber);
    }
else
{
    Console.WriteLine("Упссс, что-то пошло не так. Не хватает цифр, их много, или поменяй знак на +");
}
Console.Write("Нажми пробел чтоб выйти");
Console.ReadKey();