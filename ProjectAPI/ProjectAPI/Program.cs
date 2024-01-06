using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ProjectAPI.Controllers;
using ProjectAPI.services.WeatherForecast.Create;
using System.Configuration;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectAPI.Models;
using ProjectAPI.Context.DBContext;
using ProjectAPI.Context.Repositories;


var builder = WebApplication.CreateBuilder(args);
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();


// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var culture = new CultureInfo("en-US", false);
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
var connectionString = configuration.GetConnectionString("BooksConnection");
//var connectionString = "Server=localhost;Database=Books;User Id=sa;Password=Password123!;";
/*
builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer(connectionString,
                         sqlServerOptionsAction: sqlOptions =>
                         {
                             sqlOptions.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                         });

    // Configure warnings to throw exceptions during development
    options.EnableSensitiveDataLogging();

    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
*/

//host
//configure autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(container =>
{
    container.RegisterType<WeatherForecastController>().PropertiesAutowired();
    container.RegisterType<CreateWeatherForecast>().As<ICreateWeatherForecast>().PropertiesAutowired();
    container.RegisterType<MyDbContext>().PropertiesAutowired();
    container.RegisterType<Repository<WeatherForecast>>().As<IRepository<WeatherForecast>>().PropertiesAutowired();
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
