using static Sorting;
using System.Diagnostics;

Stopwatch sw = new();

sw.Start();

int size = 100;
var arr = size.CreateArray()
            .Show()
            .SortQuick(0, size - 1)
            .Show();
sw.Stop();
Console.WriteLine($"Time = {sw.ElapsedMilliseconds}");