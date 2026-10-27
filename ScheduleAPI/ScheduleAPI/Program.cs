using Microsoft.EntityFrameworkCore;
using ScheduleAPI.Application.Repositories;
using ScheduleAPI.Application.UseCases;
using ScheduleAPI.Infrastructure.Persistence;
using ScheduleAPI.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ScheduleDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<CadastrarUsuario>();
builder.Services.AddScoped<BuscarUsuarios>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

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