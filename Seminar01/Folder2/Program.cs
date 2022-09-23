//По двум заданным числам проверять является ли первое квадратом второго
// Мы поняли это условие задачи вот так:

Console.WriteLine("Enter the first number");
int number1 = Convert.ToInt16(Console.ReadLine());

 Console.WriteLine("Enter the second number");
int number2 = Convert.ToInt16(Console.ReadLine());

int c = number1 * number1;
if (c == number2)
{
    Console.WriteLine("{number1} в квадрате = {number2}Равно");
}
else
{
    Console.WriteLine("Не равно");
}
