# Entity Framework Efficient Querying

Before running any benchmark, do not forget to uncomment necessary line of code in `Program.cs`.

## Default benchmark

``` bash
# Run container with SQL Server
cd src
docker-compose up

# Create and apply migration
cd demo
default.sh

# Run benchmark
dotnet run -c Release
```

## Props benchmark

``` bash
# Run container with SQL Server
cd src
docker-compose up

# Create and apply migration
cd demo
props.sh

# Run benchmark
dotnet run -c Release
```
