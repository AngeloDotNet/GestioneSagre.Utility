namespace GestioneSagre.Utility.Controllers;

public class UtilityController : BaseController
{
    private readonly ILogger<UtilityController> logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    private readonly TimeSpan absoluteExpireTime = TimeSpan.FromHours(1);
    private readonly TimeSpan slidingExpireTime = TimeSpan.FromMinutes(10);

    public UtilityController(ILogger<UtilityController> logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    [HttpGet("TipoCliente")]
    public async Task<List<TipoCliente>> GetTipoClienteAsync()
    {
        logger.LogInformation("GetTipoCliente");

        var cache = cacheService.Get<List<TipoCliente>>("TipoCliente");

        if (cache != null)
        {
            return cache;
        }
        else
        {
            var result = await utilityService.GetListTipoClienteAsync();
            return cacheService.Set("TipoCliente", result, absoluteExpireTime, slidingExpireTime);
        }
    }

    [HttpGet("TipoPagamento")]
    public async Task<List<TipoPagamento>> GetTipoPagamentoAsync()
    {
        logger.LogInformation("GetTipoPagamento");

        var cache = cacheService.Get<List<TipoPagamento>>("TipoPagamento");

        if (cache != null)
        {
            return cache;
        }
        else
        {
            var result = await utilityService.GetListTipoPagamentoAsync();
            return cacheService.Set("TipoPagamento", result, absoluteExpireTime, slidingExpireTime);
        }
    }

    [HttpGet("TipoScontrino")]
    public async Task<List<TipoScontrino>> GetTipoScontrinoAsync()
    {
        logger.LogInformation("GetTipoScontrino");

        var cache = cacheService.Get<List<TipoScontrino>>("TipoScontrino");

        if (cache != null)
        {
            return cache;
        }
        else
        {
            var result = await utilityService.GetListTipoScontrinoAsync();
            return cacheService.Set("TipoScontrino", result, absoluteExpireTime, slidingExpireTime);
        }
    }

    [HttpGet("ScontrinoPagato")]
    public async Task<List<ScontrinoPagato>> GetScontrinoPagatoAsync()
    {
        logger.LogInformation("GetScontrinoPagato");

        var cache = cacheService.Get<List<ScontrinoPagato>>("ScontrinoPagato");

        if (cache != null)
        {
            return cache;
        }
        else
        {
            var result = await utilityService.GetListScontrinoPagatoAsync();
            return cacheService.Set("ScontrinoPagato", result, absoluteExpireTime, slidingExpireTime);
        }
    }

    [HttpGet("ScontrinoStato")]
    public async Task<List<ScontrinoStato>> GetScontrinoStatoAsync()
    {
        logger.LogInformation("GetScontrinoStato");

        var cache = cacheService.Get<List<ScontrinoStato>>("ScontrinoStato");

        if (cache != null)
        {
            return cache;
        }
        else
        {
            var result = await utilityService.GetListScontrinoStatoAsync();
            return cacheService.Set("ScontrinoStato", result, absoluteExpireTime, slidingExpireTime);
        }
    }
}