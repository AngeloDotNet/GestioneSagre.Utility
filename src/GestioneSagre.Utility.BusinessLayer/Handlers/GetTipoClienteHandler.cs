namespace GestioneSagre.Utility.BusinessLayer.Handlers;

public class GetTipoClienteHandler : IQueryHandler<GetTipoClienteQuery, List<TipoCliente>>
{
    private readonly ILoggerService logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    public GetTipoClienteHandler(ILoggerService logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    public async Task<List<TipoCliente>> Handle(GetTipoClienteQuery request, CancellationToken cancellationToken)
    {
        logger.SaveLogInformation("Esecuzione Handler: TipoCliente");

        var recordKey = $"TipoCliente_{Guid.NewGuid()}";
        var lista = await cacheService.GetCacheAsync<List<TipoCliente>>(recordKey);

        if (lista is null)
        {
            lista = await utilityService.GetListTipoClienteAsync();
            await cacheService.SetCacheAsync(recordKey, lista);
        }

        return lista;
    }
}