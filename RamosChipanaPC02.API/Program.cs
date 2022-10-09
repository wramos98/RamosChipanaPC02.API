using Microsoft.EntityFrameworkCore;
using RamosChipanaPC02.DOMAIN.Core.Interfaces;
using RamosChipanaPC02.DOMAIN.Infrastructure.Data;
using RamosChipanaPC02.DOMAIN.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Get ConnectionString
var connectionString = builder.Configuration.GetConnectionString("DevConnection");

//Add dbContext
builder.Services.AddDbContext<SalesContext>
    (options => options.UseSqlServer(connectionString));

builder.Services.AddTransient<ISupplierRepository, SupplierRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
