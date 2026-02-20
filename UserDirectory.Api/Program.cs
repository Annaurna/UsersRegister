using UserDirectory.Api.Data;
using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Sqlite;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add Entity Framework Core
builder.Services.AddDbContext<UserDirectoryContext>(options =>
    options.UseSqlite("Data Source = Data/users.db"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Ensure DB is created and seeded
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<UserDirectoryContext>();
    db.Database.EnsureCreated(); // Creates DB and applies seed data
}



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAngular");

app.UseAuthorization();

app.MapControllers();

app.Run();
