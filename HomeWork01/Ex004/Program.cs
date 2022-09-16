//  Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Enter the number");
int number = Convert.ToInt16(Console.ReadLine());

//for (int i = 0; (number % 2==0); i++)
//{
 //   Console.WriteLine();
//}

//int[] array = new int [number];
//int [] array = {1,2,3,4,5,6};
//DisplayArray(array);
//Console.WriteLine();


 //int number = 2;
 int i = 2;
            while (i <= number)
            {
                int result = number % 2;
                if (result != 1)
                {
                    Console.Write("_"+ number);
                    i++;
                }
                else
                {
                    i++;
                }
            }