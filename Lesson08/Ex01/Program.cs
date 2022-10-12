
string NummbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = 1; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NummbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NummbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NummbersFor(1, 10));
Console.WriteLine(NummbersRec(1, 10));
//1 2 3 4 5 6 7 8 9 10
//1 2 3 4 5 6 7 8 9 10



string NummbersFor1(int c, int d)
{
    string result = String.Empty;
    for (int i = 1; i >= d; i--)
    {
        result += $"{i} ";
    }
    return result;
}

Console.WriteLine(NummbersFor1(1, 10));

//Что-то в этом методе не так. Хотя это копия с лекции.
string NummbersRec1(int e, int f)
{
    if (e <= f) return NummbersRec1(e + 1, f) + $"{e} ";
    else return String.Empty;
}

Console.WriteLine(NummbersRec1(1, 10));



Console.WriteLine();

int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));


Console.WriteLine();


int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));


Console.WriteLine();


int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}


Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));


Console.WriteLine();


int n =0;
void FindWords(string alfabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alfabet.Length; i++)
    {
        word[length] = alfabet[i];
        FindWords(alfabet, word, length + 1);
    }
}

FindWords("аисв", new char[2]);