﻿namespace GestioneSagre.Utility.DataAccessLayer.EntityConfiguration;

public class ScontrinoStatoEntityTypeConfiguration : IEntityTypeConfiguration<ScontrinoStato>
{
    public void Configure(EntityTypeBuilder<ScontrinoStato> builder)
    {
        builder.ToTable("ScontrinoStato");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(30);
    }
}