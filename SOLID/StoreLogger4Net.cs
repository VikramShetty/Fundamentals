using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
  public class StoreLogger4Net : StoreLogger
  {
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
