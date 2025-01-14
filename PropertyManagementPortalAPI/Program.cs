using MongoDB.Driver;
using PropertyManagementPortalAPI.Data;
using PropertyManagementPortalAPI.Models;
using PropertyManagementPortalAPI.Services;

bool environmentIsLive = false;
var builder = WebApplication.CreateBuilder(args);
var secrets = builder.Configuration.GetSection("APISecrets");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var dbInfo = secrets.GetSection(environmentIsLive ? "MongoDB:Live" : "MongoDB:Local");

builder.Services.AddSingleton<IMongoClient>(serviceProvider =>
    new MongoClient(dbInfo["ConnectionString"]));

// Add scoped services here
builder.Services.AddScoped(provider => 
    new MongoCollectionService<Property>(
        provider.GetRequiredService<IMongoClient>(),
        dbInfo["Database"]!,
        "properties"
    ));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
