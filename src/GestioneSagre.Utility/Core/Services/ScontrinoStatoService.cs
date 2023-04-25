namespace GestioneSagre.Utility.Core.Services;

public class ScontrinoStatoService : IScontrinoStatoService
{
    private readonly IUnitOfWork<ScontrinoStato, Guid> unitOfWork;

    public ScontrinoStatoService(IUnitOfWork<ScontrinoStato, Guid> unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public Task<List<ScontrinoStato>> GetListScontrinoStatoAsync()
    {
        return unitOfWork.ReadOnly.GetAllAsync();
    }
}