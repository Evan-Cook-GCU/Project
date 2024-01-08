using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Controllers;
using ProjectAPI.Models.DomainModels;
using ProjectAPI.services.WeatherForecast.Create;
using System.Globalization;

internal class Program
{
    private static WebApplicationBuilder WebBuilder;
    private static IConfiguration Configuration { get; set; }

static void getUsers()
    {
        using var context= new ProjectContext();
        var users = context.Users.ToList();
        foreach (var user in users)
        {
            Console.WriteLine(user.Name);
        }
    }
    static void addUsers()
    {
        using var context = new ProjectContext();
        var user = new User();
        context.Users.Add(user);
        context.SaveChanges();
    }


    private static void Main(string[] args)
    {
        //get the configuration
        var configuration = new ConfigurationBuilder();
        configuration.AddJsonFile("appsettings.json");
        var config = configuration.Build();
        using(ProjectContext context = new ProjectContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
        getUsers();
        addUsers();
        getUsers();
        WebBuilder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        WebBuilder.Services.AddControllers();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

        WebBuilder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });
        WebBuilder.Services.AddEndpointsApiExplorer();
        WebBuilder.Services.AddSwaggerGen();
        ConfigureAutofac();
        var app = WebBuilder.Build();

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
    }

    private static void ConfigureAutofac()
    {
        //configure autofac
        WebBuilder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
        WebBuilder.Host.ConfigureContainer<ContainerBuilder>(container =>
        {
            container.RegisterType<WeatherForecastController>().PropertiesAutowired();
            container.RegisterType<CreateWeatherForecast>().As<ICreateWeatherForecast>().PropertiesAutowired();
        });
    }
    private static void ConfigureDatabase(IServiceCollection services)
    {
        services.AddDbContext<ProjectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    }
}
