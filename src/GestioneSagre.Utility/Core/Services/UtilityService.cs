namespace GestioneSagre.Utility.Core.Services;

public class UtilityService : IUtilityService
{
    private readonly IUnitOfWork<ScontrinoPagato, Guid> uOWScontrinoPagato;
    private readonly IUnitOfWork<ScontrinoStato, Guid> uOWScontrinoStato;
    private readonly IUnitOfWork<TipoCliente, Guid> uOWTipoCliente;
    private readonly IUnitOfWork<TipoPagamento, Guid> uOWTipoPagamento;
    private readonly IUnitOfWork<TipoScontrino, Guid> uOWTipoScontrino;

    public UtilityService(IUnitOfWork<ScontrinoPagato, Guid> uOWScontrinoPagato,
        IUnitOfWork<ScontrinoStato, Guid> uOWScontrinoStato,
        IUnitOfWork<TipoCliente, Guid> uOWTipoCliente,
        IUnitOfWork<TipoPagamento, Guid> uOWTipoPagamento,
        IUnitOfWork<TipoScontrino, Guid> uOWTipoScontrino)
    {
        this.uOWScontrinoPagato = uOWScontrinoPagato;
        this.uOWScontrinoStato = uOWScontrinoStato;
        this.uOWTipoCliente = uOWTipoCliente;
        this.uOWTipoPagamento = uOWTipoPagamento;
        this.uOWTipoScontrino = uOWTipoScontrino;
    }

    public Task<List<ScontrinoPagato>> GetListScontrinoPagatoAsync()
    {
        return uOWScontrinoPagato.ReadOnly.GetAllAsync();
    }

    public Task<List<ScontrinoStato>> GetListScontrinoStatoAsync()
    {
        return uOWScontrinoStato.ReadOnly.GetAllAsync();
    }

    public Task<List<TipoCliente>> GetListTipoClienteAsync()
    {
        return uOWTipoCliente.ReadOnly.GetAllAsync();
    }

    public Task<List<TipoPagamento>> GetListTipoPagamentoAsync()
    {
        return uOWTipoPagamento.ReadOnly.GetAllAsync();
    }

    public Task<List<TipoScontrino>> GetListTipoScontrinoAsync()
    {
        return uOWTipoScontrino.ReadOnly.GetAllAsync();
    }
}