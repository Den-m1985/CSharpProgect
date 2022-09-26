/*
Напишите программу, которая принимает на вход координаты 2 точек и
находит расстояние между ними в 2D пространстве.
А(3,6); В(2,1)  = 5,09
А(7,-5); В(1-,1)   =  7,21
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


double FindLen(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}


int x1 = ReedData("Введите координату х первой точки: ");
int y1 = ReedData("Введите координату у первой точки: ");
int x2 = ReedData("Введите координату х второй точки: ");
int y2 = ReedData("Введите координату у второй точки: ");

double result = FindLen(x1,y1,x2,y2);
result = Math.Round(result, 3);

PrintData("Расстояние между точками: ",result.ToString());
