// 

int[,] pic = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 9] = 1;
    pic[9, i] = 1;
}

PrintImage(pic);
fillImage(1, 1);
Console.WriteLine();
PrintImage(pic);
fillImage(1, 1);

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}


void fillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        fillImage(row - 1, col);
        fillImage(row, col - 1);
        fillImage(row + 1, col);
        fillImage(row, col + 1);
    }
}

