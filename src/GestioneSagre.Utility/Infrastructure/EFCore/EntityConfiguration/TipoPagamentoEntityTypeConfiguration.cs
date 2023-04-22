namespace GestioneSagre.Utility.Infrastructure.EFCore.EntityConfiguration;

public class TipoPagamentoEntityTypeConfiguration : IEntityTypeConfiguration<TipoPagamento>
{
    public void Configure(EntityTypeBuilder<TipoPagamento> builder)
    {
        builder.ToTable("TipoPagamento");
        builder.HasKey(x => x.Id);
    }
}