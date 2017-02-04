using System.IO;

namespace SOLID
{
  public class MessageStoreLog4Net : MessageStore
  {
    public MessageStoreLog4Net(DirectoryInfo workingDirectory)
      : base(workingDirectory)
    {

    }

    public override StoreLogger Log
    {
      get { return new StoreLogger4Net(); }
    }

  }

  public class StoreLogger4Net : StoreLogger
  {
    public override void Saving(int id)
    {
      Log4Net.Information("Saving Message {id}", id);
    }

    public override void Saved(int id)
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