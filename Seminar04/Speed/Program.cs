// Эта програмка расчитывает скорость работы кода



DateTime dtStart = DateTime.Now;

 int [] arr = new int [100_000_000];
 int r = 0;
 for (int i = 0; i < arr.Length; i++)
 {
    r += arr[i];
 }

DateTime dtEnd = DateTime.Now;
Console.WriteLine((dtEnd - dtStart).TotalMilliseconds);
