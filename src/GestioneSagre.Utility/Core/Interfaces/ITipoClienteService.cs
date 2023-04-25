namespace GestioneSagre.Utility.Core.Interfaces;

public interface ITipoClienteService
{
    Task<List<TipoCliente>> GetListTipoClienteAsync();
}