using System;
using System.Collections.Concurrent;
using System.Linq;

namespace SOLID
{
  public class StoreCache : IStoreCache, IStoreWriter
  {
    private readonly IStoreWriter writer;
    private readonly ConcurrentDictionary<int, Maybe<string>> cache;

    public StoreCache(IStoreWriter writer)
    {
      this.writer = writer;
      cache = new ConcurrentDictionary<int, Maybe<string>>();
    }

    public virtual void Save(int id, string message)
    {
      this.writer.Save(id,message);
      var m = new Maybe<string>(message);
      this.cache.AddOrUpdate(id, m, (i, s) => m);
    }

    public virtual Maybe<string> GetOrAdd(int id)
    {
      Maybe<string> message;
     this.cache.TryGetValue(id, out message);
      return message;
    }
  }
}
