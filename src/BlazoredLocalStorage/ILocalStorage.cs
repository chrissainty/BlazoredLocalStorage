using System.Threading.Tasks;

namespace Blazored.Storage
{
    public interface ILocalStorage
    {
        Task SetItem(string identifier, object data);
        Task<T> GetItem<T>(string identifier);
        Task RemoveItem(string identifier);
        Task Clear();
        Task<int> Length();
        Task<string> Key(int index);
    }
}