namespace GestioneSagre.Utility.Business.Handlers;

public class GetTipoClienteHandler : IQueryHandler<GetTipoClienteQuery, List<TipoCliente>>
{
    private readonly ILogger<GetTipoClienteHandler> logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    public GetTipoClienteHandler(ILogger<GetTipoClienteHandler> logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    public async Task<List<TipoCliente>> Handle(GetTipoClienteQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetTipoCliente");

        var cache = cacheService.GetCache<List<TipoCliente>>("TipoCliente");

        if (cache != null)
        {
            return cache;
        }
        else
        {
            var result = await utilityService.GetListTipoClienteAsync();
            return cacheService.SetCache("TipoCliente", result);
        }
    }
}