// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


int []array = {10,99,2,3,62,2556};
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max)
    {
        max = array[i];
    }
}
Console.WriteLine(max);