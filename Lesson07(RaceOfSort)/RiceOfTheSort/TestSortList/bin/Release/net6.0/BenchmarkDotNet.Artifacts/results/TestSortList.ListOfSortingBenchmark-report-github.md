``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i5-10300H CPU 2.50GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT


```
|              Method |       Mean |     Error |    StdDev | Rank |  Gen 0 | Allocated |
|-------------------- |-----------:|----------:|----------:|-----:|-------:|----------:|
|       TestQuickSort |  46.887 μs | 0.3508 μs | 0.3110 μs |    3 | 0.9155 |      4 KB |
|      TestBubbleSort | 652.619 μs | 6.1185 μs | 5.4239 μs |    6 |      - |      4 KB |
|   TestSelectionSort | 268.170 μs | 1.6272 μs | 1.5221 μs |    4 | 0.4883 |      4 KB |
|    TestCountingSort |   2.375 μs | 0.0244 μs | 0.0228 μs |    1 | 0.9766 |      4 KB |
|      TestShakerSort | 623.781 μs | 2.9183 μs | 2.5870 μs |    5 |      - |      4 KB |
| TestQuickDotnetSort |   8.825 μs | 0.1459 μs | 0.1364 μs |    2 | 0.9613 |      4 KB |
