// 27. Определить количество цифр в числе


int numder = new Random().Next(1, 100000000);
int numder2 = numder;
int count = 0;
while (numder2 > 0)
{
    count+=1;
    numder2 /= 10;
}

Console.WriteLine(numder);
Console.WriteLine(count);

