namespace GestioneSagre.Utility.BusinessLayer.Interfaces;

public interface IUtilityService
{
    Task<List<ScontrinoPagato>> GetListScontrinoPagatoAsync();
    Task<List<ScontrinoStato>> GetListScontrinoStatoAsync();
    Task<List<TipoCliente>> GetListTipoClienteAsync();
    Task<List<TipoPagamento>> GetListTipoPagamentoAsync();
    Task<List<TipoScontrino>> GetListTipoScontrinoAsync();
}