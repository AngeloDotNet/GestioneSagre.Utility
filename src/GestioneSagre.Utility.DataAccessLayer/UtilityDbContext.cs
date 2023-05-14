namespace GestioneSagre.Utility.DataAccessLayer;

public class UtilityDbContext : DbContext
{
    public UtilityDbContext(DbContextOptions<UtilityDbContext> dbContextOptions) : base(dbContextOptions)
    {
    }

    public virtual DbSet<ScontrinoPagato> ScontriniPagati { get; set; }
    public virtual DbSet<ScontrinoStato> ScontriniStati { get; set; }
    public virtual DbSet<TipoCliente> TipoClienti { get; set; }
    public virtual DbSet<TipoScontrino> TipoScontrini { get; set; }
    public virtual DbSet<TipoPagamento> TipoPagamenti { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ScontrinoPagatoEntityTypeConfiguration());
        modelBuilder.Entity<ScontrinoPagato>()
            .HasData(
                new ScontrinoPagato { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Pagato" },
                new ScontrinoPagato { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Non pagato" }
        );

        modelBuilder.ApplyConfiguration(new ScontrinoStatoEntityTypeConfiguration());
        modelBuilder.Entity<ScontrinoStato>()
            .HasData(
                new ScontrinoStato { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Aperto" },
                new ScontrinoStato { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "In elaborazione" },
                new ScontrinoStato { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Da incassare" },
                new ScontrinoStato { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Chiuso" },
                new ScontrinoStato { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Annullato" }
        );

        modelBuilder.ApplyConfiguration(new TipoClienteEntityTypeConfiguration());
        modelBuilder.Entity<TipoCliente>()
            .HasData(
                new TipoCliente { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Cliente" },
                new TipoCliente { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Staff" }
        );

        modelBuilder.ApplyConfiguration(new TipoScontrinoEntityTypeConfiguration());
        modelBuilder.Entity<TipoScontrino>()
            .HasData(
                new TipoScontrino { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Pagamento" },
                new TipoScontrino { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Omaggio" }
        );

        modelBuilder.ApplyConfiguration(new TipoPagamentoEntityTypeConfiguration());
        modelBuilder.Entity<TipoPagamento>()
            .HasData(
                new TipoPagamento { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Contanti" },
                new TipoPagamento { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Carta di credito" },
                new TipoPagamento { Id = SequentialGuidGenerator.Instance.NewGuid(), Value = "Carta di debito" }
        );
    }
}