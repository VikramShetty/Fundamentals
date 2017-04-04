using System.Collections.Generic;
using System.Text;

namespace IteratorAndComposite
{
  public class Waitress
  {
    public string PrintMenu()
    {
      StringBuilder MenuPad = new StringBuilder();

      PanCakeHouseMenu panCakeHouseMenu = new PanCakeHouseMenu();
      List<MenuItem> breakfastItems = panCakeHouseMenu.getMenuItems();

      DinnerMenu dinerMenu = new DinnerMenu();
      MenuItem[] lunchItems = dinerMenu.getMenuItems();

      for (int i = 0; i < breakfastItems.Count; i++)
      {
        MenuItem menuItem = breakfastItems[i];
        MenuPad.Append(menuItem.GetName() + " ");
        MenuPad.Append(menuItem.GetPrice() + "\n");
        MenuPad.Append(menuItem.GetDescription() + "\n");
      }

      for (int i = 0; i < lunchItems.Length; i++)
      {
        MenuItem menuItem = lunchItems[i];
        if (menuItem != null)
        {
          MenuPad.Append(menuItem.GetName() + " ");
          MenuPad.Append(menuItem.GetPrice() + "\n");
          MenuPad.Append(menuItem.GetDescription() + "\n");
        }
      }
      return MenuPad.ToString();
    }
  }
}
