/*
Есть магазин "Еда".
В магазине есть охранник.
Охранник ведёт запись всех, кто заходит в магазин.
Охранник ведёт запись всех, кто выходит из магазина.
Зайти и выйти можно в целый час.
Выяснить в какой промежуток времени было больше всего посетителей.
Данные вводятся парами: приход-уход.
Максимум 100 покупателей.
Входные данные:
10-12
11-13
9-12
Ответ:
11-12
*/


int ReedData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


int GetIntValue(int min, int max)
{
  return new Random().Next(min, max);
}

int[] CreateArray(int size)
{
  return new int[size];
}

void Fill(int[] array)
{
  int size = array.Length;
  int i = 0;

  while (i < size)
  {
    array[i] = GetIntValue(1, 23);// часы работы с 1 -23.
    i++;
  }
}

void Print(int[] array)
{
  int i = 0;
  int size = array.Length;
  while (i < size)
  {
    Console.Write(array[i] + " ");
    i++;
  }
  Console.WriteLine();
}



/*
int[] array1 = { 9, 10, 11, 12 };
int[] array2 = { 10, 11, 12 };
int[] array3 = { 11, 12, 13 };

int FindOverlap(int array)
{
    int overLap = 0;
    for (int i1 = 0; i1 < array1.Length; i1++)
    {
        for (int i2 = 0; i2 < array2.Length; i2++)
        {
            if (array1[i1] == array2[i2])
            {
                //Если данные совпали
                for (int i3 = 0; i3 < array3.Length; i3++)
                {
                    if (array2[i2] == array3[i3])
                    {
                        //Если данные совпали
                        overLap = array1[i1];
                    }
                }
            }
        }
        Console.WriteLine(overLap);
    }
    return overLap;
}
*/
void PrintData(string prefix, string value)
{
    Console.Write(prefix + value);
}

int EnterMagazin1 = ReedData("Введите час входа в магазин 1го массива ");
int ExitMagazin1 = ReedData("Введите час выхода в магазин 1го массива ");
int EnterMagazin2 = ReedData("Введите час входа в магазин 2го массива ");
int ExitMagazin2 = ReedData("Введите час выхода в магазин 2го массива ");
int EnterMagazin3 = ReedData("Введите час входа в магазин 3го массива ");
int ExitMagazin3 = ReedData("Введите час выхода в магазин 3го массива ");

int length = GetIntValue(EnterMagazin1, ExitMagazin1);

int fjfgj = ExitMagazin1 - EnterMagazin1; //кол-во часов


int[] size1 = CreateArray(fjfgj);
//int size1 = ExitMagazin1 - EnterMagazin1;
int size2 = ExitMagazin2 - EnterMagazin2;
int size3 = ExitMagazin3 - EnterMagazin3;

Print(fjfgj);
Fill(fjfgj);

PrintData("", EnterMagazin1.ToString());
PrintData("-", ExitMagazin1.ToString());
Console.WriteLine();
PrintData("", EnterMagazin2.ToString());
PrintData("-", ExitMagazin2.ToString());
Console.WriteLine();
PrintData("", EnterMagazin3.ToString());
PrintData("-", ExitMagazin3.ToString());

Console.WriteLine();
Console.WriteLine(size1);




/*
//int overLap2 = FindOverlap(array4, array5, array6);
//Console.WriteLine(overLap2);

/*
int length = GetIntValue(10, 20);
int[] col = CreateArray(length);
Print(col);
Fill(col);
Print(col);
*/

//PrintData("", overLap2.ToString());

/*
int[] array1 = { 9, 10, 11, 12 };
int[] array2 = { 10, 11, 12 };
int[] array3 = { 11, 12, 13 };



int overLap = 0;
for (int i1 = 0; i1 < array1.Length; i1++)
{
    for (int i2 = 0; i2 < array2.Length; i2++)
    {
        if (array1[i1] == array2[i2])
        {
            //Если данные совпали
            for (int i3 = 0; i3 < array3.Length; i3++)
            {
                if (array2[i2] == array3[i3])
                {
                    //Если данные совпали
                    overLap = array1[i1];
                }
            }
        }
    }
    Console.WriteLine(overLap);
}
*/



// Этот код работает, но он обсолютно не знаком:
/*
IEnumerable<int> both = array.Intersect(array1);

foreach (int id in both)
    Console.WriteLine(id);*/