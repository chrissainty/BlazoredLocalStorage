using Microsoft.Extensions.DependencyInjection;

namespace Blazored.Js 
{
    public static class LocalStorageStartup
    {
        public static IServiceCollection AddLocalStorage(this IServiceCollection services)
        {
            return services.AddSingleton<LocalStorage>();            
        }
    }
}