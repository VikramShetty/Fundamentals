using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComposite
{
  public abstract class MenuComponent
  {
    public virtual void add(MenuComponent menuComponent)
    {
      throw new InvalidOperationException();
    }

    public void remove(MenuComponent menuComponent)
    {
      throw new InvalidOperationException();
    }

    public MenuComponent getChild(int i)
    {
      throw new InvalidOperationException();
    }

    public string getName()
    {
      throw new InvalidOperationException();
    }

    public string GetDescription()
    {
      throw new InvalidOperationException();
    }

    public double GetPrice()
    {
      throw new InvalidOperationException();
    }

    public bool IsVegetarian()
    {
      throw new InvalidOperationException();
    }

    public virtual string Print()
    {
      throw new InvalidOperationException();
    }
  }
}
