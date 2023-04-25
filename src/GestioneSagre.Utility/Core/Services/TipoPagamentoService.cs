namespace GestioneSagre.Utility.Core.Services;

public class TipoPagamentoService : ITipoPagamentoService
{
    private readonly IUnitOfWork<TipoPagamento, Guid> unitOfWork;

    public TipoPagamentoService(IUnitOfWork<TipoPagamento, Guid> unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public Task<List<TipoPagamento>> GetListTipoPagamentoAsync()
    {
        return unitOfWork.ReadOnly.GetAllAsync();
    }
}
