namespace GestioneSagre.Utility.BusinessLayer.Handlers;

public class GetScontrinoStatoHandler : IQueryHandler<GetScontrinoStatoQuery, List<ScontrinoStato>>
{
    private readonly ILoggerService logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    public GetScontrinoStatoHandler(ILoggerService logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    public async Task<List<ScontrinoStato>> Handle(GetScontrinoStatoQuery request, CancellationToken cancellationToken)
    {
        logger.SaveLogInformation("Esecuzione Handler: ScontrinoStato");

        var recordKey = $"ScontrinoStato_{Guid.NewGuid()}";
        var lista = await cacheService.GetCacheAsync<List<ScontrinoStato>>(recordKey);

        if (lista is null)
        {
            lista = await utilityService.GetListScontrinoStatoAsync();
            await cacheService.SetCacheAsync(recordKey, lista);
        }

        return lista;
    }
}