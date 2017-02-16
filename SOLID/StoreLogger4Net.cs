using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
  public class StoreLogger4Net : StoreLogger
  {
    private readonly IStoreWriter writer;
    private readonly IStoreReader reader;
    private readonly ILogger log;

    public StoreLogger4Net(ILogger log, IStoreWriter writer, IStoreReader reader)
      : base(log, writer, reader)
    {
      this.log = log;
      this.writer = writer;
      this.reader = reader;
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
