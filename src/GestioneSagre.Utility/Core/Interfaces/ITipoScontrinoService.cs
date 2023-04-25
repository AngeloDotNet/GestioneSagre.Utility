namespace GestioneSagre.Utility.Core.Interfaces;

public interface ITipoScontrinoService
{
    Task<List<TipoScontrino>> GetListTipoScontrinoAsync();
}