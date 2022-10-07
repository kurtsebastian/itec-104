
List<int> list = new List<int>();
List<int> list2 = new List<int>();

Console.WriteLine();



int[] num = { 10, 20, 35, 65, 53, 48, 5, 1 };

list.AddRange(num);

foreach (int n in num)
    Console.Write(n + " ");

Console.WriteLine();

foreach (int n in num)
{
    if (n % 10 != 5)
    {
        list2.Add(n);
        Console.Write(n + " ");


    }


}
