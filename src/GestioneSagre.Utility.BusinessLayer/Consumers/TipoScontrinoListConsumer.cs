namespace GestioneSagre.Utility.BusinessLayer.Consumers;

public class TipoScontrinoListConsumer : IConsumer<TipoScontrinoListRequest>
{
    private readonly IUtilityService utilityService;

    public TipoScontrinoListConsumer(IUtilityService utilityService)
    {
        this.utilityService = utilityService;
    }

    public async Task Consume(ConsumeContext<TipoScontrinoListRequest> context)
    {
        var result = await utilityService.GetListTipoScontrinoAsync();

        await context.RespondAsync(new TipoScontrinoListResponse { TipoScontrini = result });
    }
}