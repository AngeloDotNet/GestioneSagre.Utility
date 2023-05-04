namespace GestioneSagre.Utility.Core.Services;

public class CacheService : ICacheService
{
    private readonly IDistributedCache _cache;

    public CacheService(IDistributedCache cache)
    {
        _cache = cache;
    }

    public T Get<T>(string key)
    {
        var value = _cache.GetString(key);

        if (value != null)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        return default;
    }

    public T Set<T>(string key, T value, TimeSpan? absoluteExpireTime = null, TimeSpan? slidingExpireTime = null)
    {
        var options = new DistributedCacheEntryOptions
        {
            // Imposta l'ora in cui la cache scadrà a partire dall'ora di inserimento (che rappresenta l'adesso)
            AbsoluteExpirationRelativeToNow = absoluteExpireTime,

            // Tempo fino al quale la voce della cache è valida, prima del quale se si verifica un hit il tempo deve essere esteso ulteriormente.
            SlidingExpiration = slidingExpireTime
        };

        _cache.SetString(key, JsonConvert.SerializeObject(value), options);

        return value;
    }
}