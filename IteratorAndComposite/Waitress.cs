using System.Collections.Generic;
using System.Text;

namespace IteratorAndComposite
{
  public class Waitress
  {
    StringBuilder MenuPad = new StringBuilder();
    public string PrintMenu()
    {     
      PanCakeHouseMenu panCakeHouseMenu = new PanCakeHouseMenu();
      Iterator panCakeHouseIterator = panCakeHouseMenu.createIterator();

      DinnerMenu dinerMenu = new DinnerMenu();
      Iterator dinnerIterator = dinerMenu.createIterator();

      PrintMenu(panCakeHouseIterator);
      return PrintMenu(dinnerIterator);
    }

    public string PrintMenu(Iterator iterator)
    {
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
