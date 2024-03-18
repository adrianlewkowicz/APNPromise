using Applications.Commands;
using Applications.Queries;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var contextFactory = new DataContextFactory();
var dbContext = contextFactory.CreateDbContext(null); // Argumenty mogą być przekazane zgodnie z potrzebą
builder.Services.AddSingleton(dbContext);
// Dodaj usługi z projektu MojaBiblioteka.Application
builder.Services.AddScoped<IBookQueryService, BookQueryService>();
builder.Services.AddScoped<IOrderQueryService, OrderQueryService>();

// Dodaj usługi z projektu MojaBiblioteka.Infrastructure
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

// Dodaj usługi z projektu MojaBiblioteka.Application.Commands
builder.Services.AddScoped<IBookCommandService, BookCommandService>();


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

