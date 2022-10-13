

// задачка соспиральным массивом.
int N = 4;
int val = 1;
int x = -1;
int y = 0;
int[,] array = new int[N, N];
for (int i = 1; i < 2 * N; i++)
{
    for (int j = 0; j < N - i / 2; j++)
    {
        array[y += (i % 4 - 1) % 2, x -= (i % 4 - 2) % 2] = val++;
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
