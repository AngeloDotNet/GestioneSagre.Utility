namespace GestioneSagre.Utility.Business.Handlers;

public class GetScontrinoPagatoHandler : IQueryHandler<GetScontrinoPagatoQuery, List<ScontrinoPagato>>
{
    private readonly ILogger<GetScontrinoPagatoHandler> logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    public GetScontrinoPagatoHandler(ILogger<GetScontrinoPagatoHandler> logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    public async Task<List<ScontrinoPagato>> Handle(GetScontrinoPagatoQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetScontrinoPagato");

        var cache = cacheService.GetCache<List<ScontrinoPagato>>("ScontrinoPagato");

        if (cache != null)
        {
            return cache;
        }
        else
        {
            var result = await utilityService.GetListScontrinoPagatoAsync();
            return cacheService.SetCache("ScontrinoPagato", result);
        }
    }
}