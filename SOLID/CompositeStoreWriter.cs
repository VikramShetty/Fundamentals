using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
  public class CompositeStoreWriter : IStoreWriter
  {
    private readonly IStoreWriter[] storeWriters;
    public CompositeStoreWriter(params IStoreWriter[] storeWriters)
    {
      this.storeWriters = storeWriters;
    }

    public void Save(int id, string message)
    {
      foreach (var storeWriter in storeWriters)
        storeWriter.Save(id, message);
    }
  }
}
