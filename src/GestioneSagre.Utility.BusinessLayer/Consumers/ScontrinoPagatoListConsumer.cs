namespace GestioneSagre.Utility.BusinessLayer.Consumers;

public class ScontrinoPagatoListConsumer : IConsumer<ScontrinoPagatoListRequest>
{
    private readonly IUtilityService utilityService;

    public ScontrinoPagatoListConsumer(IUtilityService utilityService)
    {
        this.utilityService = utilityService;
    }

    public async Task Consume(ConsumeContext<ScontrinoPagatoListRequest> context)
    {
        var result = await utilityService.GetListScontrinoPagatoAsync();

        await context.RespondAsync(new ScontrinoPagatoListResponse { ScontriniPagati = result });
    }
}