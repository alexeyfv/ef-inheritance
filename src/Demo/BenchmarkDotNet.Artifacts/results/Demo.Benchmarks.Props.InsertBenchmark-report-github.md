``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 11 (10.0.22621.1105)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  Job-YDHENV : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

```
| Method | EntitiesCount | mappingStrategy |        Mean |     Error |    StdDev |      Median |        Gen0 |       Gen1 |      Gen2 | Allocated |
|------- |-------------- |---------------- |------------:|----------:|----------:|------------:|------------:|-----------:|----------:|----------:|
|  **Run03** |           **200** |           **Tph03** |    **175.5 ms** |   **3.49 ms** |   **8.44 ms** |    **173.1 ms** |   **1000.0000** |          **-** |         **-** |  **10.09 MB** |
|  **Run05** |           **200** |           **Tph05** |    **202.8 ms** |   **4.26 ms** |  **12.49 ms** |    **200.5 ms** |   **1000.0000** |          **-** |         **-** |   **10.9 MB** |
|  **Run08** |           **200** |           **Tph08** |    **246.2 ms** |   **4.92 ms** |  **13.56 ms** |    **244.4 ms** |   **2000.0000** |  **1000.0000** |         **-** |  **12.84 MB** |
|  **Run13** |           **200** |           **Tph13** |    **348.4 ms** |   **6.89 ms** |  **18.97 ms** |    **346.3 ms** |   **2000.0000** |  **1000.0000** |         **-** |  **14.91 MB** |
|  **Run21** |           **200** |           **Tph21** |    **546.1 ms** |  **10.79 ms** |  **23.45 ms** |    **541.3 ms** |   **3000.0000** |  **1000.0000** |         **-** |  **19.36 MB** |
|  **Run03** |           **200** |       **TphJson03** |    **157.0 ms** |   **3.32 ms** |   **9.78 ms** |    **156.8 ms** |   **2000.0000** |  **1000.0000** |         **-** |   **8.65 MB** |
|  **Run05** |           **200** |       **TphJson05** |    **156.1 ms** |   **3.27 ms** |   **9.64 ms** |    **156.0 ms** |   **1000.0000** |          **-** |         **-** |    **8.7 MB** |
|  **Run08** |           **200** |       **TphJson08** |    **157.8 ms** |   **3.29 ms** |   **9.69 ms** |    **155.6 ms** |   **2000.0000** |  **1000.0000** |         **-** |   **8.78 MB** |
|  **Run13** |           **200** |       **TphJson13** |    **162.0 ms** |   **3.21 ms** |   **6.55 ms** |    **162.7 ms** |   **1000.0000** |  **1000.0000** |         **-** |   **8.92 MB** |
|  **Run21** |           **200** |       **TphJson21** |    **172.5 ms** |   **3.43 ms** |   **9.72 ms** |    **170.4 ms** |   **1000.0000** |  **1000.0000** |         **-** |   **9.15 MB** |
|  **Run03** |           **500** |           **Tph03** |    **402.7 ms** |   **8.01 ms** |  **17.41 ms** |    **399.9 ms** |   **4000.0000** |  **2000.0000** |         **-** |  **25.42 MB** |
|  **Run05** |           **500** |           **Tph05** |    **465.8 ms** |   **9.27 ms** |  **17.86 ms** |    **461.7 ms** |   **4000.0000** |  **2000.0000** |         **-** |  **27.38 MB** |
|  **Run08** |           **500** |           **Tph08** |    **585.6 ms** |  **11.67 ms** |  **25.38 ms** |    **574.5 ms** |   **5000.0000** |  **2000.0000** |         **-** |  **32.27 MB** |
|  **Run13** |           **500** |           **Tph13** |    **840.7 ms** |  **16.77 ms** |  **30.67 ms** |    **840.7 ms** |   **6000.0000** |  **2000.0000** |         **-** |  **37.47 MB** |
|  **Run21** |           **500** |           **Tph21** |  **1,358.7 ms** |  **26.84 ms** |  **37.63 ms** |  **1,351.9 ms** |   **8000.0000** |  **3000.0000** |         **-** |  **48.51 MB** |
|  **Run03** |           **500** |       **TphJson03** |    **353.2 ms** |   **7.04 ms** |  **18.16 ms** |    **351.3 ms** |   **4000.0000** |  **2000.0000** |         **-** |  **21.81 MB** |
|  **Run05** |           **500** |       **TphJson05** |    **357.6 ms** |   **7.12 ms** |  **20.07 ms** |    **355.9 ms** |   **3000.0000** |  **2000.0000** |         **-** |  **21.95 MB** |
|  **Run08** |           **500** |       **TphJson08** |    **353.1 ms** |   **7.02 ms** |  **18.50 ms** |    **348.3 ms** |   **3000.0000** |  **2000.0000** |         **-** |  **22.15 MB** |
|  **Run13** |           **500** |       **TphJson13** |    **379.1 ms** |   **7.06 ms** |  **18.73 ms** |    **373.4 ms** |   **3000.0000** |  **2000.0000** |         **-** |  **22.51 MB** |
|  **Run21** |           **500** |       **TphJson21** |    **408.4 ms** |   **8.15 ms** |  **22.87 ms** |    **400.6 ms** |   **3000.0000** |  **2000.0000** |         **-** |  **23.08 MB** |
|  **Run03** |          **1000** |           **Tph03** |    **773.0 ms** |  **15.43 ms** |  **25.35 ms** |    **771.9 ms** |   **8000.0000** |  **3000.0000** |         **-** |  **49.82 MB** |
|  **Run05** |          **1000** |           **Tph05** |    **905.8 ms** |  **16.89 ms** |  **28.22 ms** |    **908.9 ms** |   **9000.0000** |  **3000.0000** |         **-** |  **53.72 MB** |
|  **Run08** |          **1000** |           **Tph08** |  **1,130.1 ms** |  **22.58 ms** |  **30.14 ms** |  **1,119.6 ms** |  **10000.0000** |  **3000.0000** |         **-** |  **63.51 MB** |
|  **Run13** |          **1000** |           **Tph13** |  **1,613.9 ms** |  **30.95 ms** |  **28.95 ms** |  **1,612.6 ms** |  **12000.0000** |  **3000.0000** |         **-** |  **73.87 MB** |
|  **Run21** |          **1000** |           **Tph21** |  **2,586.2 ms** |  **45.23 ms** |  **40.10 ms** |  **2,584.0 ms** |  **16000.0000** |  **3000.0000** |         **-** |  **96.08 MB** |
|  **Run03** |          **1000** |       **TphJson03** |    **666.5 ms** |  **13.23 ms** |  **32.46 ms** |    **654.6 ms** |   **7000.0000** |  **2000.0000** |         **-** |   **42.6 MB** |
|  **Run05** |          **1000** |       **TphJson05** |    **678.8 ms** |  **13.55 ms** |  **36.15 ms** |    **670.1 ms** |   **7000.0000** |  **2000.0000** |         **-** |  **42.87 MB** |
|  **Run08** |          **1000** |       **TphJson08** |    **697.1 ms** |  **13.84 ms** |  **32.35 ms** |    **695.0 ms** |   **7000.0000** |  **2000.0000** |         **-** |  **43.28 MB** |
|  **Run13** |          **1000** |       **TphJson13** |    **744.5 ms** |  **14.81 ms** |  **33.43 ms** |    **740.3 ms** |   **7000.0000** |  **2000.0000** |         **-** |  **43.99 MB** |
|  **Run21** |          **1000** |       **TphJson21** |    **805.4 ms** |  **16.02 ms** |  **31.25 ms** |    **788.5 ms** |   **7000.0000** |  **2000.0000** |         **-** |  **45.15 MB** |
|  **Run03** |          **1500** |           **Tph03** |  **1,149.9 ms** |  **13.07 ms** |  **10.92 ms** |  **1,153.4 ms** |  **13000.0000** |  **4000.0000** |         **-** |  **75.27 MB** |
|  **Run05** |          **1500** |           **Tph05** |  **1,346.9 ms** |  **26.07 ms** |  **35.69 ms** |  **1,340.8 ms** |  **14000.0000** |  **3000.0000** |         **-** |  **81.11 MB** |
|  **Run08** |          **1500** |           **Tph08** |  **1,686.2 ms** |  **33.49 ms** |  **44.71 ms** |  **1,673.8 ms** |  **18000.0000** |  **6000.0000** | **1000.0000** |  **95.86 MB** |
|  **Run13** |          **1500** |           **Tph13** |  **2,456.4 ms** |  **39.66 ms** |  **37.10 ms** |  **2,458.5 ms** |  **21000.0000** |  **7000.0000** | **1000.0000** | **111.36 MB** |
|  **Run21** |          **1500** |           **Tph21** |  **3,914.1 ms** |  **52.32 ms** |  **48.94 ms** |  **3,916.5 ms** |  **28000.0000** |  **8000.0000** | **1000.0000** | **144.68 MB** |
|  **Run03** |          **1500** |       **TphJson03** |  **1,018.5 ms** |  **20.17 ms** |  **43.84 ms** |  **1,016.8 ms** |  **10000.0000** |  **4000.0000** |         **-** |   **64.5 MB** |
|  **Run05** |          **1500** |       **TphJson05** |  **1,044.6 ms** |  **20.78 ms** |  **44.28 ms** |  **1,037.3 ms** |  **11000.0000** |  **4000.0000** |         **-** |  **64.91 MB** |
|  **Run08** |          **1500** |       **TphJson08** |  **1,049.8 ms** |  **20.90 ms** |  **43.16 ms** |  **1,045.1 ms** |  **11000.0000** |  **4000.0000** |         **-** |  **65.51 MB** |
|  **Run13** |          **1500** |       **TphJson13** |  **1,125.2 ms** |  **22.47 ms** |  **55.12 ms** |  **1,113.3 ms** |  **11000.0000** |  **4000.0000** |         **-** |  **66.58 MB** |
|  **Run21** |          **1500** |       **TphJson21** |  **1,239.8 ms** |  **24.54 ms** |  **52.83 ms** |  **1,228.9 ms** |  **12000.0000** |  **5000.0000** | **1000.0000** |   **68.3 MB** |
|  **Run03** |          **2000** |           **Tph03** |  **1,530.4 ms** |  **23.36 ms** |  **26.90 ms** |  **1,530.8 ms** |  **18000.0000** |  **6000.0000** | **1000.0000** |  **99.58 MB** |
|  **Run05** |          **2000** |           **Tph05** |  **1,777.5 ms** |  **33.81 ms** |  **34.72 ms** |  **1,769.5 ms** |  **20000.0000** |  **6000.0000** | **1000.0000** | **107.35 MB** |
|  **Run08** |          **2000** |           **Tph08** |  **2,322.9 ms** |  **45.31 ms** |  **82.85 ms** |  **2,295.1 ms** |  **24000.0000** |  **6000.0000** | **1000.0000** | **127.01 MB** |
|  **Run13** |          **2000** |           **Tph13** |  **3,326.9 ms** |  **65.07 ms** |  **79.91 ms** |  **3,308.3 ms** |  **28000.0000** |  **7000.0000** | **1000.0000** | **147.67 MB** |
|  **Run21** |          **2000** |           **Tph21** |  **5,242.5 ms** |  **73.94 ms** |  **61.74 ms** |  **5,231.1 ms** |  **37000.0000** |  **9000.0000** | **1000.0000** |  **192.1 MB** |
|  **Run03** |          **2000** |       **TphJson03** |  **1,342.8 ms** |  **26.40 ms** |  **41.87 ms** |  **1,342.0 ms** |  **14000.0000** |  **5000.0000** |         **-** |  **85.19 MB** |
|  **Run05** |          **2000** |       **TphJson05** |  **1,421.3 ms** |  **28.11 ms** |  **58.05 ms** |  **1,412.7 ms** |  **15000.0000** |  **5000.0000** | **1000.0000** |  **85.74 MB** |
|  **Run08** |          **2000** |       **TphJson08** |  **1,428.0 ms** |  **28.53 ms** |  **54.97 ms** |  **1,424.3 ms** |  **15000.0000** |  **4000.0000** | **1000.0000** |  **86.55 MB** |
|  **Run13** |          **2000** |       **TphJson13** |  **1,509.0 ms** |  **28.18 ms** |  **24.98 ms** |  **1,504.4 ms** |  **16000.0000** |  **5000.0000** | **1000.0000** |  **87.97 MB** |
|  **Run21** |          **2000** |       **TphJson21** |  **1,636.9 ms** |  **32.56 ms** |  **69.39 ms** |  **1,646.2 ms** |  **15000.0000** |  **5000.0000** | **1000.0000** |  **90.25 MB** |
|  **Run03** |          **2500** |           **Tph03** |  **1,961.5 ms** |  **36.63 ms** |  **35.98 ms** |  **1,954.7 ms** |  **25000.0000** |  **8000.0000** | **1000.0000** | **126.32 MB** |
|  **Run05** |          **2500** |           **Tph05** |  **2,278.2 ms** |  **45.02 ms** |  **68.74 ms** |  **2,275.5 ms** |  **25000.0000** |  **6000.0000** |         **-** | **136.04 MB** |
|  **Run08** |          **2500** |           **Tph08** |  **2,873.8 ms** |  **55.43 ms** |  **59.31 ms** |  **2,863.6 ms** |  **31000.0000** |  **8000.0000** | **1000.0000** | **160.59 MB** |
|  **Run13** |          **2500** |           **Tph13** |  **4,156.7 ms** |  **66.05 ms** |  **61.78 ms** |  **4,148.8 ms** |  **36000.0000** |  **9000.0000** | **1000.0000** | **186.46 MB** |
|  **Run21** |          **2500** |           **Tph21** |  **6,547.5 ms** | **123.69 ms** | **115.70 ms** |  **6,542.5 ms** |  **47000.0000** | **11000.0000** | **1000.0000** | **241.96 MB** |
|  **Run03** |          **2500** |       **TphJson03** |  **1,697.4 ms** |  **33.09 ms** |  **60.50 ms** |  **1,690.5 ms** |  **18000.0000** |  **5000.0000** |         **-** | **108.33 MB** |
|  **Run05** |          **2500** |       **TphJson05** |  **1,735.9 ms** |  **34.32 ms** |  **66.93 ms** |  **1,720.9 ms** |  **21000.0000** |  **5000.0000** | **1000.0000** | **109.02 MB** |
|  **Run08** |          **2500** |       **TphJson08** |  **1,763.8 ms** |  **34.64 ms** |  **65.92 ms** |  **1,753.4 ms** |  **18000.0000** |  **6000.0000** | **1000.0000** | **110.03 MB** |
|  **Run13** |          **2500** |       **TphJson13** |  **1,904.3 ms** |  **38.06 ms** |  **71.49 ms** |  **1,900.9 ms** |  **19000.0000** |  **7000.0000** | **1000.0000** | **111.81 MB** |
|  **Run21** |          **2500** |       **TphJson21** |  **1,984.6 ms** |  **39.39 ms** |  **72.03 ms** |  **1,972.4 ms** |  **20000.0000** |  **6000.0000** | **1000.0000** | **114.65 MB** |
|  **Run03** |          **3000** |           **Tph03** |  **2,365.3 ms** |  **46.65 ms** |  **72.63 ms** |  **2,351.2 ms** |  **30000.0000** |  **8000.0000** | **1000.0000** |  **150.6 MB** |
|  **Run05** |          **3000** |           **Tph05** |  **2,723.8 ms** |  **53.74 ms** |  **61.89 ms** |  **2,727.7 ms** |  **32000.0000** |  **9000.0000** | **1000.0000** | **162.27 MB** |
|  **Run08** |          **3000** |           **Tph08** |  **3,486.8 ms** |  **68.36 ms** |  **81.38 ms** |  **3,458.1 ms** |  **39000.0000** |  **9000.0000** | **1000.0000** | **191.75 MB** |
|  **Run13** |          **3000** |           **Tph13** |  **4,957.3 ms** |  **68.12 ms** |  **63.72 ms** |  **4,963.3 ms** |  **44000.0000** | **11000.0000** | **1000.0000** | **222.74 MB** |
|  **Run21** |          **3000** |           **Tph21** |  **7,867.6 ms** |  **67.71 ms** |  **60.02 ms** |  **7,874.8 ms** |  **58000.0000** | **14000.0000** | **1000.0000** | **289.41 MB** |
|  **Run03** |          **3000** |       **TphJson03** |  **2,026.8 ms** |  **39.61 ms** |  **67.25 ms** |  **2,020.5 ms** |  **24000.0000** |  **8000.0000** | **1000.0000** | **129.02 MB** |
|  **Run05** |          **3000** |       **TphJson05** |  **2,075.7 ms** |  **41.30 ms** |  **69.01 ms** |  **2,079.6 ms** |  **24000.0000** |  **7000.0000** | **1000.0000** | **129.84 MB** |
|  **Run08** |          **3000** |       **TphJson08** |  **2,152.3 ms** |  **42.90 ms** |  **79.52 ms** |  **2,154.5 ms** |  **25000.0000** |  **7000.0000** | **1000.0000** | **131.05 MB** |
|  **Run13** |          **3000** |       **TphJson13** |  **2,250.5 ms** |  **44.69 ms** |  **74.67 ms** |  **2,244.0 ms** |  **25000.0000** |  **7000.0000** | **1000.0000** | **133.19 MB** |
|  **Run21** |          **3000** |       **TphJson21** |  **2,407.3 ms** |  **46.49 ms** |  **83.83 ms** |  **2,402.6 ms** |  **25000.0000** |  **8000.0000** | **1000.0000** |  **136.6 MB** |
|  **Run03** |          **3500** |           **Tph03** |  **2,856.2 ms** |  **54.26 ms** | **128.95 ms** |  **2,883.9 ms** |  **36000.0000** |  **9000.0000** | **1000.0000** | **174.89 MB** |
|  **Run05** |          **3500** |           **Tph05** |  **3,194.6 ms** |  **25.08 ms** |  **22.23 ms** |  **3,191.1 ms** |  **37000.0000** |  **9000.0000** | **1000.0000** | **188.48 MB** |
|  **Run08** |          **3500** |           **Tph08** |  **3,986.9 ms** |  **50.14 ms** |  **41.87 ms** |  **3,995.7 ms** |  **45000.0000** | **10000.0000** | **1000.0000** | **222.91 MB** |
|  **Run13** |          **3500** |           **Tph13** |  **5,823.4 ms** |  **76.87 ms** |  **68.14 ms** |  **5,826.7 ms** |  **53000.0000** | **12000.0000** | **1000.0000** | **259.04 MB** |
|  **Run21** |          **3500** |           **Tph21** |  **9,121.2 ms** |  **70.54 ms** |  **62.53 ms** |  **9,138.0 ms** |  **69000.0000** | **15000.0000** | **2000.0000** | **336.82 MB** |
|  **Run03** |          **3500** |       **TphJson03** |  **2,390.3 ms** |  **46.66 ms** |  **63.87 ms** |  **2,377.8 ms** |  **29000.0000** |  **8000.0000** | **1000.0000** | **149.72 MB** |
|  **Run05** |          **3500** |       **TphJson05** |  **2,414.2 ms** |  **45.98 ms** |  **67.40 ms** |  **2,411.0 ms** |  **30000.0000** |  **8000.0000** | **1000.0000** | **150.67 MB** |
|  **Run08** |          **3500** |       **TphJson08** |  **2,477.8 ms** |  **48.43 ms** |  **67.90 ms** |  **2,482.0 ms** |  **29000.0000** |  **8000.0000** | **1000.0000** | **152.09 MB** |
|  **Run13** |          **3500** |       **TphJson13** |  **2,610.4 ms** |  **52.09 ms** |  **77.96 ms** |  **2,589.3 ms** |  **30000.0000** |  **8000.0000** | **1000.0000** | **154.58 MB** |
|  **Run21** |          **3500** |       **TphJson21** |  **2,812.7 ms** |  **56.03 ms** |  **87.23 ms** |  **2,829.4 ms** |  **30000.0000** |  **9000.0000** | **1000.0000** | **158.56 MB** |
|  **Run03** |          **4000** |           **Tph03** |  **3,148.6 ms** |  **18.11 ms** |  **15.12 ms** |  **3,146.3 ms** |  **43000.0000** | **10000.0000** | **1000.0000** | **199.18 MB** |
|  **Run05** |          **4000** |           **Tph05** |  **3,673.3 ms** |  **70.77 ms** |  **72.67 ms** |  **3,668.5 ms** |  **45000.0000** | **12000.0000** | **1000.0000** | **214.73 MB** |
|  **Run08** |          **4000** |           **Tph08** |  **4,821.8 ms** |  **80.73 ms** |  **75.52 ms** |  **4,827.8 ms** |  **53000.0000** | **14000.0000** | **2000.0000** | **254.04 MB** |
|  **Run13** |          **4000** |           **Tph13** |  **6,775.1 ms** | **135.10 ms** | **189.39 ms** |  **6,772.2 ms** |  **61000.0000** | **14000.0000** | **2000.0000** |  **295.4 MB** |
|  **Run21** |          **4000** |           **Tph21** | **10,497.6 ms** |  **94.84 ms** |  **79.20 ms** | **10,491.2 ms** |  **78000.0000** | **18000.0000** | **2000.0000** |  **384.2 MB** |
|  **Run03** |          **4000** |       **TphJson03** |  **2,729.5 ms** |  **52.99 ms** |  **77.67 ms** |  **2,724.5 ms** |  **32000.0000** |  **9000.0000** | **1000.0000** | **170.41 MB** |
|  **Run05** |          **4000** |       **TphJson05** |  **2,759.7 ms** |  **51.89 ms** |  **55.52 ms** |  **2,760.4 ms** |  **34000.0000** |  **9000.0000** | **1000.0000** | **171.51 MB** |
|  **Run08** |          **4000** |       **TphJson08** |  **2,807.5 ms** |  **55.43 ms** |  **65.99 ms** |  **2,805.4 ms** |  **35000.0000** |  **9000.0000** | **2000.0000** | **173.12 MB** |
|  **Run13** |          **4000** |       **TphJson13** |  **2,986.5 ms** |  **59.18 ms** |  **95.57 ms** |  **2,973.3 ms** |  **34000.0000** |  **9000.0000** | **1000.0000** | **175.97 MB** |
|  **Run21** |          **4000** |       **TphJson21** |  **3,172.9 ms** |  **62.84 ms** |  **81.72 ms** |  **3,164.9 ms** |  **33000.0000** | **11000.0000** | **1000.0000** | **180.52 MB** |
|  **Run03** |          **4500** |           **Tph03** |  **3,533.1 ms** |  **65.44 ms** |  **64.27 ms** |  **3,540.8 ms** |  **48000.0000** | **11000.0000** | **1000.0000** | **228.53 MB** |
|  **Run05** |          **4500** |           **Tph05** |  **4,097.7 ms** |  **64.81 ms** |  **66.55 ms** |  **4,088.0 ms** |  **52000.0000** | **11000.0000** | **1000.0000** | **246.02 MB** |
|  **Run08** |          **4500** |           **Tph08** |  **5,176.0 ms** |  **39.77 ms** |  **35.26 ms** |  **5,179.8 ms** |  **61000.0000** | **15000.0000** | **2000.0000** | **290.24 MB** |
|  **Run13** |          **4500** |           **Tph13** |  **7,470.1 ms** |  **79.30 ms** |  **70.30 ms** |  **7,481.6 ms** |  **70000.0000** | **15000.0000** | **2000.0000** | **336.73 MB** |
|  **Run21** |          **4500** |           **Tph21** | **11,815.9 ms** | **142.80 ms** | **126.59 ms** | **11,794.0 ms** |  **88000.0000** | **19000.0000** | **1000.0000** | **436.72 MB** |
|  **Run03** |          **4500** |       **TphJson03** |  **3,192.7 ms** |  **59.92 ms** |  **61.53 ms** |  **3,206.6 ms** |  **39000.0000** |  **9000.0000** | **1000.0000** | **196.16 MB** |
|  **Run05** |          **4500** |       **TphJson05** |  **3,215.8 ms** |  **63.21 ms** |  **62.08 ms** |  **3,219.4 ms** |  **37000.0000** | **10000.0000** | **1000.0000** | **197.39 MB** |
|  **Run08** |          **4500** |       **TphJson08** |  **3,260.1 ms** |  **62.42 ms** |  **74.30 ms** |  **3,259.7 ms** |  **38000.0000** | **10000.0000** | **1000.0000** |  **199.2 MB** |
|  **Run13** |          **4500** |       **TphJson13** |  **3,481.6 ms** |  **67.53 ms** |  **69.35 ms** |  **3,481.8 ms** |  **40000.0000** | **10000.0000** | **1000.0000** | **202.41 MB** |
|  **Run21** |          **4500** |       **TphJson21** |  **3,737.6 ms** |  **74.62 ms** | **104.61 ms** |  **3,726.0 ms** |  **41000.0000** | **11000.0000** | **1000.0000** | **207.53 MB** |
|  **Run03** |          **5000** |           **Tph03** |  **4,076.6 ms** |  **79.78 ms** |  **74.63 ms** |  **4,061.7 ms** |  **53000.0000** | **11000.0000** | **1000.0000** | **252.82 MB** |
|  **Run05** |          **5000** |           **Tph05** |  **4,767.2 ms** |  **89.55 ms** |  **83.77 ms** |  **4,739.7 ms** |  **58000.0000** | **15000.0000** | **2000.0000** | **272.24 MB** |
|  **Run08** |          **5000** |           **Tph08** |  **6,007.5 ms** | **103.64 ms** |  **96.94 ms** |  **6,023.6 ms** |  **66000.0000** | **15000.0000** | **2000.0000** | **321.41 MB** |
|  **Run13** |          **5000** |           **Tph13** |  **8,760.8 ms** |  **98.26 ms** |  **87.11 ms** |  **8,766.3 ms** |  **78000.0000** | **18000.0000** | **2000.0000** | **373.06 MB** |
|  **Run21** |          **5000** |           **Tph21** | **13,092.0 ms** |  **98.18 ms** |  **76.65 ms** | **13,123.8 ms** | **100000.0000** | **20000.0000** | **2000.0000** | **484.16 MB** |
|  **Run03** |          **5000** |       **TphJson03** |  **3,584.8 ms** |  **69.62 ms** |  **77.39 ms** |  **3,606.5 ms** |  **44000.0000** |  **9000.0000** | **1000.0000** | **216.85 MB** |
|  **Run05** |          **5000** |       **TphJson05** |  **3,594.6 ms** |  **69.21 ms** |  **71.07 ms** |  **3,571.5 ms** |  **45000.0000** | **11000.0000** | **2000.0000** | **218.22 MB** |
|  **Run08** |          **5000** |       **TphJson08** |  **3,659.7 ms** |  **67.11 ms** |  **59.49 ms** |  **3,651.2 ms** |  **44000.0000** | **12000.0000** | **2000.0000** | **220.24 MB** |
|  **Run13** |          **5000** |       **TphJson13** |  **3,870.1 ms** |  **74.32 ms** |  **76.33 ms** |  **3,889.0 ms** |  **44000.0000** | **12000.0000** | **1000.0000** |  **223.8 MB** |
|  **Run21** |          **5000** |       **TphJson21** |  **4,187.1 ms** |  **82.41 ms** | **101.21 ms** |  **4,185.9 ms** |  **46000.0000** | **14000.0000** | **2000.0000** | **229.48 MB** |