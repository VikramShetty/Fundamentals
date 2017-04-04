using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComposite
{
  public class PanCakeHouseIterator : Iterator
  {
    List<MenuItem> items;
    int position = 0;

    public PanCakeHouseIterator(List<MenuItem> items)
    {
      this.items = items;
    }

    public bool hasNext()
    {
      if (position >= items.Count)
        return false;
      else
        return true;
    }

    public object next()
    {
      MenuItem menuItem = items[position];
      position = position + 1;
      return menuItem;
    }

    public int Count()
    {
      return items.Count;
    }
  }
}
