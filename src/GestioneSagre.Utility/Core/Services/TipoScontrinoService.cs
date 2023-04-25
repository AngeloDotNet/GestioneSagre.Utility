namespace GestioneSagre.Utility.Core.Services;

public class TipoScontrinoService : ITipoScontrinoService
{
    private readonly IUnitOfWork<TipoScontrino, Guid> unitOfWork;

    public TipoScontrinoService(IUnitOfWork<TipoScontrino, Guid> unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public Task<List<TipoScontrino>> GetListTipoScontrinoAsync()
    {
        return unitOfWork.ReadOnly.GetAllAsync();
    }
}