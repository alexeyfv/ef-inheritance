``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 11 (10.0.22621.1105)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
| Method | EntitiesCount | mappingStrategy |      Mean |    Error |    StdDev |    Median |      Gen0 |      Gen1 |      Gen2 | Allocated |
|------- |-------------- |---------------- |----------:|---------:|----------:|----------:|----------:|----------:|----------:|----------:|
|    **Run** |           **200** |             **Tpc** |  **11.12 ms** | **0.221 ms** |  **0.462 ms** |  **11.04 ms** |  **312.5000** |  **171.8750** |         **-** |   **1.37 MB** |
|    **Run** |           **200** |             **Tph** |  **10.24 ms** | **0.204 ms** |  **0.417 ms** |  **10.12 ms** |  **265.6250** |  **187.5000** |         **-** |   **1.22 MB** |
|    **Run** |           **200** |         **TphJson** |  **10.29 ms** | **0.204 ms** |  **0.490 ms** |  **10.05 ms** |  **343.7500** |  **156.2500** |         **-** |   **1.38 MB** |
|    **Run** |           **200** |             **Tpt** |  **16.16 ms** | **0.298 ms** |  **0.695 ms** |  **16.00 ms** |  **406.2500** |  **250.0000** |         **-** |   **1.96 MB** |
|    **Run** |           **400** |             **Tpc** |  **19.08 ms** | **0.379 ms** |  **0.722 ms** |  **19.08 ms** |  **531.2500** |  **343.7500** |         **-** |   **2.67 MB** |
|    **Run** |           **400** |             **Tph** |  **17.54 ms** | **0.349 ms** |  **0.758 ms** |  **17.26 ms** |  **437.5000** |  **343.7500** |         **-** |   **2.39 MB** |
|    **Run** |           **400** |         **TphJson** |  **17.74 ms** | **0.351 ms** |  **0.807 ms** |  **17.45 ms** |  **625.0000** |  **312.5000** |         **-** |    **2.7 MB** |
|    **Run** |           **400** |             **Tpt** |  **27.53 ms** | **0.540 ms** |  **0.888 ms** |  **27.46 ms** |  **750.0000** |  **500.0000** |         **-** |   **3.79 MB** |
|    **Run** |           **600** |             **Tpc** |  **31.85 ms** | **0.502 ms** |  **0.392 ms** |  **31.85 ms** |  **687.5000** |  **312.5000** |   **62.5000** |    **4.1 MB** |
|    **Run** |           **600** |             **Tph** |  **32.14 ms** | **0.640 ms** |  **1.378 ms** |  **31.95 ms** |  **625.0000** |  **312.5000** |   **62.5000** |   **3.68 MB** |
|    **Run** |           **600** |         **TphJson** |  **31.62 ms** | **0.631 ms** |  **1.780 ms** |  **30.97 ms** |  **750.0000** |  **250.0000** |   **62.5000** |   **4.14 MB** |
|    **Run** |           **600** |             **Tpt** |  **46.41 ms** | **0.924 ms** |  **1.735 ms** |  **45.70 ms** | **1000.0000** |  **416.6667** |   **83.3333** |   **5.82 MB** |
|    **Run** |           **800** |             **Tpc** |  **42.37 ms** | **0.846 ms** |  **2.138 ms** |  **41.87 ms** |  **818.1818** |  **181.8182** |         **-** |   **5.29 MB** |
|    **Run** |           **800** |             **Tph** |  **40.73 ms** | **0.812 ms** |  **1.641 ms** |  **40.36 ms** |  **846.1538** |  **384.6154** |   **76.9231** |   **4.73 MB** |
|    **Run** |           **800** |         **TphJson** |  **39.87 ms** | **0.795 ms** |  **1.966 ms** |  **39.24 ms** | **1000.0000** |  **333.3333** |   **83.3333** |   **5.35 MB** |
|    **Run** |           **800** |             **Tpt** |  **61.42 ms** | **1.226 ms** |  **2.767 ms** |  **60.78 ms** | **1375.0000** |  **500.0000** |  **125.0000** |   **7.54 MB** |
|    **Run** |          **1000** |             **Tpc** |  **50.95 ms** | **1.002 ms** |  **1.674 ms** |  **50.83 ms** | **1100.0000** |  **400.0000** |  **100.0000** |   **6.48 MB** |
|    **Run** |          **1000** |             **Tph** |  **50.72 ms** | **1.004 ms** |  **2.306 ms** |  **50.36 ms** | **1000.0000** |  **363.6364** |   **90.9091** |   **5.78 MB** |
|    **Run** |          **1000** |         **TphJson** |  **49.01 ms** | **0.980 ms** |  **2.440 ms** |  **48.12 ms** | **1090.9091** |  **363.6364** |   **90.9091** |   **6.55 MB** |
|    **Run** |          **1000** |             **Tpt** |  **74.99 ms** | **1.493 ms** |  **3.717 ms** |  **73.87 ms** | **1714.2857** |  **714.2857** |  **142.8571** |    **9.4 MB** |
|    **Run** |          **1200** |             **Tpc** |  **64.33 ms** | **1.249 ms** |  **2.945 ms** |  **63.50 ms** | **1444.4444** |  **555.5556** |  **111.1111** |   **8.17 MB** |
|    **Run** |          **1200** |             **Tph** |  **62.41 ms** | **1.235 ms** |  **3.317 ms** |  **61.89 ms** | **1250.0000** |  **625.0000** |  **125.0000** |   **7.33 MB** |
|    **Run** |          **1200** |         **TphJson** |  **60.75 ms** | **1.205 ms** |  **3.217 ms** |  **59.60 ms** | **1375.0000** |  **500.0000** |  **125.0000** |   **8.26 MB** |
|    **Run** |          **1200** |             **Tpt** |  **92.34 ms** | **1.840 ms** |  **3.674 ms** |  **91.01 ms** | **2000.0000** |  **666.6667** |  **166.6667** |  **11.62 MB** |
|    **Run** |          **1400** |             **Tpc** |  **71.65 ms** | **1.432 ms** |  **2.546 ms** |  **70.77 ms** | **1625.0000** |  **625.0000** |  **125.0000** |   **9.36 MB** |
|    **Run** |          **1400** |             **Tph** |  **70.60 ms** | **1.482 ms** |  **4.300 ms** |  **70.18 ms** | **1428.5714** |  **571.4286** |  **142.8571** |   **8.37 MB** |
|    **Run** |          **1400** |         **TphJson** |  **69.71 ms** | **1.573 ms** |  **4.613 ms** |  **68.43 ms** | **1571.4286** |  **571.4286** |  **142.8571** |   **9.46 MB** |
|    **Run** |          **1400** |             **Tpt** | **108.72 ms** | **2.240 ms** |  **6.569 ms** | **105.92 ms** | **2400.0000** |  **800.0000** |  **200.0000** |  **13.33 MB** |
|    **Run** |          **1600** |             **Tpc** |  **85.27 ms** | **1.697 ms** |  **4.227 ms** |  **83.40 ms** | **1833.3333** |  **666.6667** |  **166.6667** |  **10.54 MB** |
|    **Run** |          **1600** |             **Tph** |  **82.81 ms** | **1.874 ms** |  **5.524 ms** |  **81.57 ms** | **1666.6667** |  **833.3333** |  **166.6667** |   **9.42 MB** |
|    **Run** |          **1600** |         **TphJson** |  **80.52 ms** | **2.044 ms** |  **5.962 ms** |  **78.25 ms** | **1714.2857** |  **571.4286** |  **142.8571** |  **10.65 MB** |
|    **Run** |          **1600** |             **Tpt** | **124.95 ms** | **2.493 ms** |  **6.612 ms** | **123.08 ms** | **2600.0000** | **1000.0000** |  **200.0000** |  **15.05 MB** |
|    **Run** |          **1800** |             **Tpc** |  **92.21 ms** | **1.840 ms** |  **5.067 ms** |  **90.83 ms** | **2000.0000** |  **800.0000** |  **200.0000** |  **11.72 MB** |
|    **Run** |          **1800** |             **Tph** |  **92.53 ms** | **1.950 ms** |  **5.657 ms** |  **91.27 ms** | **1800.0000** |  **800.0000** |  **200.0000** |  **10.47 MB** |
|    **Run** |          **1800** |         **TphJson** |  **87.26 ms** | **2.069 ms** |  **6.036 ms** |  **84.35 ms** | **2000.0000** |  **666.6667** |  **166.6667** |  **11.86 MB** |
|    **Run** |          **1800** |             **Tpt** | **136.14 ms** | **2.594 ms** |  **5.639 ms** | **133.88 ms** | **3000.0000** | **1000.0000** |  **333.3333** |  **16.76 MB** |
|    **Run** |          **2000** |             **Tpc** | **103.97 ms** | **2.047 ms** |  **5.429 ms** | **102.49 ms** | **2200.0000** |  **800.0000** |  **200.0000** |  **12.91 MB** |
|    **Run** |          **2000** |             **Tph** | **102.64 ms** | **2.190 ms** |  **6.457 ms** | **100.45 ms** | **2000.0000** | **1000.0000** |  **200.0000** |  **11.51 MB** |
|    **Run** |          **2000** |         **TphJson** |  **98.95 ms** | **2.414 ms** |  **7.003 ms** |  **96.54 ms** | **2200.0000** |  **800.0000** |  **200.0000** |  **13.06 MB** |
|    **Run** |          **2000** |             **Tpt** | **156.97 ms** | **3.109 ms** |  **6.491 ms** | **155.27 ms** | **3250.0000** | **1250.0000** |  **250.0000** |   **18.8 MB** |
|    **Run** |          **2200** |             **Tpc** | **113.36 ms** | **2.241 ms** |  **5.538 ms** | **112.15 ms** | **2400.0000** |  **800.0000** |  **200.0000** |  **15.16 MB** |
|    **Run** |          **2200** |             **Tph** | **114.91 ms** | **3.010 ms** |  **8.876 ms** | **111.73 ms** | **2400.0000** | **1000.0000** |  **400.0000** |  **13.62 MB** |
|    **Run** |          **2200** |         **TphJson** | **108.88 ms** | **2.681 ms** |  **7.906 ms** | **106.45 ms** | **2400.0000** | **1000.0000** |  **200.0000** |  **15.32 MB** |
|    **Run** |          **2200** |             **Tpt** | **169.05 ms** | **3.336 ms** |  **7.993 ms** | **166.75 ms** | **3666.6667** | **1333.3333** |  **333.3333** |  **21.57 MB** |
|    **Run** |          **2400** |             **Tpc** | **126.81 ms** | **2.509 ms** |  **6.011 ms** | **124.93 ms** | **2600.0000** | **1000.0000** |  **200.0000** |  **16.35 MB** |
|    **Run** |          **2400** |             **Tph** | **125.16 ms** | **2.963 ms** |  **8.644 ms** | **122.61 ms** | **2250.0000** | **1000.0000** |  **250.0000** |  **14.66 MB** |
|    **Run** |          **2400** |         **TphJson** | **116.50 ms** | **2.319 ms** |  **5.187 ms** | **115.24 ms** | **2750.0000** | **1000.0000** |  **250.0000** |  **16.52 MB** |
|    **Run** |          **2400** |             **Tpt** | **179.65 ms** | **3.557 ms** |  **9.246 ms** | **176.65 ms** | **3666.6667** | **1333.3333** |  **333.3333** |  **23.28 MB** |
|    **Run** |          **2600** |             **Tpc** | **131.15 ms** | **2.601 ms** |  **7.119 ms** | **129.51 ms** | **3000.0000** | **1000.0000** |  **250.0000** |  **17.53 MB** |
|    **Run** |          **2600** |             **Tph** | **128.39 ms** | **3.008 ms** |  **8.776 ms** | **127.45 ms** | **2500.0000** | **1000.0000** |  **250.0000** |   **15.7 MB** |
|    **Run** |          **2600** |         **TphJson** | **125.02 ms** | **2.928 ms** |  **8.632 ms** | **122.09 ms** | **2750.0000** | **1000.0000** |  **250.0000** |  **17.72 MB** |
|    **Run** |          **2600** |             **Tpt** | **191.99 ms** | **3.812 ms** |  **7.957 ms** | **191.09 ms** | **4000.0000** | **1333.3333** |  **333.3333** |  **24.99 MB** |
|    **Run** |          **2800** |             **Tpc** | **140.40 ms** | **2.797 ms** |  **7.797 ms** | **139.08 ms** | **3000.0000** | **1000.0000** |  **250.0000** |  **18.71 MB** |
|    **Run** |          **2800** |             **Tph** | **138.22 ms** | **2.854 ms** |  **8.370 ms** | **137.48 ms** | **2750.0000** | **1000.0000** |  **250.0000** |  **16.75 MB** |
|    **Run** |          **2800** |         **TphJson** | **138.53 ms** | **3.094 ms** |  **8.878 ms** | **136.84 ms** | **3000.0000** | **1000.0000** |  **250.0000** |  **18.92 MB** |
|    **Run** |          **2800** |             **Tpt** | **206.10 ms** | **4.105 ms** |  **8.660 ms** | **204.65 ms** | **4666.6667** | **1666.6667** |  **666.6667** |  **26.71 MB** |
|    **Run** |          **3000** |             **Tpc** | **151.93 ms** | **2.999 ms** |  **6.769 ms** | **151.07 ms** | **3250.0000** | **1000.0000** |  **250.0000** |   **19.9 MB** |
|    **Run** |          **3000** |             **Tph** | **149.99 ms** | **3.239 ms** |  **9.448 ms** | **148.64 ms** | **3000.0000** | **1250.0000** |  **250.0000** |  **17.79 MB** |
|    **Run** |          **3000** |         **TphJson** | **140.86 ms** | **2.815 ms** |  **8.211 ms** | **139.91 ms** | **3250.0000** | **1500.0000** |  **250.0000** |  **20.12 MB** |
|    **Run** |          **3000** |             **Tpt** | **214.17 ms** | **4.283 ms** |  **4.006 ms** | **214.74 ms** | **4666.6667** | **1666.6667** |  **333.3333** |  **28.41 MB** |
|    **Run** |          **3200** |             **Tpc** | **157.89 ms** | **3.131 ms** |  **8.464 ms** | **157.41 ms** | **3666.6667** | **1666.6667** |  **333.3333** |  **21.08 MB** |
|    **Run** |          **3200** |             **Tph** | **156.45 ms** | **3.126 ms** |  **7.183 ms** | **154.75 ms** | **3000.0000** | **1250.0000** |  **250.0000** |  **18.84 MB** |
|    **Run** |          **3200** |         **TphJson** | **138.56 ms** | **2.683 ms** |  **3.847 ms** | **137.55 ms** | **3500.0000** | **1250.0000** |  **250.0000** |  **21.31 MB** |
|    **Run** |          **3200** |             **Tpt** | **222.01 ms** | **4.177 ms** |  **6.745 ms** | **219.06 ms** | **5000.0000** | **1666.6667** |  **333.3333** |  **30.13 MB** |
|    **Run** |          **3400** |             **Tpc** | **164.97 ms** | **3.155 ms** |  **6.585 ms** | **163.34 ms** | **4333.3333** | **1666.6667** |  **666.6667** |  **22.27 MB** |
|    **Run** |          **3400** |             **Tph** | **161.22 ms** | **3.185 ms** |  **7.692 ms** | **159.40 ms** | **3250.0000** | **1250.0000** |  **250.0000** |  **19.88 MB** |
|    **Run** |          **3400** |         **TphJson** | **155.66 ms** | **3.109 ms** |  **7.266 ms** | **154.24 ms** | **4250.0000** | **1750.0000** |  **750.0000** |  **22.52 MB** |
|    **Run** |          **3400** |             **Tpt** | **246.96 ms** | **4.745 ms** |  **5.077 ms** | **247.58 ms** | **5666.6667** | **2000.0000** |  **666.6667** |  **31.83 MB** |
|    **Run** |          **3600** |             **Tpc** | **185.51 ms** | **3.706 ms** |  **7.141 ms** | **182.24 ms** | **4000.0000** | **1666.6667** |  **333.3333** |  **23.45 MB** |
|    **Run** |          **3600** |             **Tph** | **172.20 ms** | **3.418 ms** | **10.023 ms** | **170.73 ms** | **3500.0000** | **1250.0000** |  **250.0000** |  **20.92 MB** |
|    **Run** |          **3600** |         **TphJson** | **167.37 ms** | **3.206 ms** |  **7.864 ms** | **165.36 ms** | **4500.0000** | **1750.0000** |  **750.0000** |  **23.72 MB** |
|    **Run** |          **3600** |             **Tpt** | **249.49 ms** | **4.430 ms** |  **7.153 ms** | **248.73 ms** | **6000.0000** | **2000.0000** |  **500.0000** |  **33.55 MB** |
|    **Run** |          **3800** |             **Tpc** | **192.03 ms** | **3.807 ms** | **11.165 ms** | **193.27 ms** | **4000.0000** | **1666.6667** |  **333.3333** |  **24.64 MB** |
|    **Run** |          **3800** |             **Tph** | **177.85 ms** | **3.553 ms** |  **9.666 ms** | **176.04 ms** | **3666.6667** | **1666.6667** |  **333.3333** |  **21.97 MB** |
|    **Run** |          **3800** |         **TphJson** | **178.35 ms** | **3.554 ms** |  **9.046 ms** | **176.07 ms** | **4666.6667** | **1666.6667** |  **666.6667** |  **24.94 MB** |
|    **Run** |          **3800** |             **Tpt** | **263.79 ms** | **4.456 ms** |  **3.479 ms** | **264.40 ms** | **6000.0000** | **2000.0000** |  **500.0000** |  **35.27 MB** |
|    **Run** |          **4000** |             **Tpc** | **205.17 ms** | **4.083 ms** |  **8.432 ms** | **202.30 ms** | **4333.3333** | **1666.6667** |  **333.3333** |  **25.82 MB** |
|    **Run** |          **4000** |             **Tph** | **185.05 ms** | **3.674 ms** | **10.600 ms** | **182.10 ms** | **3666.6667** | **1333.3333** |  **333.3333** |  **23.02 MB** |
|    **Run** |          **4000** |         **TphJson** | **185.51 ms** | **3.462 ms** |  **7.599 ms** | **182.83 ms** | **4666.6667** | **1666.6667** |  **666.6667** |  **26.13 MB** |
|    **Run** |          **4000** |             **Tpt** | **291.99 ms** | **5.763 ms** | **12.405 ms** | **287.79 ms** | **6000.0000** | **2500.0000** |  **500.0000** |  **36.98 MB** |
|    **Run** |          **4200** |             **Tpc** | **211.61 ms** | **4.026 ms** |  **7.659 ms** | **210.38 ms** | **4666.6667** | **1666.6667** |  **666.6667** |  **27.26 MB** |
|    **Run** |          **4200** |             **Tph** | **201.21 ms** | **4.018 ms** | **11.067 ms** | **199.37 ms** | **4000.0000** | **1666.6667** |  **333.3333** |  **24.31 MB** |
|    **Run** |          **4200** |         **TphJson** | **198.19 ms** | **3.952 ms** | **11.277 ms** | **196.39 ms** | **5000.0000** | **2000.0000** |  **666.6667** |  **27.56 MB** |
|    **Run** |          **4200** |             **Tpt** | **306.80 ms** | **6.083 ms** | **14.338 ms** | **303.37 ms** | **6500.0000** | **2500.0000** |  **500.0000** |  **39.61 MB** |
|    **Run** |          **4400** |             **Tpc** | **220.89 ms** | **4.362 ms** |  **9.936 ms** | **220.37 ms** | **5000.0000** | **2000.0000** |  **666.6667** |  **30.38 MB** |
|    **Run** |          **4400** |             **Tph** | **214.62 ms** | **4.262 ms** | **11.879 ms** | **212.84 ms** | **4666.6667** | **2000.0000** |  **666.6667** |   **27.3 MB** |
|    **Run** |          **4400** |         **TphJson** | **204.81 ms** | **3.917 ms** |  **7.641 ms** | **203.73 ms** | **5000.0000** | **2000.0000** |  **666.6667** |  **30.71 MB** |
|    **Run** |          **4400** |             **Tpt** | **298.75 ms** | **5.652 ms** | **10.335 ms** | **297.54 ms** | **6000.0000** | **2000.0000** |         **-** |  **43.28 MB** |
|    **Run** |          **4600** |             **Tpc** | **233.78 ms** | **4.567 ms** |  **7.999 ms** | **231.46 ms** | **5333.3333** | **2000.0000** |  **666.6667** |  **31.57 MB** |
|    **Run** |          **4600** |             **Tph** | **224.12 ms** | **4.477 ms** | **12.773 ms** | **221.93 ms** | **4666.6667** | **2000.0000** |  **666.6667** |  **28.33 MB** |
|    **Run** |          **4600** |         **TphJson** | **221.27 ms** | **4.418 ms** | **10.754 ms** | **217.20 ms** | **5333.3333** | **2000.0000** |  **666.6667** |  **31.92 MB** |
|    **Run** |          **4600** |             **Tpt** | **317.88 ms** | **6.351 ms** | **12.829 ms** | **315.61 ms** | **7000.0000** | **3000.0000** |         **-** |  **44.99 MB** |
|    **Run** |          **4800** |             **Tpc** | **242.80 ms** | **4.795 ms** |  **8.889 ms** | **241.00 ms** | **5000.0000** | **2000.0000** |  **500.0000** |  **32.76 MB** |
|    **Run** |          **4800** |             **Tph** | **232.18 ms** | **4.926 ms** | **14.524 ms** | **230.40 ms** | **4500.0000** | **2000.0000** |  **500.0000** |  **29.39 MB** |
|    **Run** |          **4800** |         **TphJson** | **223.15 ms** | **4.454 ms** | **12.118 ms** | **220.01 ms** | **5666.6667** | **2000.0000** |  **666.6667** |  **33.11 MB** |
|    **Run** |          **4800** |             **Tpt** | **348.14 ms** | **6.897 ms** | **11.524 ms** | **344.31 ms** | **7500.0000** | **2500.0000** |  **500.0000** |  **46.68 MB** |
|    **Run** |          **5000** |             **Tpc** | **257.04 ms** | **5.131 ms** | **10.935 ms** | **256.89 ms** | **6000.0000** | **2333.3333** | **1000.0000** |  **33.93 MB** |
|    **Run** |          **5000** |             **Tph** | **240.31 ms** | **4.783 ms** | **13.491 ms** | **238.81 ms** | **4500.0000** | **2000.0000** |  **500.0000** |  **30.44 MB** |
|    **Run** |          **5000** |         **TphJson** | **225.39 ms** | **4.473 ms** | **12.320 ms** | **220.76 ms** | **5500.0000** | **2000.0000** |  **500.0000** |  **34.31 MB** |
|    **Run** |          **5000** |             **Tpt** | **332.10 ms** | **6.335 ms** | **10.048 ms** | **329.46 ms** | **8000.0000** | **3000.0000** | **1000.0000** |  **48.42 MB** |
