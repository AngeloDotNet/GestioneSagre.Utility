namespace GestioneSagre.Utility.DataAccessLayer.EntityConfiguration;

public class TipoPagamentoEntityTypeConfiguration : IEntityTypeConfiguration<TipoPagamento>
{
    public void Configure(EntityTypeBuilder<TipoPagamento> builder)
    {
        builder.ToTable("TipoPagamento");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(30);
    }
}