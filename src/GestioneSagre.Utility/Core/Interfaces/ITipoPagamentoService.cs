namespace GestioneSagre.Utility.Core.Interfaces;

public interface ITipoPagamentoService
{
    Task<List<TipoPagamento>> GetListTipoPagamentoAsync();
}