using BenchmarkDotNet.Attributes;

namespace Demo.Benchmarks.Props;

[MemoryDiagnoser]
public class InsertBenchmark : BenchmarkBase
{
    public List<Models.Props03.Root> data03 = new List<Models.Props03.Root>();
    public List<Models.Props05.Root> data05 = new List<Models.Props05.Root>();
    public List<Models.Props08.Root> data08 = new List<Models.Props08.Root>();
    public List<Models.Props13.Root> data13 = new List<Models.Props13.Root>();
    public List<Models.Props21.Root> data21 = new List<Models.Props21.Root>();
    
    [Params(200, 500, 1000, 1500, 2000, 2500, 3000, 3500, 4000, 4500, 5000)]
    public override int EntitiesCount { get; set; }

    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies03))]
    public void Run03(string mappingStrategy)
    {
        var contextType = ContextMap03[mappingStrategy];
        using var ctx = Activator.CreateInstance(contextType) as Contexts.Props03.BasicContext;
        if (ctx == null) return;
        ctx.AddData(data03);
        ctx.SaveChanges();
    }

    [IterationSetup(Target = nameof(Run03))]
    public void IterationSetup03()
    {
        // Delete old data
        DeleteTestData03();

        // Create new data
        data03 = new List<Models.Props03.Root>();
        data03.AddRange(Faker03.RootFaker.Generate(EntitiesCount));
        data03.AddRange(Faker03.ChildAFaker.Generate(EntitiesCount));
        data03.AddRange(Faker03.ChildBFaker.Generate(EntitiesCount));
        data03.AddRange(Faker03.ChildCFaker.Generate(EntitiesCount));
    }

    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies05))]
    public void Run05(string mappingStrategy)
    {
        var contextType = ContextMap05[mappingStrategy];
        using var ctx = Activator.CreateInstance(contextType) as Contexts.Props05.BasicContext;
        if (ctx == null) return;
        ctx.AddData(data05);
        ctx.SaveChanges();
    }

    [IterationSetup(Target = nameof(Run05))]
    public void IterationSetup05()
    {
        // Delete old data
        DeleteTestData05();

        // Create new data
        data05 = new List<Models.Props05.Root>();
        data05.AddRange(Faker05.RootFaker.Generate(EntitiesCount));
        data05.AddRange(Faker05.ChildAFaker.Generate(EntitiesCount));
        data05.AddRange(Faker05.ChildBFaker.Generate(EntitiesCount));
        data05.AddRange(Faker05.ChildCFaker.Generate(EntitiesCount));
    }
    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies08))]
    public void Run08(string mappingStrategy)
    {
        var contextType = ContextMap08[mappingStrategy];
        using var ctx = Activator.CreateInstance(contextType) as Contexts.Props08.BasicContext;
        if (ctx == null) return;
        ctx.AddData(data08);
        ctx.SaveChanges();
    }

    [IterationSetup(Target = nameof(Run08))]
    public void IterationSetup08()
    {
        // Delete old data
        DeleteTestData08();

        // Create new data
        data08 = new List<Models.Props08.Root>();
        data08.AddRange(Faker08.RootFaker.Generate(EntitiesCount));
        data08.AddRange(Faker08.ChildAFaker.Generate(EntitiesCount));
        data08.AddRange(Faker08.ChildBFaker.Generate(EntitiesCount));
        data08.AddRange(Faker08.ChildCFaker.Generate(EntitiesCount));
    }
    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies13))]
    public void Run13(string mappingStrategy)
    {
        var contextType = ContextMap13[mappingStrategy];
        using var ctx = Activator.CreateInstance(contextType) as Contexts.Props13.BasicContext;
        if (ctx == null) return;
        ctx.AddData(data13);
        ctx.SaveChanges();
    }

    [IterationSetup(Target = nameof(Run13))]
    public void IterationSetup13()
    {
        // Delete old data
        DeleteTestData13();

        // Create new data
        data13 = new List<Models.Props13.Root>();
        data13.AddRange(Faker13.RootFaker.Generate(EntitiesCount));
        data13.AddRange(Faker13.ChildAFaker.Generate(EntitiesCount));
        data13.AddRange(Faker13.ChildBFaker.Generate(EntitiesCount));
        data13.AddRange(Faker13.ChildCFaker.Generate(EntitiesCount));
    }
    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies21))]
    public void Run21(string mappingStrategy)
    {
        var contextType = ContextMap21[mappingStrategy];
        using var ctx = Activator.CreateInstance(contextType) as Contexts.Props21.BasicContext;
        if (ctx == null) return;
        ctx.AddData(data21);
        ctx.SaveChanges();
    }

    [IterationSetup(Target = nameof(Run21))]
    public void IterationSetup21()
    {
        // Delete old data
        DeleteTestData21();

        // Create new data
        data21 = new List<Models.Props21.Root>();
        data21.AddRange(Faker21.RootFaker.Generate(EntitiesCount));
        data21.AddRange(Faker21.ChildAFaker.Generate(EntitiesCount));
        data21.AddRange(Faker21.ChildBFaker.Generate(EntitiesCount));
        data21.AddRange(Faker21.ChildCFaker.Generate(EntitiesCount));
    }
}