
decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecurtion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecurtion(n - 1) + FibonacciRecurtion(n - 2);
}

decimal FibonacciItaration(int n)
{
    fRec++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <=n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}



//Засекаем время
DateTime dt = DateTime.Now;

for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciItaration({n}) = {FibonacciItaration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);


Console.WriteLine();


//Засекаем время
dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecurtion({n}) = {FibonacciRecurtion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
