using Microsoft.Extensions.DependencyInjection;

namespace Blazored.Storage
{
    public static class LocalStorageStartup
    {
        public static IServiceCollection AddLocalStorage(this IServiceCollection services)
        {
            return services.AddSingleton<ILocalStorage, LocalStorage>();            
        }
    }
}