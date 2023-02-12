using BenchmarkDotNet.Attributes;

namespace Demo.Benchmarks.Props;

[MemoryDiagnoser]
public class SelectBenchmark : BenchmarkBase
{
    [Params(200, 500, 1000, 1500, 2000, 2500, 3000, 3500, 4000, 4500, 5000)]
    public override int EntitiesCount { get; set; }

    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies03))]
    public void Run03(string mappingStrategy)
    {
        var contextType = ContextMap03[mappingStrategy];
        var ctx = Activator.CreateInstance(contextType) as Contexts.Props03.BasicContext;
        if (ctx == null) return;
        ctx.GetAllData();
        ctx.Dispose();
    }

    [GlobalSetup(Target = nameof(Run03))]
    public void GlobalSetup03()
    {
        // Delete old data
        DeleteTestData03();

        // Create new data
        var data = new List<Models.Props03.Root>();
        data.AddRange(Faker03.RootFaker.Generate(EntitiesCount));
        data.AddRange(Faker03.ChildAFaker.Generate(EntitiesCount));
        data.AddRange(Faker03.ChildBFaker.Generate(EntitiesCount));
        data.AddRange(Faker03.ChildCFaker.Generate(EntitiesCount));

        // Set new data
        foreach (var ctxType in ContextMap03.Values)
        {
            using var ctx = Activator.CreateInstance(ctxType) as Contexts.Props03.BasicContext;
            if (ctx == null) return;
            ctx.AddData(data.Select(d =>
            {
                d.Id = 0;
                return d;
            }));
            ctx.SaveChanges();
        }
    }

    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies05))]
    public void Run05(string mappingStrategy)
    {
        var contextType = ContextMap05[mappingStrategy];
        var ctx = Activator.CreateInstance(contextType) as Contexts.Props05.BasicContext;
        if (ctx == null) return;
        ctx.GetAllData();
        ctx.Dispose();
    }

    [GlobalSetup(Target = nameof(Run05))]
    public void GlobalSetup05()
    {
        // Delete old data
        DeleteTestData05();

        // Create new data
        var data = new List<Models.Props05.Root>();
        data.AddRange(Faker05.RootFaker.Generate(EntitiesCount));
        data.AddRange(Faker05.ChildAFaker.Generate(EntitiesCount));
        data.AddRange(Faker05.ChildBFaker.Generate(EntitiesCount));
        data.AddRange(Faker05.ChildCFaker.Generate(EntitiesCount));

        // Set new data
        foreach (var ctxType in ContextMap05.Values)
        {
            using var ctx = Activator.CreateInstance(ctxType) as Contexts.Props05.BasicContext;
            if (ctx == null) return;
            ctx.AddData(data.Select(d =>
            {
                d.Id = 0;
                return d;
            }));
            ctx.SaveChanges();
        }
    }
    
    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies08))]
    public void Run08(string mappingStrategy)
    {
        var contextType = ContextMap08[mappingStrategy];
        var ctx = Activator.CreateInstance(contextType) as Contexts.Props08.BasicContext;
        if (ctx == null) return;
        ctx.GetAllData();
        ctx.Dispose();
    }

    [GlobalSetup(Target = nameof(Run08))]
    public void GlobalSetup08()
    {
        // Delete old data
        DeleteTestData08();

        // Create new data
        var data = new List<Models.Props08.Root>();
        data.AddRange(Faker08.RootFaker.Generate(EntitiesCount));
        data.AddRange(Faker08.ChildAFaker.Generate(EntitiesCount));
        data.AddRange(Faker08.ChildBFaker.Generate(EntitiesCount));
        data.AddRange(Faker08.ChildCFaker.Generate(EntitiesCount));

        // Set new data
        foreach (var ctxType in ContextMap08.Values)
        {
            using var ctx = Activator.CreateInstance(ctxType) as Contexts.Props08.BasicContext;
            if (ctx == null) return;
            ctx.AddData(data.Select(d =>
            {
                d.Id = 0;
                return d;
            }));
            ctx.SaveChanges();
        }
    }
    
    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies13))]
    public void Run13(string mappingStrategy)
    {
        var contextType = ContextMap13[mappingStrategy];
        var ctx = Activator.CreateInstance(contextType) as Contexts.Props13.BasicContext;
        if (ctx == null) return;
        ctx.GetAllData();
        ctx.Dispose();
    }

    [GlobalSetup(Target = nameof(Run13))]
    public void GlobalSetup13()
    {
        // Delete old data
        DeleteTestData13();

        // Create new data
        var data = new List<Models.Props13.Root>();
        data.AddRange(Faker13.RootFaker.Generate(EntitiesCount));
        data.AddRange(Faker13.ChildAFaker.Generate(EntitiesCount));
        data.AddRange(Faker13.ChildBFaker.Generate(EntitiesCount));
        data.AddRange(Faker13.ChildCFaker.Generate(EntitiesCount));

        // Set new data
        foreach (var ctxType in ContextMap13.Values)
        {
            using var ctx = Activator.CreateInstance(ctxType) as Contexts.Props13.BasicContext;
            if (ctx == null) return;
            ctx.AddData(data.Select(d =>
            {
                d.Id = 0;
                return d;
            }));
            ctx.SaveChanges();
        }
    }

    [Benchmark]
    [ArgumentsSource(nameof(MappingStrategies21))]
    public void Run21(string mappingStrategy)
    {
        var contextType = ContextMap21[mappingStrategy];
        var ctx = Activator.CreateInstance(contextType) as Contexts.Props21.BasicContext;
        if (ctx == null) return;
        ctx.GetAllData();
        ctx.Dispose();
    }

    [GlobalSetup(Target = nameof(Run21))]
    public void GlobalSetup21()
    {
        // Delete old data
        DeleteTestData21();

        // Create new data
        var data = new List<Models.Props21.Root>();
        data.AddRange(Faker21.RootFaker.Generate(EntitiesCount));
        data.AddRange(Faker21.ChildAFaker.Generate(EntitiesCount));
        data.AddRange(Faker21.ChildBFaker.Generate(EntitiesCount));
        data.AddRange(Faker21.ChildCFaker.Generate(EntitiesCount));

        // Set new data
        foreach (var ctxType in ContextMap21.Values)
        {
            using var ctx = Activator.CreateInstance(ctxType) as Contexts.Props21.BasicContext;
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