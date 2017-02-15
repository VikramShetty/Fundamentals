using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID
{
  interface IStoreCache
  {
    void Save(int id, string message);

    Maybe<string> GetOrAdd(int id, Func<int, Maybe<string>> messageFactory);
  }
}
