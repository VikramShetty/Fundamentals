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
      List<MenuItem> breakfastItems = panCakeHouseMenu.getMenuItems();

      DinnerMenu dinerMenu = new DinnerMenu();
      Iterator dinnerIterator = dinerMenu.createIterator();

      for (int i = 0; i < breakfastItems.Count; i++)
      {
        MenuItem menuItem = breakfastItems[i];
        MenuPad.Append(menuItem.GetName() + " ");
        MenuPad.Append(menuItem.GetPrice() + "\n");
        MenuPad.Append(menuItem.GetDescription() + "\n");
      }

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
