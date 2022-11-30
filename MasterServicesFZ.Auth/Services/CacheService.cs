using MasterServicesFZ.Application.Contracts.Auth;
using Microsoft.Extensions.Caching.Memory;

namespace MasterServicesFZ.Auth.Services
{
    public class CacheService : ICacheService
    {
        private static readonly TimeSpan _cacheKeysTimeToLive = new(1, 0, 0);

        private readonly IMemoryCache _memoryCache;
        private readonly IClientService _clientService;

        public CacheService(IMemoryCache memoryCache, IClientService clientService)
        {
            _memoryCache = memoryCache;
            _clientService = clientService;
        }

        public async ValueTask<string?> GetOwnerIdFromApiKey(string apiKey, string domain, string ip)
        {
            //TODO: solo se autentica con la primera key que se encuentre en la lista, no guarda mas de una key, corregir
            if (!_memoryCache.TryGetValue<Dictionary<string, Guid>>("Authentication_ApiKeys", out var internalKeys))
            {
                var isValidApiKey = await _clientService.ValidateApiKey(apiKey, domain, ip);
                if (!isValidApiKey)
                    return null;

                internalKeys = await _clientService.GetActiveClients();

                _memoryCache.Set("Authentication_ApiKeys", internalKeys, _cacheKeysTimeToLive);
            }

            if (!internalKeys.TryGetValue(apiKey, out var clientId))
            {
                return null;
            }

            return clientId.ToString();
        }

        public async Task InvalidateApiKey(string apiKey)
        {
            if (_memoryCache.TryGetValue<Dictionary<string, Guid>>("Authentication_ApiKeys", out var internalKeys))
            {
                if (internalKeys.ContainsKey(apiKey))
                {
                    internalKeys.Remove(apiKey);
                    _memoryCache.Set("Authentication_ApiKeys", internalKeys);
                }
            }

            await _clientService.InvalidateApiKey(apiKey);
        }
    }
}
