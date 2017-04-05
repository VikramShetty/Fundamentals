using System.Collections;
namespace IteratorAndComposite
{
  public class DinnerMenuEnumerator : IEnumerator 
  {
    MenuItem[] items;
    int position = 0;

    public DinnerMenuEnumerator(MenuItem[] items)
    {
      this.items = items;
    }
    
    public object Current
    {
      get
      {
        MenuItem menuItem = items[position];
        position = position + 1;
        return menuItem;
      }
    }

    public bool MoveNext()
    {
      if (position >= items.Length || items[position] == null)
        return false;
      else
        return true;
    }

    public void Reset()
    {
      position = 0;
    }
  }
}
