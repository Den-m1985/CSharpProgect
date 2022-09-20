//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Введите 3-х значное число");
int number = Convert.ToInt32(Console.ReadLine());
/*
int a = 12545;
string str = a.ToString();
Console.WriteLine(str[4]);
*/

int k= number;
while (k >= 100) k /= 10;
{
    if (number >= 100)
    {
        int d = k % 10;
        Console.Write("Второе число ");
        Console.WriteLine(d);
    } 
    else
    {
        Console.WriteLine("Упссс, что-то пошло не так. Не хватает цифр, или поменяй знак на +");
    }
    
}
Console.Write("Нажми пробел чтоб выйти");
Console.ReadKey();