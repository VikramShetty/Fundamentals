
using System.Linq;

namespace SOLID
{
  public class StoreLogger : IStoreWriter, IStoreReader
  {
    private readonly ILogger log;
    private readonly IStoreWriter writer;
    private readonly IStoreReader reader;

    public StoreLogger(ILogger log,
      IStoreWriter writer, IStoreReader reader)
    {
      this.writer = writer;
      this.reader = reader;
      this.log = log;
    }

    public void Save(int id, string message)
    {
      this.log.Information("Saving Message {id}", id);
      this.writer.Save(id, message);
      this.log.Information("Saved Message {id}", id);
    }

    public Maybe<string> Read(int id)
    {
      this.log.Debug("Reading Message {id}", id);
      var retVal = this.reader.Read(id);
      if (retVal.Any())
        this.log.Debug("Returning Message {id}", id);
      else
        this.log.Debug("No Message {id} found", id);

      return retVal;
    }
  }
}
