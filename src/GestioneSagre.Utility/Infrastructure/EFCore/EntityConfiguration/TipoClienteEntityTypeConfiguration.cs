namespace GestioneSagre.Utility.Infrastructure.EFCore.EntityConfiguration;

public class TipoClienteEntityTypeConfiguration : IEntityTypeConfiguration<TipoCliente>
{
    public void Configure(EntityTypeBuilder<TipoCliente> builder)
    {
        builder.ToTable("TipoCliente");
        builder.HasKey(x => x.Id);
    }
}