namespace GestioneSagre.Utility.Core.Services;

public class ScontrinoPagatoService : IScontrinoPagatoService
{
    private readonly IUnitOfWork<ScontrinoPagato, Guid> unitOfWork;

    public ScontrinoPagatoService(IUnitOfWork<ScontrinoPagato, Guid> unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public Task<List<ScontrinoPagato>> GetListScontrinoPagatoAsync()
    {
        return unitOfWork.ReadOnly.GetAllAsync();
    }
}