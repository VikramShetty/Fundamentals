
using System.Linq;

namespace SOLID
{
  public class StoreLogger : IStoreLogger, IStoreWriter, IStoreReader
  {
    private readonly IStoreWriter writer;
    private readonly IStoreReader reader;

    public StoreLogger(IStoreWriter writer, IStoreReader reader)
    {
      this.writer = writer;
      this.reader = reader;
    }

    public void Save(int id, string message)
    {
      Log.Information("Saving Message {id}", id);
      this.writer.Save(id, message);
      Log.Information("Saved Message {id}", id);
    }

    public Maybe<string> Read(int id)
    {
      Log.Debug("Reading Message {id}", id);
      var retVal = this.reader.Read(id);
      if (retVal.Any())
        Log.Debug("Returning Message {id}", id);
      else
        Log.Debug("No Message {id} found", id);

      return retVal;
    }
    public virtual void Saving(int id, string message)
    {
      Log.Information("Saving Message {id}", id);
    }

    public virtual void Saved(int id, string message)
    {
      Log.Information("Saved Message {id}", id);
    }

    public virtual void Reading(int id)
    {
      Log.Debug("Reading Message {id}", id);
    }

    public virtual void DidNotFind(int id)
    {
      Log.Debug("No Message {id} found", id);
    }

    public virtual void Returning(int id)
    {
      Log.Debug("Returning Message {id}", id);
    }
  }
}
