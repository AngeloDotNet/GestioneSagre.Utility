namespace GestioneSagre.Utility.DataAccessLayer.EntityConfiguration;

public class TipoPagamentoEntityTypeConfiguration : IEntityTypeConfiguration<TipoPagamento>
{
    public void Configure(EntityTypeBuilder<TipoPagamento> builder)
    {
        builder.ToTable("TipoPagamento");
        builder.HasKey(x => x.Id);
    }
}