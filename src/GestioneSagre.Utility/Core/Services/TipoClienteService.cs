namespace GestioneSagre.Utility.Core.Services;

public class TipoClienteService : ITipoClienteService
{
    private readonly IUnitOfWork<TipoCliente, Guid> unitOfWork;

    public TipoClienteService(IUnitOfWork<TipoCliente, Guid> unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public Task<List<TipoCliente>> GetListTipoClienteAsync()
    {
        return unitOfWork.ReadOnly.GetAllAsync();
    }
}