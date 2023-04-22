namespace GestioneSagre.Utility.Infrastructure.EFCore.EntityConfiguration;

public class TipoScontrinoEntityTypeConfiguration : IEntityTypeConfiguration<TipoScontrino>
{
    public void Configure(EntityTypeBuilder<TipoScontrino> builder)
    {
        builder.ToTable("TipoScontrino");
        builder.HasKey(x => x.Id);
    }
}