 //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Enter the first number");
int number1 = Convert.ToInt16(Console.ReadLine());

 Console.WriteLine("Enter the second number");
int number2 = Convert.ToInt16(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("max = ");
    Console.WriteLine(number1);
    Console.WriteLine("min = ");
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("max = ");
    Console.WriteLine(number2);
    Console.WriteLine("min = ");
    Console.WriteLine(number1);
}
