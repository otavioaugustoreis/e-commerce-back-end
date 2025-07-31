using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services.Cache
{
    public class CachingService(
        IDistributedCache distributedCach) : ICacheService
    {

        private readonly IDistributedCache _cache = distributedCach;
        private readonly DistributedCacheEntryOptions _options = new()
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(3600),
            SlidingExpiration = TimeSpan.FromSeconds(1200),
        };


        public async Task<string> GetAsync(string key)
        {
           return await _cache.GetStringAsync(key);
        }

        public async Task SetAsync(string key, string value)
        {
            await _cache.SetStringAsync(key, value, _options);    
        }
    }
}
