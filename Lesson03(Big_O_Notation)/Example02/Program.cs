Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//         Console.Write(i*j + "\t");
//     Console.WriteLine();
// }

Console.WriteLine();
Console.WriteLine();
Console.Clear();
for (int i = 1; i <= n; i++)
{
    Console.SetCursorPosition(4 * i, i);
    Console.Write(i * i);
    for (int j = i + 1; j <= n; j++)
    {
        Console.SetCursorPosition(4 * j, i);
        Console.Write(i * j);
        Console.SetCursorPosition(4 * i, j);
        Console.Write(i * j);
    }
}