// 26. Возведите число А в натуральную степень B используя цикл


int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


void Caiculate(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    Console.Write(result);
}


int A = ReadData("Enter numder A: ");
int B = ReadData("Enter B: ");

Caiculate(A,B);


