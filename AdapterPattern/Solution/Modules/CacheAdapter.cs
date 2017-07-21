using System.Web;

namespace AdapterPattern.Solution.Modules
{
    public class CacheAdapter : ICacheAdapter
    {
        public object Get(string storageKey)
        {
            return HttpContext.Current.Cache.Get(storageKey);
        }

        public void Insert(string key, object value)
        {
            HttpContext.Current.Cache.Insert(key, value);
        }
    }
}
