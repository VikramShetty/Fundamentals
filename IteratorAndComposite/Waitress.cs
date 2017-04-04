using System.Collections.Generic;
using System.Text;

namespace IteratorAndComposite
{
  public class Waitress
  {
    PanCakeHouseMenu panCakeHouseMenu;
    DinnerMenu dinerMenu;
    public Waitress(PanCakeHouseMenu panCakeHouseMenu, DinnerMenu dinerMenu)
    {
      this.panCakeHouseMenu = panCakeHouseMenu;
      this.dinerMenu = dinerMenu;
    }
    public string PrintMenu()
    {     
      StringBuilder MenuPad = new StringBuilder();
      Iterator panCakeHouseIterator = panCakeHouseMenu.createIterator();
      Iterator dinnerIterator = dinerMenu.createIterator();

      MenuPad.Append(PrintMenu(panCakeHouseIterator));
      MenuPad.Append(PrintMenu(dinnerIterator));

      return MenuPad.ToString();
    }

    public string PrintMenu(Iterator iterator)
    {
      StringBuilder MenuPad = new StringBuilder();
      while (iterator.hasNext()) {
        MenuItem menuItem = (MenuItem)iterator.next();
        MenuPad.Append(menuItem.GetName() + " ");
        MenuPad.Append(menuItem.GetPrice() + "\n");
        MenuPad.Append(menuItem.GetDescription() + "\n");
      }
      return MenuPad.ToString();
    }
  }
}
