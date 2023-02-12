dotnet ef migrations add Init --context Demo.Contexts.Props03.TphContext -o Migrations/03/Tph
dotnet ef migrations add Init --context Demo.Contexts.Props03.TphJsonContext -o Migrations/03/TphJson
dotnet ef migrations add Init --context Demo.Contexts.Props05.TphContext -o Migrations/05/Tph
dotnet ef migrations add Init --context Demo.Contexts.Props05.TphJsonContext -o Migrations/05/TphJson
dotnet ef migrations add Init --context Demo.Contexts.Props08.TphContext -o Migrations/08/Tph
dotnet ef migrations add Init --context Demo.Contexts.Props08.TphJsonContext -o Migrations/08/TphJson
dotnet ef migrations add Init --context Demo.Contexts.Props13.TphContext -o Migrations/13/Tph
dotnet ef migrations add Init --context Demo.Contexts.Props13.TphJsonContext -o Migrations/13/TphJson
dotnet ef migrations add Init --context Demo.Contexts.Props21.TphContext -o Migrations/21/Tph
dotnet ef migrations add Init --context Demo.Contexts.Props21.TphJsonContext -o Migrations/21/TphJson

dotnet ef database update --context Demo.Contexts.Props03.TphContext
dotnet ef database update --context Demo.Contexts.Props03.TphJsonContext
dotnet ef database update --context Demo.Contexts.Props05.TphContext
dotnet ef database update --context Demo.Contexts.Props05.TphJsonContext
dotnet ef database update --context Demo.Contexts.Props08.TphContext
dotnet ef database update --context Demo.Contexts.Props08.TphJsonContext
dotnet ef database update --context Demo.Contexts.Props13.TphContext
dotnet ef database update --context Demo.Contexts.Props13.TphJsonContext
dotnet ef database update --context Demo.Contexts.Props21.TphContext
dotnet ef database update --context Demo.Contexts.Props21.TphJsonContext