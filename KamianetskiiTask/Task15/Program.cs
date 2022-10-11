// 15. Дано число. Проверить кратно ли оно 7 и 23

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int number = ReadData("Введите чило");
int a = 7;
int b = 23;
if (number % a == 0) Console.WriteLine($"Число: {number} кратно: {a} ");
else Console.WriteLine($"Число: {number} не кратно: {a} ");

if (number % b == 0) Console.WriteLine($"Число: {number} кратно: {b} ");
else Console.WriteLine($"Число: {number} не кратно: {b} ");
