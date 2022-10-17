using Microsoft.EntityFrameworkCore;
using ReactWebAPI.Model.AppDbContext;
using ReactWebAPI.Repository.Classes;
using ReactWebAPI.Repository.Interfaaces;
using ReactWebAPI.Services.Classes;
using ReactWebAPI.Services.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<INewsRepository, NewsRepository>();
builder.Services.AddTransient<INewsService, NewsService>();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));


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
