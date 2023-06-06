namespace GestioneSagre.Utility.BusinessLayer.Consumers;

public class TipoPagamentoListConsumer : IConsumer<TipoPagamentoListRequest>
{
    private readonly IUtilityService utilityService;

    public TipoPagamentoListConsumer(IUtilityService utilityService)
    {
        this.utilityService = utilityService;
    }

    public async Task Consume(ConsumeContext<TipoPagamentoListRequest> context)
    {
        var result = await utilityService.GetListTipoPagamentoAsync();

        await context.RespondAsync(new TipoPagamentoListResponse { TipoPagamenti = result });
    }
}