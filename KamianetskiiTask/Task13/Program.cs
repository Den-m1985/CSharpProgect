// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
//Кратно  - значит делится без остатка.
//Задаем число и задаем второе число, проверяем будет ли первое/второе число = челое число.



int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int a = ReadData("Введите число: ");
int b = ReadData("Введите второе число: ");


if (a % b == 0)
{
    Console.WriteLine($"Число: {a} кратно: {b} ");
}
else
{
    Console.WriteLine($"Число: {a} не кратно: {b} ");
}