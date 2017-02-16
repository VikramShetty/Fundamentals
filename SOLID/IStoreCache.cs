using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID
{
  interface IStoreCache
  {
    Maybe<string> Read(int id);
  }
}
