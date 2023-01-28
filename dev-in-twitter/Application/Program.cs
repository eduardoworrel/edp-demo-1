using Microsoft.EntityFrameworkCore;
using Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var con = builder.Configuration.GetConnectionString("MyConnectionString");


builder.Services.AddDbContext<SqlServerContext>(options =>{
    options.UseSqlServer(con);
});

builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
