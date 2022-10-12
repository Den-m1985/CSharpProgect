
string[,] table = new string[2, 5];

for (int row = 0; row < 2; row++)
{
    for (int column = 0; column < 5; column++)
    {
        Console.WriteLine($"-{table[row, column]}-");
    }
}



// Факториал
double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}


//Числа Фибоначе
int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"{i} = {Fibonacci(i)}");
}

