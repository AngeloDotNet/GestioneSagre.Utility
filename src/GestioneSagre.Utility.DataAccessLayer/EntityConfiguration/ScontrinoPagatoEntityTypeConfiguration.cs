namespace GestioneSagre.Utility.DataAccessLayer.EntityConfiguration;

public class ScontrinoPagatoEntityTypeConfiguration : IEntityTypeConfiguration<ScontrinoPagato>
{
    public void Configure(EntityTypeBuilder<ScontrinoPagato> builder)
    {
        builder.ToTable("ScontrinoPagato");
        builder.HasKey(x => x.Id);
    }
}