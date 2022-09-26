
int [] array = {24,68,648,34,34,4,434,44,33,4,45};

int n = array.Length;
int find = 4;
int i = 0;

while (i < n)
{

    if (array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}
