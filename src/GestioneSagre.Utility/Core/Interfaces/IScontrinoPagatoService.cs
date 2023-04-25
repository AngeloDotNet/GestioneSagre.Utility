namespace GestioneSagre.Utility.Core.Interfaces;

public interface IScontrinoPagatoService
{
    Task<List<ScontrinoPagato>> GetListScontrinoPagatoAsync();
}