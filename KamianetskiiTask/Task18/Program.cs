// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// не(X или Y) равно не X и  не Y

//-(X+Y) = -X *-Y    Я понял это так.
int X = 1;
int Y = 1;
int a = -(X+Y);
int b = (-X)*(-Y);
if(a == b)Console.WriteLine("Равенство равно");
else Console.WriteLine("Равенство не равно");
