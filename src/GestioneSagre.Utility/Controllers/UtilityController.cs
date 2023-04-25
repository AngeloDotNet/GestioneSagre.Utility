namespace GestioneSagre.Utility.Controllers;

public class UtilityController : BaseController
{
    private readonly ILogger<UtilityController> logger;
    private readonly ITipoClienteService tipoClienteService;
    private readonly ITipoPagamentoService tipoPagamentoService;
    private readonly ITipoScontrinoService tipoScontrinoService;
    private readonly IScontrinoPagatoService scontrinoPagatoService;
    private readonly IScontrinoStatoService scontrinoStatoService;

    public UtilityController(ILogger<UtilityController> logger, ITipoClienteService tipoClienteService,
        ITipoPagamentoService tipoPagamentoService, ITipoScontrinoService tipoScontrinoService,
        IScontrinoPagatoService scontrinoPagatoService, IScontrinoStatoService scontrinoStatoService)
    {
        this.logger = logger;
        this.tipoClienteService = tipoClienteService;
        this.tipoPagamentoService = tipoPagamentoService;
        this.tipoScontrinoService = tipoScontrinoService;
        this.scontrinoPagatoService = scontrinoPagatoService;
        this.scontrinoStatoService = scontrinoStatoService;
    }

    [HttpGet("TipoCliente")]
    public async Task<List<TipoCliente>> GetTipoClienteAsync()
    {
        logger.LogInformation("GetTipoCliente");

        var result = await tipoClienteService.GetListTipoClienteAsync();
        return result;
    }

    [HttpGet("TipoPagamento")]
    public async Task<List<TipoPagamento>> GetTipoPagamentoAsync()
    {
        logger.LogInformation("GetTipoPagamento");

        var result = await tipoPagamentoService.GetListTipoPagamentoAsync();
        return result;
    }

    [HttpGet("TipoScontrino")]
    public async Task<List<TipoScontrino>> GetTipoScontrinoAsync()
    {
        logger.LogInformation("GetTipoScontrino");

        var result = await tipoScontrinoService.GetListTipoScontrinoAsync();
        return result;
    }

    [HttpGet("ScontrinoPagato")]
    public async Task<List<ScontrinoPagato>> GetScontrinoPagatoAsync()
    {
        logger.LogInformation("GetScontrinoPagato");

        var result = await scontrinoPagatoService.GetListScontrinoPagatoAsync();
        return result;
    }

    [HttpGet("ScontrinoStato")]
    public async Task<List<ScontrinoStato>> GetScontrinoStatoAsync()
    {
        logger.LogInformation("GetScontrinoStato");

        var result = await scontrinoStatoService.GetListScontrinoStatoAsync();
        return result;
    }
}