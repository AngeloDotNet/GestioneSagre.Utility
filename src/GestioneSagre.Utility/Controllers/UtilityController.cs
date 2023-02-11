using GestioneSagre.Utility.Controllers.Common;
using Microsoft.AspNetCore.Mvc;

namespace GestioneSagre.Utility.Controllers;

public class UtilityController : BaseController
{
    private readonly ILogger<UtilityController> _logger;

    public UtilityController(ILogger<UtilityController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetTipoCliente")]
    public async Task<List<string>> GetTipoCliente()
    {
        _logger.LogInformation("GetTipoCliente");

        var result = await Task.FromResult(new List<string> { "Cliente", "Staff" });

        return result;
    }

    [HttpGet("GetTipoScontrino")]
    public async Task<List<string>> GetTipoScontrino()
    {
        _logger.LogInformation("GetTipoScontrino");

        var result = await Task.FromResult(new List<string> { "Pagamento", "Omaggio" });

        return result;
    }

    [HttpGet("GetTipoPagamento")]
    public async Task<List<string>> GetTipoPagamento()
    {
        _logger.LogInformation("GetTipoPagamento");

        var result = await Task.FromResult(new List<string> { "Contanti", "Carta di credito", "Carta di debito" });

        return result;
    }

    [HttpGet("GetScontrinoPagato")]
    public async Task<List<string>> GetScontrinoPagato()
    {
        _logger.LogInformation("GetScontrinoPagato");

        var result = await Task.FromResult(new List<string> { "Pagato", "Non pagato" });

        return result;
    }

    [HttpGet("GetScontrinoStato")]
    public async Task<List<string>> GetScontrinoStato()
    {
        _logger.LogInformation("GetScontrinoStato");

        var result = await Task.FromResult(new List<string> { "Aperto", "In elaborazione", "Da incassare", "Chiuso", "Annullato" });

        return result;
    }
}