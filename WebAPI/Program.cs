using Application;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
using Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);

//builder.Services.AddDistributedMemoryCache(); //inmemory.

builder.Services.AddStackExchangeRedisCache(opt => opt.Configuration = "localhost:6379");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//Production ortamýnda kýsa hata detayýný göster kuralý eklemiþ olduk.
if (app.Environment.IsProduction())
    app.ConfigureCustomExceptionMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
