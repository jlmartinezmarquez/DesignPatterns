namespace AdapterPattern.Solution.Modules
{
    public interface ICacheAdapter
    {
        object Get(string storageKey);
        void Insert(string key, object value);
    }
}
