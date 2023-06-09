namespace GestioneSagre.Utility.DataAccessLayer;

public class UtilityDbContext : DbContext
{
    public UtilityDbContext(DbContextOptions<UtilityDbContext> options) : base(options)
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
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}