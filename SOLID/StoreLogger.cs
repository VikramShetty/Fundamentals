
namespace SOLID
{
  public class StoreLogger
  {
    public virtual void Saving(int id)
    {
      Log.Information("Saving Message {id}", id);
    }

    public virtual void Saved(int id)
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
