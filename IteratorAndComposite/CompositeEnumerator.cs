using System.Collections;

namespace IteratorAndComposite
{
  public class CompositeEnumerator : IEnumerator
  {
    Stack stack = new Stack();
    public CompositeEnumerator(IEnumerator enumerator)
    {
      stack.Push(enumerator);
    }
    public object Current
    {
      get {
          IEnumerator enumerator = (IEnumerator)stack.Peek();
          MenuComponent component = (MenuComponent)enumerator.Current;
          if (component.GetType() == typeof(Menu))
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
