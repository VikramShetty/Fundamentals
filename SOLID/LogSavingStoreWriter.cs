using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
  public class LogSavingStoreWriter : IStoreWriter
  {
    public void Save(int id, string message)
    {
      new Log().Information("Saving Message {id}", id);
    }
  }
}
