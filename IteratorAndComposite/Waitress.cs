using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorAndComposite
{
  public class Waitress
  {
    Menu panCakeHouseMenu;
    Menu dinerMenu;
    public Waitress(Menu panCakeHouseMenu, Menu dinerMenu)
    {
      this.panCakeHouseMenu = panCakeHouseMenu;
      this.dinerMenu = dinerMenu;
    }
    public string PrintMenu()
    {     
      StringBuilder MenuPad = new StringBuilder();
      IEnumerator panCakeHouseEnumerator = panCakeHouseMenu.createEnumerator();
      IEnumerator dinnerEnumerator = dinerMenu.createEnumerator();

      MenuPad.Append("MENU\n----\nBREAKFAST\n");
      MenuPad.Append(PrintMenu(panCakeHouseEnumerator));
      MenuPad.Append("\nLUNCH\n");
      MenuPad.Append(PrintMenu(dinnerEnumerator));
      
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
