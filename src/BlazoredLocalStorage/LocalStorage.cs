using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System;

namespace Blazored.Storage
{
    public class LocalStorage : ILocalStorage
    {
        public void SetItem(string identifier, object data)
        {
            if (string.IsNullOrEmpty(identifier))
                throw new ArgumentNullException(nameof(identifier));

            var serialisedData = JsonUtil.Serialize(data);
            RegisteredFunction.Invoke<bool>("Blazored.Storage.LocalStorage.SetItem", identifier, serialisedData);
        }

        public T GetItem<T>(string identifier)
        {
            if (string.IsNullOrEmpty(identifier))
                throw new ArgumentNullException(nameof(identifier));

            var serialisedData = RegisteredFunction.Invoke<string>("Blazored.Storage.LocalStorage.GetItem", identifier);

            if (serialisedData == null)
                return default(T);

            return JsonUtil.Deserialize<T>(serialisedData);
        }

        public void RemoveItem(string identifier)
        {
            if (string.IsNullOrEmpty(identifier))
                throw new ArgumentNullException(nameof(identifier));

            RegisteredFunction.Invoke<string>("Blazored.Storage.LocalStorage.RemoveItem", identifier);
        }

        public void Clear() => RegisteredFunction.Invoke<bool>("Blazored.Storage.LocalStorage.Clear");

        public int Length() => RegisteredFunction.Invoke<int>("Blazored.Storage.LocalStorage.Length");

        public string Key(int index) => RegisteredFunction.Invoke<string>("Blazored.Storage.LocalStorage.Key", index);
    }
}
