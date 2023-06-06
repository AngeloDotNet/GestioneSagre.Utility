namespace GestioneSagre.Utility.BusinessLayer.Consumers;

public class ScontrinoStatoListConsumer : IConsumer<ScontrinoStatoListRequest>
{
    private readonly IUtilityService utilityService;

    public ScontrinoStatoListConsumer(IUtilityService utilityService)
    {
        this.utilityService = utilityService;
    }

    public async Task Consume(ConsumeContext<ScontrinoStatoListRequest> context)
    {
        var result = await utilityService.GetListScontrinoStatoAsync();

        await context.RespondAsync(new ScontrinoStatoListResponse { ScontriniStati = result });
    }
}