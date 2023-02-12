using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Demo.Models.Props21;

public class Root
{
    [JsonIgnore]
    public int Id { get; set; }
    [JsonIgnore]
    public string RootProp1 { get; set; } = string.Empty;
    [JsonIgnore]
    public string RootProp2 { get; set; } = string.Empty;
    [JsonIgnore]
    public int RootProp3 { get; set; }
    [JsonIgnore]
    public int RootProp4 { get; set; }
}

public class ChildA : Root
{
    public string ChildAProp1 { get; set; } = string.Empty;
    public string ChildAProp2 { get; set; } = string.Empty;
    public int ChildAProp3 { get; set; }
    public string ChildAProp4 { get; set; } = string.Empty;
    public int ChildAProp5 { get; set; }
    public string ChildAProp6 { get; set; } = string.Empty;
    public int ChildAProp7 { get; set; }
    public string ChildAProp8 { get; set; } = string.Empty;
    public int ChildAProp9 { get; set; }
    public string ChildAProp10 { get; set; } = string.Empty;
    public int ChildAProp11 { get; set; }
    public string ChildAProp12 { get; set; } = string.Empty;
    public int ChildAProp13 { get; set; }
    public string ChildAProp14 { get; set; } = string.Empty;
    public int ChildAProp15 { get; set; }
    public string ChildAProp16 { get; set; } = string.Empty;
    public int ChildAProp17 { get; set; }
    public string ChildAProp18 { get; set; } = string.Empty;
    public int ChildAProp19 { get; set; }
    public string ChildAProp20 { get; set; } = string.Empty;
    public int ChildAProp21 { get; set; }
}

public class ChildB : Root
{
    public string ChildBProp1 { get; set; } = string.Empty;
    public string ChildBProp2 { get; set; } = string.Empty;
    public int ChildBProp3 { get; set; }
    public string ChildBProp4 { get; set; } = string.Empty;
    public int ChildBProp5 { get; set; }
    public string ChildBProp6 { get; set; } = string.Empty;
    public int ChildBProp7 { get; set; }
    public string ChildBProp8 { get; set; } = string.Empty;
    public int ChildBProp9 { get; set; }
    public string ChildBProp10 { get; set; } = string.Empty;
    public int ChildBProp11 { get; set; }
    public string ChildBProp12 { get; set; } = string.Empty;
    public int ChildBProp13 { get; set; }
    public string ChildBProp14 { get; set; } = string.Empty;
    public int ChildBProp15 { get; set; }
    public string ChildBProp16 { get; set; } = string.Empty;
    public int ChildBProp17 { get; set; }
    public string ChildBProp18 { get; set; } = string.Empty;
    public int ChildBProp19 { get; set; }
    public string ChildBProp20 { get; set; } = string.Empty;
    public int ChildBProp21 { get; set; }
}

public class ChildC : Root
{
    public string ChildCProp1 { get; set; } = string.Empty;
    public string ChildCProp2 { get; set; } = string.Empty;
    public int ChildCProp3 { get; set; }
    public string ChildCProp4 { get; set; } = string.Empty;
    public int ChildCProp5 { get; set; }
    public string ChildCProp6 { get; set; } = string.Empty;
    public int ChildCProp7 { get; set; }
    public string ChildCProp8 { get; set; } = string.Empty;
    public int ChildCProp9 { get; set; }
    public string ChildCProp10 { get; set; } = string.Empty;
    public int ChildCProp11 { get; set; }
    public string ChildCProp12 { get; set; } = string.Empty;
    public int ChildCProp13 { get; set; }
    public string ChildCProp14 { get; set; } = string.Empty;
    public int ChildCProp15 { get; set; }
    public string ChildCProp16 { get; set; } = string.Empty;
    public int ChildCProp17 { get; set; }
    public string ChildCProp18 { get; set; } = string.Empty;
    public int ChildCProp19 { get; set; }
    public string ChildCProp20 { get; set; } = string.Empty;
    public int ChildCProp21 { get; set; }
}

public class RootWrapper : Root
{
    public string Payload { get; set; } = string.Empty;

    [NotMapped]
    public Root OriginalEntity
    {
        get
        {
            Root p = PayloadType switch
            {
                PayloadTypes.ChildA => JsonSerializer.Deserialize<ChildA>(Payload) ?? new ChildA(),
                PayloadTypes.ChildB => JsonSerializer.Deserialize<ChildB>(Payload) ?? new ChildB(),
                PayloadTypes.ChildC => JsonSerializer.Deserialize<ChildC>(Payload) ?? new ChildC(),
                _ => new Root()
            };

            p.Id = Id;
            p.RootProp1 = RootProp1;
            p.RootProp2 = RootProp2;
            p.RootProp3 = RootProp3;
            p.RootProp4 = RootProp4;
            return p;
        }
        set
        {
            Payload = value switch 
            {
                ChildA c => JsonSerializer.Serialize<ChildA>(c),
                ChildB c => JsonSerializer.Serialize<ChildB>(c),
                ChildC c => JsonSerializer.Serialize<ChildC>(c),
                _ => string.Empty,
            };

            PayloadType = value switch 
            {
                ChildA c => PayloadTypes.ChildA,
                ChildB c => PayloadTypes.ChildB,
                ChildC c => PayloadTypes.ChildC,
                _ => PayloadTypes.Root,
            };

            Id = value.Id;
            RootProp1 = value.RootProp1;
            RootProp2 = value.RootProp2;
            RootProp3 = value.RootProp3;
            RootProp4 = value.RootProp4;
        }
    }


    public PayloadTypes PayloadType { get; set; }

    public enum PayloadTypes
    {
        Root,
        ChildA,
        ChildB,
        ChildC,
    }
}