﻿namespace GestioneSagre.Utility.DataAccessLayer.EntityConfiguration;

public class TipoClienteEntityTypeConfiguration : IEntityTypeConfiguration<TipoCliente>
{
    public void Configure(EntityTypeBuilder<TipoCliente> builder)
    {
        builder.ToTable("TipoCliente");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(30);
    }
}