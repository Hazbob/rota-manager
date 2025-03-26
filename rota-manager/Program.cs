using Microsoft.EntityFrameworkCore;
using rota_manager.Data;
using rota_manager.Errors;
using rota_manager.repositories;
using rota_manager.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

#region deps

builder.Services.AddScoped<RotaEntryService>();
builder.Services.AddScoped<RotaEntryRepository>();
builder.Services.AddScoped<RotaService>();
builder.Services.AddScoped<RotaRepository>();
builder.Services.AddTransient<RotaManagerContext>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<EmployeeRepository>();



#endregion
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new NoDbConnectionStringException();
builder.Services.AddDbContext<RotaManagerContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();
app.MapControllers();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.Run();
