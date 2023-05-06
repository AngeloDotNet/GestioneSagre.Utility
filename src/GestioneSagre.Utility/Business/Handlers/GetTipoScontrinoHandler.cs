namespace GestioneSagre.Utility.Business.Handlers;

public class GetTipoScontrinoHandler : IQueryHandler<GetTipoScontrinoQuery, List<TipoScontrino>>
{
    private readonly ILogger<GetTipoScontrinoHandler> logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    public GetTipoScontrinoHandler(ILogger<GetTipoScontrinoHandler> logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    public async Task<List<TipoScontrino>> Handle(GetTipoScontrinoQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetTipoScontrino");

        var cache = cacheService.GetCache<List<TipoScontrino>>("TipoScontrino");

        if (cache != null)
        {
            return cache;
        }
        else
        {
            var result = await utilityService.GetListTipoScontrinoAsync();
            return cacheService.SetCache("TipoScontrino", result);
        }
    }
}