namespace GestioneSagre.Utility.Controllers;

public class UtilityController : BaseController
{
    private readonly ILogger<UtilityController> logger;
    private readonly IMediator mediator;

    public UtilityController(ILogger<UtilityController> logger, IMediator mediator)
    {
        this.logger = logger;
        this.mediator = mediator;
    }

    [HttpGet("TipoCliente")]
    public async Task<List<TipoCliente>> GetTipoClienteAsync() => await mediator.Send(new GetTipoClienteQuery());

    [HttpGet("TipoPagamento")]
    public async Task<List<TipoPagamento>> GetTipoPagamentoAsync() => await mediator.Send(new GetTipoPagamentoQuery());

    [HttpGet("TipoScontrino")]
    public async Task<List<TipoScontrino>> GetTipoScontrinoAsync() => await mediator.Send(new GetTipoScontrinoQuery());

    [HttpGet("ScontrinoPagato")]
    public async Task<List<ScontrinoPagato>> GetScontrinoPagatoAsync() => await mediator.Send(new GetScontrinoPagatoQuery());

    [HttpGet("ScontrinoStato")]
    public async Task<List<ScontrinoStato>> GetScontrinoStatoAsync() => await mediator.Send(new GetScontrinoStatoQuery());
}