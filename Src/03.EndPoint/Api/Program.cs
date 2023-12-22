using Application.Models.General;
using ApplicationServices.Services.Doping;
using ApplicationServices.Services.DopingService;
using ApplicationServices.Validator;
using DataLayer.SqlServer.Repositories;
using DomainClass.Altersklassen;
using DomainClass.Gewichtsklassen;
using DomainClass.Models;
using DomainClass.Teilnehmer;
using DomainClass.Verbaende;
using DomainClass.Vereine;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var cnnString = builder.Configuration.GetConnectionString("AppCnn");
builder.Services.AddDbContext<NOVATestContext>(options => options.UseSqlServer(cnnString));

builder.Services.AddScoped<IAltersklassenRepository, AltersklassenRepository>();
builder.Services.AddScoped<IGewichtsklassenRepository, GewichtsklassenRepository>();
builder.Services.AddScoped<ITeilnehmerRepository, TeilnehmerRepository>();
builder.Services.AddScoped<IVerbaendeRepository, VerbaendeRepository>();
builder.Services.AddScoped<IVereineRepository, VereineRepository>();



builder.Services.AddScoped<IDopingService, DopingService>();




builder.Services.AddScoped<IValidator<Filter>, FilterValidator>();
builder.Services.AddFluentValidationAutoValidation();

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
