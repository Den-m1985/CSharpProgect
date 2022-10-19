// 28. Подсчитать сумму цифр в числе

int numder = new Random().Next(1, 100000000);
int numder2 = numder;

int sum = 0;
while (numder2 > 0)
{
    sum = sum + numder2 % 10;
    numder2 = numder2 / 10;
}


Console.WriteLine(numder);
Console.WriteLine(sum);
