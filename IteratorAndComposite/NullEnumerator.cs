using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorAndComposite
{
  public class NullEnumerator : IEnumerator
  {

    public object Current
    {
      get { return null; }
    }

    public bool MoveNext()
    {
      return false;
    }

    public void Reset()
    {
      throw new InvalidOperationException();
    }
  }
}
