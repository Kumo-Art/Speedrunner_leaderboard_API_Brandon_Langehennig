using Microsoft.EntityFrameworkCore;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Data;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Repositories;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IRunRepository, RunRepository>();

builder.Services.AddScoped<IRunServices, RunServices>();

//builder.Services.AddScoped<IRunnerRepository, RunnerRepository>();

//builder.Services.AddScoped<IRunnerServices, RunnerServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
