using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorAndComposite
{
  public class Waitress
  {
    List<IMenu> menus;
    public Waitress(List<IMenu> menus)
    {
      this.menus = menus;
    }
    public string PrintMenu()
    {     
      StringBuilder MenuPad = new StringBuilder();
      IEnumerator menuEnumerator = menus.GetEnumerator();
      while (menuEnumerator.MoveNext())
      {
        IMenu menu = (IMenu)menuEnumerator.Current;
        MenuPad.Append(PrintMenu(menu.createEnumerator()));
      }
      return MenuPad.ToString();
    }

    public string PrintMenu(IEnumerator enumerator)
    {
      StringBuilder MenuPad = new StringBuilder();
      while (enumerator.MoveNext()) 
      {
        MenuItem menuItem = (MenuItem)enumerator.Current;
        MenuPad.Append(menuItem.GetName() + ", ");
        MenuPad.Append(menuItem.GetPrice() + " -- \n");
        MenuPad.Append(menuItem.GetDescription() + "\n");
      }     
      return MenuPad.ToString();
    }
  }
}
