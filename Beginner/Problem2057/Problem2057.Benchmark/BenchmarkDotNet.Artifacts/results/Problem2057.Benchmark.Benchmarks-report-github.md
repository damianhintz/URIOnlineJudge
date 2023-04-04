``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19045
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=7.0.202
  [Host]     : .NET Core 7.0.4 (CoreCLR 7.0.423.11508, CoreFX 7.0.423.11508), X64 RyuJIT
  Job-WMXNSE : .NET Core 7.0.4 (CoreCLR 7.0.423.11508, CoreFX 7.0.423.11508), X64 RyuJIT

RunStrategy=Monitoring  

```
|            Method |  X |  Y |  Z |       Mean |       Error |      StdDev |     Median |
|------------------ |--- |--- |--- |-----------:|------------:|------------:|-----------:|
|      **GetLocalTime** |  **0** |  **1** | **-5** |   **950.0 ns** |    **534.5 ns** |    **353.6 ns** |   **800.0 ns** |
| GetLocalTimeArray |  0 |  1 | -5 | 1,410.0 ns |  1,041.2 ns |    688.7 ns | 1,200.0 ns |
|      **GetLocalTime** |  **0** |  **1** |  **5** | **1,200.0 ns** |    **831.1 ns** |    **549.7 ns** | **1,000.0 ns** |
| GetLocalTimeArray |  0 |  1 |  5 | 1,230.0 ns |    825.2 ns |    545.8 ns | 1,200.0 ns |
|      **GetLocalTime** |  **0** | **12** | **-5** | **4,240.0 ns** | **15,368.0 ns** | **10,165.0 ns** |   **850.0 ns** |
| GetLocalTimeArray |  0 | 12 | -5 |   930.0 ns |    478.4 ns |    316.4 ns |   850.0 ns |
|      **GetLocalTime** |  **0** | **12** |  **5** | **1,250.0 ns** |  **1,191.0 ns** |    **787.8 ns** | **1,050.0 ns** |
| GetLocalTimeArray |  0 | 12 |  5 | 1,090.0 ns |    832.5 ns |    550.7 ns |   900.0 ns |
|      **GetLocalTime** | **23** |  **1** | **-5** | **1,130.0 ns** |    **890.3 ns** |    **588.9 ns** | **1,100.0 ns** |
| GetLocalTimeArray | 23 |  1 | -5 | 1,010.0 ns |    480.5 ns |    317.8 ns |   900.0 ns |
|      **GetLocalTime** | **23** |  **1** |  **5** |   **800.0 ns** |    **213.8 ns** |    **141.4 ns** |   **750.0 ns** |
| GetLocalTimeArray | 23 |  1 |  5 | 1,620.0 ns |  1,590.1 ns |  1,051.8 ns | 1,200.0 ns |
|      **GetLocalTime** | **23** | **12** | **-5** |   **930.0 ns** |    **349.5 ns** |    **231.2 ns** |   **850.0 ns** |
| GetLocalTimeArray | 23 | 12 | -5 | 1,080.0 ns |    487.6 ns |    322.5 ns | 1,000.0 ns |
|      **GetLocalTime** | **23** | **12** |  **5** | **1,180.0 ns** |    **805.7 ns** |    **532.9 ns** | **1,000.0 ns** |
| GetLocalTimeArray | 23 | 12 |  5 | 1,030.0 ns |    680.1 ns |    449.8 ns |   850.0 ns |
