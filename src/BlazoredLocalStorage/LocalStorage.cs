using System;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazored.Storage
{
    public class LocalStorage : ILocalStorage
    {
        public Task SetItem(string key, object data)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            return JSRuntime.Current.InvokeAsync<object>("blazored.localStorage.setItem", key, Json.Serialize(data));
        }

        public async Task<T> GetItem<T>(string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            var serialisedData = await JSRuntime.Current.InvokeAsync<string>("blazored.localStorage.getItem", key);

            if (serialisedData == null)
                return default(T);

            return Json.Deserialize<T>(serialisedData);
        }

        public Task RemoveItem(string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            return JSRuntime.Current.InvokeAsync<string>("blazored.localStorage.removeItem", key);
        }

        public Task Clear() => JSRuntime.Current.InvokeAsync<bool>("blazored.localStorage.clear");

        public Task<int> Length() => JSRuntime.Current.InvokeAsync<int>("blazored.localStorage.length");

        public Task<string> Key(int index) => JSRuntime.Current.InvokeAsync<string>("blazored.localStorage.key", index);
    }
}
