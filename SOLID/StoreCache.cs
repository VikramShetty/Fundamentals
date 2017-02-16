using System;
using System.Collections.Concurrent;

namespace SOLID
{
  public class StoreCache : IStoreCache, IStoreWriter
  {
    private readonly ConcurrentDictionary<int, Maybe<string>> cache;

    public StoreCache()
    {
      cache = new ConcurrentDictionary<int, Maybe<string>>();
    }

    public virtual void Save(int id, string message)
    {
      var m = new Maybe<string>(message);
      this.cache.AddOrUpdate(id, m, (i, s) => m);
    }

    public virtual Maybe<string> GetOrAdd(int id, Func<int, Maybe<string>> messageFactory)
    {
     return this.cache.GetOrAdd(id, messageFactory);
    }
  }
}
