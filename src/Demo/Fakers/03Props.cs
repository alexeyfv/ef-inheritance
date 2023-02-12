using Bogus;
using Demo.Models.Props03;

namespace Demo.Fakers.Props03;

public class Faker
{
    public Faker<Root> RootFaker { get; } = new Faker<Root>()
        .RuleFor(o => o.RootProp1, s => s.Lorem.Word())
        .RuleFor(o => o.RootProp2, s => s.Lorem.Word())
        .RuleFor(o => o.RootProp3, s => s.Random.Int())
        .RuleFor(o => o.RootProp4, s => s.Random.Int())
        ;

    public Faker<ChildA> ChildAFaker { get; } = new Faker<ChildA>()
        .RuleFor(o => o.RootProp1, s => s.Lorem.Word())
        .RuleFor(o => o.RootProp2, s => s.Lorem.Word())
        .RuleFor(o => o.RootProp3, s => s.Random.Int())
        .RuleFor(o => o.RootProp4, s => s.Random.Int())
        .RuleFor(o => o.ChildAProp1, s => s.Lorem.Word())
        .RuleFor(o => o.ChildAProp2, s => s.Lorem.Word())
        .RuleFor(o => o.ChildAProp3, s => s.Random.Int())
        ;

    public Faker<ChildB> ChildBFaker { get; } = new Faker<ChildB>()
        .RuleFor(o => o.RootProp1, s => s.Lorem.Word())
        .RuleFor(o => o.RootProp2, s => s.Lorem.Word())
        .RuleFor(o => o.RootProp3, s => s.Random.Int())
        .RuleFor(o => o.RootProp4, s => s.Random.Int())
        .RuleFor(o => o.ChildBProp1, s => s.Lorem.Word())
        .RuleFor(o => o.ChildBProp2, s => s.Lorem.Word())
        .RuleFor(o => o.ChildBProp3, s => s.Random.Int())
        ;

    public Faker<ChildC> ChildCFaker { get; } = new Faker<ChildC>()
        .RuleFor(o => o.RootProp1, s => s.Lorem.Word())
        .RuleFor(o => o.RootProp2, s => s.Lorem.Word())
        .RuleFor(o => o.RootProp3, s => s.Random.Int())
        .RuleFor(o => o.RootProp4, s => s.Random.Int())
        .RuleFor(o => o.ChildCProp1, s => s.Lorem.Word())
        .RuleFor(o => o.ChildCProp2, s => s.Lorem.Word())
        .RuleFor(o => o.ChildCProp3, s => s.Random.Int())
        ;
}