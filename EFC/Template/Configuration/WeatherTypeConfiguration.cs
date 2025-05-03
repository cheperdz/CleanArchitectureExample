using Entities.Template;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFC.Template.Configuration;

public class WeatherTypeConfiguration : IEntityTypeConfiguration<Weather>
{
    public void Configure(EntityTypeBuilder<Weather> builder)
    {
        builder
            .ToTable("Weathers")
            .HasKey(w => w.Id);

        builder
            .Property(w => w.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("Id")
            .HasColumnOrder(0)
            .IsRequired();

        builder
            .Property(w => w.Name)
            .HasColumnName("Name")
            .HasColumnOrder(1)
            .IsRequired();
    }
}
