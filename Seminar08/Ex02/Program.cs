
List<int> arr = new();
arr.Add(1);
arr.Add(154);
arr.Add(1635);
arr.Add(135);
arr.Add(135);
var res = arr.FindAll(el => el %2 ==0).ToList();

Console.WriteLine(String.Join(" ", arr));