using CustomLibrary.EFCore.EFCore.Infrastructure.Interfaces;

namespace GestioneSagre.Utility.BusinessLayer.Interfaces;

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

    public async Task<List<ScontrinoPagato>> GetListScontrinoPagatoAsync() => await uOWScontrinoPagato.ReadOnly.GetAllAsync();
    public async Task<List<ScontrinoStato>> GetListScontrinoStatoAsync() => await uOWScontrinoStato.ReadOnly.GetAllAsync();
    public async Task<List<TipoCliente>> GetListTipoClienteAsync() => await uOWTipoCliente.ReadOnly.GetAllAsync();
    public async Task<List<TipoPagamento>> GetListTipoPagamentoAsync() => await uOWTipoPagamento.ReadOnly.GetAllAsync();
    public async Task<List<TipoScontrino>> GetListTipoScontrinoAsync() => await uOWTipoScontrino.ReadOnly.GetAllAsync();
}