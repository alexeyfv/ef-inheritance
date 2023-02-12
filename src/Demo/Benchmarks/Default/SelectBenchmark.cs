using BenchmarkDotNet.Attributes;
using Demo.Contexts.Default;
using Demo.Models.Default;

namespace Demo.Benchmarks.Default;

[MemoryDiagnoser]
public class SelectBenchmark : BenchmarkBase
{
    [Params(200, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000, 2200, 2400, 2600, 2800, 3000, 3200, 3400, 3600, 3800, 4000, 4200, 4400, 4600, 4800, 5000)]
    public override int EntitiesCount { get; set; }

    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies))]
    public void Run(string mappingStrategy)
    {
        var contextType = ContextMap[mappingStrategy];
        var ctx = Activator.CreateInstance(contextType) as BasicContext;
        if (ctx == null) return;
        ctx.GetAllData();
        ctx.Dispose();
    }

    [GlobalSetup]
    public void GlobalSetup()
    {
        // Delete old data
        DeleteTestData();

        // Create new data
        var data = new List<Root>();
        data.AddRange(Faker.RootFaker.Generate(EntitiesCount));
        data.AddRange(Faker.ChildAFaker.Generate(EntitiesCount));
        data.AddRange(Faker.ChildBFaker.Generate(EntitiesCount));
        data.AddRange(Faker.ChildCFaker.Generate(EntitiesCount));

        // Set new data
        foreach (var ctxType in ContextMap.Values)
        {
            using var ctx = Activator.CreateInstance(ctxType) as BasicContext;
            if (ctx == null) return;
            ctx.AddData(data.Select(d =>
            {
                d.Id = 0;
                return d;
            }));
            ctx.SaveChanges();
        }
    }
}