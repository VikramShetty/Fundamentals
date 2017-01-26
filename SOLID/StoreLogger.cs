
namespace SOLID
{
  public class StoreLogger
  {
    public void Saving(int id)
    {
      Log.Information("Saving Message {id}", id);
    }

    public void Saved(int id)
    {
      Log.Information("Saved Message {id}", id);
    }

    public void Reading(int id)
    {
      Log.Debug("Reading Message {id}", id);
    }

    public void DidNotFind(int id)
    {
      Log.Debug("No Message {id} found", id);
    }

    public void Returning(int id)
    {
      Log.Debug("Returning Message {id}", id);
    }
  }
}
