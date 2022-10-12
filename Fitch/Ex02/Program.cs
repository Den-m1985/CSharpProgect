
// Вывести из метода несколько значений

(int, int) Example1()
{
    int a = 1;
    int b = 2;
    return (a,b);
}

(int, int ) result = Example1();

Console.WriteLine($"result = {result}");
Console.WriteLine($"{result.Item1}");
Console.WriteLine($"{result.Item2}");

Console.WriteLine();

(int min, int max) Example2()
{
   
    return (3,4);
}
var result2 = Example2();
Console.WriteLine($"{result2.min}");
Console.WriteLine($"{result2.max}");