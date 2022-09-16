//  Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Enter the number");
int number = Convert.ToInt16(Console.ReadLine());

 if ((number % 2) == 0)
{
    Console.Write(number);
    Console.WriteLine(" число четное");
}
else
{
    Console.Write(number);
    Console.WriteLine(" число не четное");
}
