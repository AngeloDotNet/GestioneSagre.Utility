namespace GestioneSagre.Utility.BusinessLayer.Consumers;

public class TipoClienteListConsumer : IConsumer<TipoClienteListRequest>
{
    private readonly IUtilityService utilityService;

    public TipoClienteListConsumer(IUtilityService utilityService)
    {
        this.utilityService = utilityService;
    }

    public async Task Consume(ConsumeContext<TipoClienteListRequest> context)
    {
        var result = await utilityService.GetListTipoClienteAsync();

        await context.RespondAsync(new TipoClienteListResponse { TipoClienti = result });
    }
}