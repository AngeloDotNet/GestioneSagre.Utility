namespace GestioneSagre.Utility.Controllers;

public class UtilityController : BaseController
{
    private readonly ILogger<UtilityController> logger;
    private readonly IUtilityService utilityService;

    public UtilityController(ILogger<UtilityController> logger, IUtilityService utilityService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
    }

    [HttpGet("TipoCliente")]
    public async Task<List<TipoCliente>> GetTipoClienteAsync()
    {
        logger.LogInformation("GetTipoCliente");

        var result = await utilityService.GetListTipoClienteAsync();
        return result;
    }

    [HttpGet("TipoPagamento")]
    public async Task<List<TipoPagamento>> GetTipoPagamentoAsync()
    {
        logger.LogInformation("GetTipoPagamento");

        var result = await utilityService.GetListTipoPagamentoAsync();
        return result;
    }

    [HttpGet("TipoScontrino")]
    public async Task<List<TipoScontrino>> GetTipoScontrinoAsync()
    {
        logger.LogInformation("GetTipoScontrino");

        var result = await utilityService.GetListTipoScontrinoAsync();
        return result;
    }

    [HttpGet("ScontrinoPagato")]
    public async Task<List<ScontrinoPagato>> GetScontrinoPagatoAsync()
    {
        logger.LogInformation("GetScontrinoPagato");

        var result = await utilityService.GetListScontrinoPagatoAsync();
        return result;
    }

    [HttpGet("ScontrinoStato")]
    public async Task<List<ScontrinoStato>> GetScontrinoStatoAsync()
    {
        logger.LogInformation("GetScontrinoStato");

        var result = await utilityService.GetListScontrinoStatoAsync();
        return result;
    }
}