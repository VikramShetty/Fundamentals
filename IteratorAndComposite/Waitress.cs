using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorAndComposite
{
  public class Waitress
  {
    MenuComponent allMenus;
    public Waitress(MenuComponent allMenus)
    {
      this.allMenus = allMenus;
    }
    public string PrintMenu()
    {
      return allMenus.Print();
    }
  }
}
