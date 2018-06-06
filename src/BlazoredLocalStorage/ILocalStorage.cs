namespace Blazored.Storage
{
    public interface ILocalStorage
    {
        void SetItem(string identifier, object data);
        T GetItem<T>(string identifier);
        void RemoveItem(string identifier);
        void Clear();
        int Length();
        string Key(int index);
    }
}