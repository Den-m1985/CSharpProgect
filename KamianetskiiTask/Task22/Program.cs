// 22. Найти расстояние между точками в пространстве 2D/3D

int x1 = 1;
int y1 = 1;
int x2 = 5;
int y2 = 5;
double result = 0;

result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
result = Math.Round(result, 2);  //Округляем до 2 знаков.
Console.WriteLine(result);

