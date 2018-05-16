using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace Blazored.Js
{
    public class LocalStorage
    {
        public void Save(string identifier, object data)
        {
            var serialisedData = JsonUtil.Serialize(data);
            RegisteredFunction.Invoke<bool>("Blazored.Js.LocalStorage.Save", identifier, serialisedData);
        }

        public T Get<T>(string identifier)
        {
            var serialisedData = RegisteredFunction.Invoke<string>("Blazored.Js.LocalStorage.Get", identifier);
            
            if (serialisedData == null)
                return default(T);
            
            return JsonUtil.Deserialize<T>(serialisedData);
        }

        public void Remove(string identifier)
        {
            RegisteredFunction.Invoke<string>("Blazored.Js.LocalStorage.Remove", identifier);
        }
    }
}
