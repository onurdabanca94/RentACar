using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.EntityConfigurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars").HasKey(c => c.Id);

        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.ModelId).HasColumnName("ModelId").IsRequired();
        builder.Property(c => c.Kilometer).HasColumnName("Kilometer").IsRequired();
        builder.Property(c => c.CarState).HasColumnName("State");
        builder.Property(c => c.ModelYear).HasColumnName("ModelYear");

        //builder.HasIndex(indexExpression: t => t.Name, name: "UK_Cars_Name").IsUnique(); //UK--> Unique Key -->her veri tekrar edebilir.  Commente aldık.

        builder.HasOne(c => c.Model);

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue); //Silinen veriler değilse filtre uygula
    }
}