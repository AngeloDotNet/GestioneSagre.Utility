namespace GestioneSagre.Utility.Infrastructure.EFCore.EntityConfiguration;

public class ScontrinoPagatoEntityTypeConfiguration : IEntityTypeConfiguration<ScontrinoPagato>
{
    public void Configure(EntityTypeBuilder<ScontrinoPagato> builder)
    {
        builder.ToTable("ScontrinoPagato");
        builder.HasKey(x => x.Id);
    }
}