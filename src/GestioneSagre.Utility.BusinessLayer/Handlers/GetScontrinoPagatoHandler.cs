namespace GestioneSagre.Utility.BusinessLayer.Handlers;

public class GetScontrinoPagatoHandler : IQueryHandler<GetScontrinoPagatoQuery, List<ScontrinoPagato>>
{
    private readonly ILoggerService logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    public GetScontrinoPagatoHandler(ILoggerService logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    public async Task<List<ScontrinoPagato>> Handle(GetScontrinoPagatoQuery request, CancellationToken cancellationToken)
    {
        logger.SaveLogInformation("Esecuzione Handler: ScontrinoPagato");

        var recordKey = $"ScontrinoPagato_{Guid.NewGuid()}";
        var lista = await cacheService.GetCacheAsync<List<ScontrinoPagato>>(recordKey);

        if (lista is null)
        {
            lista = await utilityService.GetListScontrinoPagatoAsync();
            await cacheService.SetCacheAsync(recordKey, lista);
        }

        return lista;
    }
}