namespace GestioneSagre.Utility.Api.Internal.Controllers;

public class UtilityController : BaseController
{
    private readonly IUtilityService service;

    public UtilityController(IUtilityService service)
    {
        this.service = service;
    }

    [HttpGet("TipoCliente")]
    public async Task<List<TipoCliente>> GetTipoClienteAsync() => await service.GetListTipoClienteAsync();

    [HttpGet("TipoPagamento")]
    public async Task<List<TipoPagamento>> GetTipoPagamentoAsync() => await service.GetListTipoPagamentoAsync();

    [HttpGet("TipoScontrino")]
    public async Task<List<TipoScontrino>> GetTipoScontrinoAsync() => await service.GetListTipoScontrinoAsync();

    [HttpGet("ScontrinoPagato")]
    public async Task<List<ScontrinoPagato>> GetScontrinoPagatoAsync() => await service.GetListScontrinoPagatoAsync();

    [HttpGet("ScontrinoStato")]
    public async Task<List<ScontrinoStato>> GetScontrinoStatoAsync() => await service.GetListScontrinoStatoAsync();
}