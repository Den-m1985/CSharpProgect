/* Задача 21
Напишите метод, который принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53  */

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

//Находим растояние
double FindLen(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}


int x1 = ReedData("Введите координату х первой точки: ");
int y1 = ReedData("Введите координату у первой точки: ");
int z1 = ReedData("Введите координату z первой точки: ");
int x2 = ReedData("Введите координату x второй точки: ");
int y2 = ReedData("Введите координату y второй точки: ");
int z2 = ReedData("Введите координату z второй точки: ");

double result = FindLen(x1, y1, z1, x2, y2, z2);

result = Math.Round(result, 2);     // округляем до ,х чисел

PrintData("точка А:", (x1, y1, z1).ToString());
PrintData("точка B:", (x2, y2, z2).ToString());
PrintData("Расстояние между точками: ", result.ToString());
