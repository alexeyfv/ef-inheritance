using Microsoft.EntityFrameworkCore;
using Demo.Contexts.Default;
using Demo.Fakers.Default;

namespace Demo.Benchmarks.Default;

public abstract class BenchmarkBase
{
    public string[] MappingStrategies => ContextMap.Keys.ToArray();

    public Faker Faker { get; set; } = new();

    public Dictionary<string, Type> ContextMap { get; } = new()
    {
        ["Tph"] = typeof(TphContext),
        ["Tpt"] = typeof(TptContext),
        ["Tpc"] = typeof(TpcContext),
        ["TphJson"] = typeof(TphJsonContext),
    };

    public abstract int EntitiesCount { get; set; }

    protected void DeleteTestData()
    {
        using var tph = new TphContext();
        tph.Database.ExecuteSqlRaw(@"DELETE FROM [tph].[Roots];");

        using var tpt = new TptContext();
        tpt.Database.ExecuteSqlRaw(@"DELETE FROM [tpt].[Roots];");
        tpt.Database.ExecuteSqlRaw(@"DELETE FROM [tpt].[ChildA];");
        tpt.Database.ExecuteSqlRaw(@"DELETE FROM [tpt].[ChildB];");
        tpt.Database.ExecuteSqlRaw(@"DELETE FROM [tpt].[ChildC];");

        using var tpc = new TpcContext();
        tpc.Database.ExecuteSqlRaw(@"DELETE FROM [tpc].[Roots];"); ;
        tpc.Database.ExecuteSqlRaw(@"DELETE FROM [tpc].[ChildA];");
        tpc.Database.ExecuteSqlRaw(@"DELETE FROM [tpc].[ChildB];");
        tpc.Database.ExecuteSqlRaw(@"DELETE FROM [tpc].[ChildC];");

        using var tphjson = new TphJsonContext();
        tphjson.Database.ExecuteSqlRaw(@"DELETE FROM [tphjson].[Roots];");
    }
}