using Microsoft.EntityFrameworkCore;
using Backend.Database.Data;
using Backend.Database.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=Database/app.db"));


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors();

app.MapGet("/hello", () =>
{
    Console.WriteLine("Endpoint was called!");
    return "Hello world!";
});

app.MapPost("/users", async (AppDbContext db) =>
{
    var user = new User
    {
        FirstName = "",
        LastName = "",
        Email = "example@titan.com"
    };

    db.Users.Add(user);
    await db.SaveChangesAsync();

    return user;
});

app.Run();