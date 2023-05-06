namespace GestioneSagre.Utility.Business.Handlers;

public class GetScontrinoStatoHandler : IQueryHandler<GetScontrinoStatoQuery, List<ScontrinoStato>>
{
    private readonly ILogger<GetScontrinoStatoHandler> logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    public GetScontrinoStatoHandler(ILogger<GetScontrinoStatoHandler> logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    public async Task<List<ScontrinoStato>> Handle(GetScontrinoStatoQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetScontrinoStato");

        var cache = cacheService.GetCache<List<ScontrinoStato>>("ScontrinoStato");

        if (cache != null)
        {
            return cache;
        }
        else
        {
            var result = await utilityService.GetListScontrinoStatoAsync();
            return cacheService.SetCache("ScontrinoStato", result);
        }
    }
}