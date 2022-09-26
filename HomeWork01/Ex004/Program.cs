//  Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
// Эта часть кода сделал сам.
/*
int [] EvenNumber = Enumerable.Range(0, number+1).ToArray();
for (int i = 2; i < EvenNumber.Length; i++)
{
 if (EvenNumber[i] % 2 == 0)
 Console.Write($"{EvenNumber[i]} ");
}
*/

// Этот правку предложил мне ревьювер, когда проверил домашку.
int [] EvenNumber = Enumerable.Range(2, number-1).ToArray();
for (int i = 0; i < EvenNumber.Length; i+=2)  //приращение на 2
{
    Console.Write($"{EvenNumber[i]} ");
}