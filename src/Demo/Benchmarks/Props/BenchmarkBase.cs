using Microsoft.EntityFrameworkCore;

namespace Demo.Benchmarks.Props;

public abstract class BenchmarkBase
{
    public string[] MappingStrategies03 => ContextMap03.Keys.ToArray();
    public string[] MappingStrategies05 => ContextMap05.Keys.ToArray();
    public string[] MappingStrategies08 => ContextMap08.Keys.ToArray();
    public string[] MappingStrategies13 => ContextMap13.Keys.ToArray();
    public string[] MappingStrategies21 => ContextMap21.Keys.ToArray();

    public Fakers.Props03.Faker Faker03 { get; set; } = new();
    public Fakers.Props05.Faker Faker05 { get; set; } = new();
    public Fakers.Props08.Faker Faker08 { get; set; } = new();
    public Fakers.Props13.Faker Faker13 { get; set; } = new();
    public Fakers.Props21.Faker Faker21 { get; set; } = new();

    public Dictionary<string, Type> ContextMap03 { get; } = new()
    {
        ["Tph03"] = typeof(Contexts.Props03.TphContext),
        ["TphJson03"] = typeof(Contexts.Props03.TphJsonContext),
    };
    public Dictionary<string, Type> ContextMap05 { get; } = new()
    {
        ["Tph05"] = typeof(Contexts.Props05.TphContext),
        ["TphJson05"] = typeof(Contexts.Props05.TphJsonContext),
    };
    public Dictionary<string, Type> ContextMap08 { get; } = new()
    {
        ["Tph08"] = typeof(Contexts.Props08.TphContext),
        ["TphJson08"] = typeof(Contexts.Props08.TphJsonContext),
    };
    public Dictionary<string, Type> ContextMap13 { get; } = new()
    {
        ["Tph13"] = typeof(Contexts.Props13.TphContext),
        ["TphJson13"] = typeof(Contexts.Props13.TphJsonContext),
    };
    public Dictionary<string, Type> ContextMap21 { get; } = new()
    {
        ["Tph21"] = typeof(Contexts.Props21.TphContext),
        ["TphJson21"] = typeof(Contexts.Props21.TphJsonContext),
    };

    public abstract int EntitiesCount { get; set; }

    protected void DeleteTestData03()
    {
        using var tph03 = new Contexts.Props03.TphContext();
        tph03.Database.ExecuteSqlRaw(@"DELETE FROM [tph03].[Roots];");
        using var tphJson03 = new Contexts.Props03.TphJsonContext();
        tphJson03.Database.ExecuteSqlRaw(@"DELETE FROM [tphjson03].[Roots];");
    }

    protected void DeleteTestData05()
    {
        using var tph05 = new Contexts.Props05.TphContext();
        tph05.Database.ExecuteSqlRaw(@"DELETE FROM [tph05].[Roots];");
        using var tphJson05 = new Contexts.Props05.TphJsonContext();
        tphJson05.Database.ExecuteSqlRaw(@"DELETE FROM [tphjson05].[Roots];");
    }

    protected void DeleteTestData08()
    {
        using var tph08 = new Contexts.Props08.TphContext();
        tph08.Database.ExecuteSqlRaw(@"DELETE FROM [tph08].[Roots];");
        using var tphJson08 = new Contexts.Props08.TphJsonContext();
        tphJson08.Database.ExecuteSqlRaw(@"DELETE FROM [tphjson08].[Roots];");
    }

    protected void DeleteTestData13()
    {
        using var tph13 = new Contexts.Props13.TphContext();
        tph13.Database.ExecuteSqlRaw(@"DELETE FROM [tph13].[Roots];");
        using var tphJson13 = new Contexts.Props13.TphJsonContext();
        tphJson13.Database.ExecuteSqlRaw(@"DELETE FROM [tphjson13].[Roots];");
    }

    protected void DeleteTestData21()
    {
        using var tph21 = new Contexts.Props21.TphContext();
        tph21.Database.ExecuteSqlRaw(@"DELETE FROM [tph21].[Roots];");
        using var tphJson21 = new Contexts.Props21.TphJsonContext();
        tphJson21.Database.ExecuteSqlRaw(@"DELETE FROM [tphjson21].[Roots];");
    }
}