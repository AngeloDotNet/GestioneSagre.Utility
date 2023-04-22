namespace GestioneSagre.Utility.Infrastructure.EFCore.EntityConfiguration;

public class ScontrinoStatoEntityTypeConfiguration : IEntityTypeConfiguration<ScontrinoStato>
{
    public void Configure(EntityTypeBuilder<ScontrinoStato> builder)
    {
        builder.ToTable("ScontrinoStato");
        builder.HasKey(x => x.Id);
    }
}