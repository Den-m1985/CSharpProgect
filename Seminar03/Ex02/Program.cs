//Дан массив, нужно сформировать 
// новый массив из четных чисел

int[] source = { 2, 2, 5, 8, 6, 9, 7, 8, 5, 2 };

int count = 0;
for (int i = 0; i < source.Length; i++)
{
    if ((source[i] % 2) == 0)
        count++;

}
//Console.Write(count);
int[] evenElements = new int[count];

int index = 0;
for (int i = 0; i < source.Length; i++)
{
    if ((source[i] % 2) == 0)
    {
        evenElements[index] = source[i];
        index++;
    }
}


for (int i = 0; i < evenElements.Length; i++)
{
    System.Console.Write(evenElements[i]+" ");
}
Console.WriteLine();