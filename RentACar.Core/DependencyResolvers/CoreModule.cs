using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using RentACar.Core.CrossCuttingConcerns.Caching;
using RentACar.Core.CrossCuttingConcerns.Caching.Microsoft;
using RentACar.Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
