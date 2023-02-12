dotnet ef migrations add Init --context Demo.Contexts.Default.TphContext -o Migrations/Tph
dotnet ef migrations add Init --context Demo.Contexts.Default.TptContext -o Migrations/Tpt
dotnet ef migrations add Init --context Demo.Contexts.Default.TpcContext -o Migrations/Tpc
dotnet ef migrations add Init --context Demo.Contexts.Default.TphJsonContext -o Migrations/TphJson

dotnet ef database update --context Demo.Contexts.Default.TphContext
dotnet ef database update --context Demo.Contexts.Default.TptContext
dotnet ef database update --context Demo.Contexts.Default.TpcContext
dotnet ef database update --context Demo.Contexts.Default.TphJsonContext