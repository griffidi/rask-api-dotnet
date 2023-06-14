using Microsoft.EntityFrameworkCore;
using Rask.Api.Data.Models;
using Rask.Api.Models;
using Rask.Api.Db;
using Rask.Api.Data;
using Rask.Api.Operations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.Configure<RaskDatabaseSettings>(
    builder.Configuration.GetSection("RaskDatabase"));

builder.Services.AddDbContextFactory<RaskDbContext>(options =>
        options
            .UseSqlite(
                DbConnectionString.Create(true))
            .LogTo(m => System.Diagnostics.Debug.WriteLine(m)), ServiceLifetime.Transient);

builder.Services
    .AddMemoryCache()
    .AddGraphQLServer()
    .RegisterDbContext<RaskDbContext>(DbContextKind.Pooled)
    .AddQueryType<EmployeeQuery>()
    .AddFiltering()
    .AddSorting()
    .AddProjections();
// .UseAutomaticPersistedQueryPipeline();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
    Seeder.SeedData();
}

app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

app.MapGraphQL().WithOptions(new HotChocolate.AspNetCore.GraphQLServerOptions
{
    Tool =
    {
        // Disable banana cake pop in environments other than development
        Enable = builder.Environment.IsDevelopment() || builder.Environment.IsEnvironment("Integration")
    }
});

app.Run();
