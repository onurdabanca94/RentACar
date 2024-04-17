using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfigurations;

public class FuelConfiguration : IEntityTypeConfiguration<Fuel>
{
    public void Configure(EntityTypeBuilder<Fuel> builder)
    {
        builder.ToTable("Fuels").HasKey(f => f.Id);

        builder.Property(f => f.Id).HasColumnName("Id").IsRequired();
        builder.Property(f => f.Name).HasColumnName("Name").IsRequired();
        builder.Property(f => f.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(f => f.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(f => f.DeletedDate).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: f => f.Name, name: "UK_Fuels_Name").IsUnique(); //UK--> Unique Key

        builder.HasMany(f => f.Models);

        builder.HasQueryFilter(f => !f.DeletedDate.HasValue); //Silinen veriler değilse filtre uygula
    }
}
