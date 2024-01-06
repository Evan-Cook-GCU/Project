using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace ProjectAPI.Context.Config
{
    public class WeatherForecastEntityConfig: EntityTypeConfiguration<WeatherForecast>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WeatherForecast> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Summary).IsRequired();
            builder.Property(x => x.TemperatureC).IsRequired();
            builder.Property(x => x.TemperatureF).IsRequired();
        }
    }
}
