using System.Collections;

namespace IteratorAndComposite
{
  public class CompositeDataEnumerator : IEnumerator
  {
    Stack stack = new Stack();
    public CompositeDataEnumerator(IEnumerator enumerator)
    {
      stack.Push(enumerator);
    }

    public object Current
    {
      get {
          IEnumerator enumerator = (IEnumerator)stack.Peek();
          DataComponent component = (DataComponent)enumerator.Current;
          if (component.GetType() == typeof(DataNode))
            stack.Push(component.createEnumerator());

          return component;
      }
    }

    public bool MoveNext()
    {
      if (stack.Count == 0)
        return false;
      else
      {
        IEnumerator enumerator = (IEnumerator)stack.Peek();
        if (!enumerator.MoveNext())
        {
          stack.Pop();
          return MoveNext();
        }
        else
          return true;
      }
    }

    public void Reset()
    {
      stack = new Stack();
    }
  }
}
