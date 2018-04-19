using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace Blazored.Js
{
    public static class LocalStorage
    {
        public static void Save(string identifier, object data)
        {
            var serialisedData = JsonUtil.Serialize(data);
            RegisteredFunction.Invoke<bool>("Blazored.Js.LocalStorage.Save", identifier, serialisedData);
        }

        public static T Get<T>(string identifier)
        {
            var serialisedData = RegisteredFunction.Invoke<string>("Blazored.Js.LocalStorage.Get", identifier);
            
            if (serialisedData == null)
                return default(T);
            
            return JsonUtil.Deserialize<T>(serialisedData);
        }

        public static void Remove(string identifier)
        {
            RegisteredFunction.Invoke<string>("Blazored.Js.LocalStorage.Remove", identifier);
        }
    }
}
