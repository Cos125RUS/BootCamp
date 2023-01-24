int n = 5;
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine("Enter: "));
Console.WriteLine("[" + string.Join(" ", array) + "]");
Console.WriteLine(array[3]);