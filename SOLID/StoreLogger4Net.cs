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

    public StoreLogger4Net(IStoreWriter writer, IStoreReader reader)
      : base(writer, reader)
    {
      this.writer = writer;
      this.reader = reader;
    }

    public void Save(int id, string message)
    {
      Log4Net.Information("Saving Message {id}", id);
      this.writer.Save(id, message);
      Log4Net.Information("Saved Message {id}", id);
    }

    public Maybe<string> Read(int id)
    {
      Log4Net.Debug("Reading Message {id}", id);
      var retVal = this.reader.Read(id);
      if (retVal.Any())
        Log4Net.Debug("Returning Message {id}", id);
      else
        Log4Net.Debug("No Message {id} found", id);

      return retVal;
    }
    public override void Saving(int id, string message)
    {
      Log4Net.Information("Saving Message {id}", id);
    }

    public override void Saved(int id, string message)
    {
      Log4Net.Information("Saved Message {id}", id);
    }

    public override void Reading(int id)
    {
      Log4Net.Debug("Reading Message {id}", id);
    }

    public override void DidNotFind(int id)
    {
      Log4Net.Debug("No Message {id} found", id);
    }

    public override void Returning(int id)
    {
      Log4Net.Debug("Returning Message {id}", id);
    }

  
  }
}
