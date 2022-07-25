using SuperHero.Application.Interfaces;
using SuperHero.Application.Interfaces.Repositories;
using SuperHero.Application.Interfaces.Services;
using SuperHero.Infrastructure.Persistence;
using SuperHero.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<IComicBookCompanyRepository, ComicBookCompanyRepository>();
builder.Services.AddTransient<IComicBookCompanyService, ComicBookCompanyService>();
builder.Services.AddTransient<ISuperHeroRepository, SuperHeroRepository>();
builder.Services.AddTransient<ISuperHeroService, SuperHeroService>();

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
