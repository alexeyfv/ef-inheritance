using Microsoft.EntityFrameworkCore;
using Demo.Models.Props08;

namespace Demo.Contexts.Props08;

public abstract class BasicContext : DbContext
{
    protected readonly string connectionString = @"
            Server=localhost;
            Database=master;
            Encrypt=false;
            Integrated Security=false;
            User=sa;
            Password=Secret1234;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    public abstract void AddData(IEnumerable<Root> data);

    public abstract void GetAllData();
}

public class TphContext : BasicContext
{
    public DbSet<Root> Roots { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("tph08");
        modelBuilder.Entity<ChildA>();
        modelBuilder.Entity<ChildB>();
        modelBuilder.Entity<ChildC>();
        modelBuilder.Entity<Root>().UseTphMappingStrategy();
    }

    public override void AddData(IEnumerable<Root> data) => Roots.AddRange(data);

    public override void GetAllData() => Roots.ToList();
}

public class TphJsonContext : BasicContext
{
    public DbSet<RootWrapper> Roots { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("tphjson08");
        modelBuilder.Entity<RootWrapper>().UseTphMappingStrategy();
    }

    public override void AddData(IEnumerable<Root> data) => 
        Roots.AddRange(data.Select(d => new RootWrapper() { OriginalEntity = d }));

    public override void GetAllData() => Roots.ToList().Select(p => p.OriginalEntity);
}