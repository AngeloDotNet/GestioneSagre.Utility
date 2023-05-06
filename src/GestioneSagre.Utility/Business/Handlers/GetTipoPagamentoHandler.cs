namespace GestioneSagre.Utility.Business.Handlers;

public class GetTipoPagamentoHandler : IQueryHandler<GetTipoPagamentoQuery, List<TipoPagamento>>
{
    private readonly ILogger<GetTipoPagamentoHandler> logger;
    private readonly IUtilityService utilityService;
    private readonly ICacheService cacheService;

    public GetTipoPagamentoHandler(ILogger<GetTipoPagamentoHandler> logger, IUtilityService utilityService, ICacheService cacheService)
    {
        this.logger = logger;
        this.utilityService = utilityService;
        this.cacheService = cacheService;
    }

    public async Task<List<TipoPagamento>> Handle(GetTipoPagamentoQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("GetTipoPagamento");

        var cache = cacheService.GetCache<List<TipoPagamento>>("TipoPagamento");

        if (cache != null)
        {
            return cache;
        }
        else
        {
            var result = await utilityService.GetListTipoPagamentoAsync();
            return cacheService.SetCache("TipoPagamento", result);
        }
    }
}