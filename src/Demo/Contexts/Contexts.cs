using Microsoft.EntityFrameworkCore;
using Demo.Models.Default;

namespace Demo.Contexts.Default;

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

public abstract class PlainContext : BasicContext
{
    public DbSet<Root> Roots { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChildA>();
        modelBuilder.Entity<ChildB>();
        modelBuilder.Entity<ChildC>();
    }

    public override void AddData(IEnumerable<Root> data) => Roots.AddRange(data);

    public override void GetAllData() => Roots.ToList();
}

public class TpcContext : PlainContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("tpc");
        modelBuilder.Entity<Root>().UseTpcMappingStrategy();
    }
}

public class TphContext : PlainContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("tph");
        modelBuilder.Entity<Root>().UseTphMappingStrategy();
    }
}

public class TptContext : PlainContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("tpt");
        modelBuilder.Entity<Root>().UseTptMappingStrategy();
    }
}

public class TphJsonContext : BasicContext
{
    public DbSet<RootWrapper> Roots { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("tphjson");
        modelBuilder.Entity<RootWrapper>().UseTphMappingStrategy();
    }

    public override void AddData(IEnumerable<Root> data) => 
        Roots.AddRange(data.Select(d => new RootWrapper() { OriginalEntity = d }));

    public override void GetAllData() => Roots.ToList().Select(p => p.OriginalEntity);
}