using System;
using System.Collections.Concurrent;
using System.Linq;

namespace SOLID
{
  public class StoreCache : IStoreWriter, IStoreReader
  {
    private readonly IStoreWriter writer;
    private readonly IStoreReader reader;
    private readonly ConcurrentDictionary<int, Maybe<string>> cache;

    public StoreCache(IStoreWriter writer, IStoreReader reader)
    {
      this.writer = writer;
      this.reader = reader;
      cache = new ConcurrentDictionary<int, Maybe<string>>();
    }

    public void Save(int id, string message)
    {
      this.writer.Save(id, message);
      var m = new Maybe<string>(message);
      this.cache.AddOrUpdate(id, m, (i, s) => m);
    }

    public Maybe<string> Read(int id)
    {
      Maybe<string> message;
      if(this.cache.TryGetValue(id, out message))
        return message;

      message = reader.Read(id);
      if(message.Any())
        this.cache.AddOrUpdate(id, message, (i, s) => message);

      return new Maybe<string>();
    }
  }
}
