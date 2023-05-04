namespace GestioneSagre.Utility.Core.Interfaces;

public interface ICacheService
{
    T Get<T>(string key);
    T Set<T>(string key, T value, TimeSpan? absoluteExpireTime = null, TimeSpan? slidingExpireTime = null);
}