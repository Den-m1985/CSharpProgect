/* Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да  
*/


int ReedData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}


string PolyandrTest(int num)
{
   if (num /10000 == num%10 && num /1000 == (num/10)%10)
    
    return "число полиндром";
    else
    return "число неполиндром";
}


if (num >= 10000 && num < 100000)
{
    PrintData();
}
else
{
    PrintData();
}
