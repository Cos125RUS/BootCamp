// int[] array = { 1, 5, 4, 1, 3, 4, 7, 4, 1, 2 };
// int m = 3;
// int max = 0;

// for (int i = 0; i <= array.Length - m; i++)
// {
//     int sum = 0;
//     for (int j = 0; j < m; j++)
//         sum += array[i + j];

//     if (sum > max) max = sum;
// }
// Console.WriteLine($"Max = {max}");

using System.Diagnostics;
int size = 1000000;
int m = 3000;
int max = 0;

int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();

// Console.WriteLine($"[{string.Join(", ", array)}]");


Stopwatch sw = new();
// sw.Start();
// for (int i = 0; i <= size - m; i++)
// {
//     int t = 0;
//     for (int j = i; j < i + m; j++) t += array[j];
//     if (t > max) max = t;
// }
// sw.Stop();
// Console.WriteLine($"Max = {max}");
// Console.WriteLine($"Time = {sw.ElapsedMilliseconds}");

sw.Start();
int s = 0;
for (int j = 0; j < m; j++) s += array[j];
max = s;
for (int i = m; i < size; i++)
{
    s = s - array[i-m] + array[i];
    if (s > max) max = s;
}
sw.Stop();
Console.WriteLine();
Console.WriteLine($"Max = {max}");
Console.WriteLine($"Time = {sw.ElapsedMilliseconds}");