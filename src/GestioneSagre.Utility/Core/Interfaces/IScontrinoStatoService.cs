namespace GestioneSagre.Utility.Core.Interfaces;

public interface IScontrinoStatoService
{
    Task<List<ScontrinoStato>> GetListScontrinoStatoAsync();
}