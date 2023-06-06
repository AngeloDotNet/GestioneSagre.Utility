namespace GestioneSagre.Utility.BusinessLayer.Handlers;

public class GetTipoScontrinoHandler : IQueryHandler<GetTipoScontrinoQuery, List<TipoScontrino>>
{
    private readonly ILoggerService logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    public GetTipoScontrinoHandler(ILoggerService logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    public async Task<List<TipoScontrino>> Handle(GetTipoScontrinoQuery request, CancellationToken cancellationToken)
    {
        logger.SaveLogInformation("Esecuzione Handler: TipoScontrino");

        var recordKey = $"TipoScontrino_{SequentialGuidGenerator.Instance.NewGuid()}";
        var lista = await cacheService.GetCacheAsync<List<TipoScontrino>>(recordKey);

        if (lista is null)
        {
            lista = await utilityService.GetListTipoScontrinoAsync();
            await cacheService.SetCacheAsync(recordKey, lista);
        }

        return lista;
    }
}