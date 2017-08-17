using System;
using System.Collections;

namespace IteratorAndComposite
{
  public abstract class DataComponent
  {
    public virtual void Add(DataComponent dataComponent)
    {
      throw new InvalidOperationException();
    }

    public virtual void Remove(DataComponent dataComponent)
    {
      throw new InvalidOperationException();
    }

    public virtual DataComponent GetChild(int i)
    {
      throw new InvalidOperationException();
    }

    public virtual string GetName()
    {
      throw new InvalidOperationException();
    }

    public string GetField()
    {
      throw new InvalidOperationException();
    }

    public virtual string Print()
    {
      throw new InvalidOperationException();
    }

    public virtual IEnumerator createEnumerator()
    {
      throw new InvalidOperationException();
    }

    public virtual DataComponent Compare(DataComponent filter, DataComponent leafNode)
    {
      throw new InvalidOperationException();
    }

    public virtual bool AllChildAreLeafs()
    {
      throw new InvalidOperationException();
    }

    public virtual bool HasChild()
    {
      throw new InvalidOperationException();
    }    
  }
}
