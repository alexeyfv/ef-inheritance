using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Demo.Models.Default;

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
    public int ChildAProp4 { get; set; }
}

public class ChildB : Root
{
    public string ChildBProp1 { get; set; } = string.Empty;
    public string ChildBProp2 { get; set; } = string.Empty;
    public int ChildBProp3 { get; set; }
    public int ChildBProp4 { get; set; }
}

public class ChildC : Root
{
    public string ChildCProp1 { get; set; } = string.Empty;
    public string ChildCProp2 { get; set; } = string.Empty;
    public int ChildCProp3 { get; set; }
    public int ChildCProp4 { get; set; }
}

public class RootWrapper : Root
{
    public string Payload { get; set; } = string.Empty;
    [NotMapped]
    public Root OriginalEntity
    {
        get
        {
            Root p;

            if (PayloadType == PayloadTypes.ChildA)
            {
                p = JsonSerializer.Deserialize<ChildA>(Payload) ?? new ChildA();
            }
            else if (PayloadType == PayloadTypes.ChildB)
            {
                p = JsonSerializer.Deserialize<ChildB>(Payload) ?? new ChildB();
            }
            else if (PayloadType == PayloadTypes.ChildC)
            {
                p = JsonSerializer.Deserialize<ChildC>(Payload) ?? new ChildC();
            }
            else
            {
                p = new Root();
            }
            p.Id = Id;
            p.RootProp1 = RootProp1;
            p.RootProp2 = RootProp2;
            p.RootProp3 = RootProp3;
            p.RootProp4 = RootProp4;
            return p;
        }
        set
        {
            Id = value.Id;
            RootProp1 = value.RootProp1;
            RootProp2 = value.RootProp2;
            RootProp3 = value.RootProp3;
            RootProp4 = value.RootProp4;

            if (value is ChildA childA)
            {
                Payload = JsonSerializer.Serialize<ChildA>(childA);
                PayloadType = PayloadTypes.ChildA;
            }
            else if (value is ChildB childB)
            {
                Payload = JsonSerializer.Serialize<ChildB>(childB);
                PayloadType = PayloadTypes.ChildB;

            }
            else if (value is ChildC childC)
            {
                Payload = JsonSerializer.Serialize<ChildC>(childC);
                PayloadType = PayloadTypes.ChildC;
            }
            else
            {
                PayloadType = PayloadTypes.Root;
            }
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