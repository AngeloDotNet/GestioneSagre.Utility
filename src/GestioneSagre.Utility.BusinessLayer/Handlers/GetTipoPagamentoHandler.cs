namespace GestioneSagre.Utility.BusinessLayer.Handlers;

public class GetTipoPagamentoHandler : IQueryHandler<GetTipoPagamentoQuery, List<TipoPagamento>>
{
    private readonly ILoggerService logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    public GetTipoPagamentoHandler(ILoggerService logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    public async Task<List<TipoPagamento>> Handle(GetTipoPagamentoQuery request, CancellationToken cancellationToken)
    {
        logger.SaveLogInformation("Esecuzione Handler: TipoPagamento");

        var recordKey = $"TipoPagamento_{Guid.NewGuid()}";
        var lista = await cacheService.GetCacheAsync<List<TipoPagamento>>(recordKey);

        if (lista is null)
        {
            lista = await utilityService.GetListTipoPagamentoAsync();
            await cacheService.SetCacheAsync(recordKey, lista);
        }

        return lista;
    }
}